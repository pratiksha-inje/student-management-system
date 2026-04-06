using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Models;
namespace StudentAPI.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> GetAll() =>
       await _context.Students.ToListAsync();

        public async Task<Student> GetById(int id) =>
            await _context.Students.FindAsync(id);

        public async Task Add(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var s = await _context.Students.FindAsync(id);
            _context.Students.Remove(s);
            await _context.SaveChangesAsync();
        }

    }
}
