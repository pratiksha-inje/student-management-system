using StudentAPI.Models;
using StudentAPI.Repositories;
namespace StudentAPI.Services
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetAllStudents() =>
            await _repo.GetAll();
        public async Task AddStudent(Student student)
        {
            student.CreatedDate = DateTime.Now;
            await _repo.Add(student);
        }
        public async Task<Student?> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task UpdateStudent(Student student)
        {
            await _repo.Update(student);
        }

        public async Task DeleteStudent(int id)
        {
            await _repo.Delete(id);
        }
    }
}
