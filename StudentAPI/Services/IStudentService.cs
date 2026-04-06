using StudentAPI.Models;
namespace StudentAPI.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();
        Task AddStudent(Student student);
        Task<Student?> GetById(int id);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
