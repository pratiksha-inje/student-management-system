using Xunit;
using Moq;
using StudentAPI.Services;
using StudentAPI.Repositories;
using StudentAPI.Models;

public class StudentServiceTests
{
    [Fact]
    public async Task AddStudent_Should_Call_Repository()
    {
        var mockRepo = new Mock<IStudentRepository>();

        var service = new StudentService(mockRepo.Object);

        var student = new Student
        {
            Name = "Test",
            Email = "test@test.com",
            Course = "IT"
        };

        await service.AddStudent(student);

        mockRepo.Verify(x => x.Add(student), Times.Once);
    }
}