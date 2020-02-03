using EminentTest.Abstraction.DataAccess;
using EminentTest.Abstraction.Service.Data;
using EminentTest.DB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EminentTest.Abstraction.Repository
{
    public class StudentRepository : IStudentDataService
    {
        private readonly EminentTestContext _context;

        public StudentRepository(EminentTestContext context)
        {
            _context = context;
        }

        public async Task<Guid> AddStudent(Student model)
        {
            Guid id = Guid.Empty;
            try
            {
                model.Id = Guid.NewGuid();
                await _context.AddAsync<Student>(model);
                await _context.SaveChangesAsync();
                id = model.Id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return id;
        }

        public async Task DeleteStudent(Guid id)
        {
            var student = await _context.Students.FindAsync(id);
            if(student != null)
            {
                    _context.Students.Remove(student);
                    await _context.SaveChangesAsync();
            }
        }

        public async Task<Student> GetStudent(Guid id)
        {
            var student =  await _context.Students.FindAsync(id);
            return student;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            var result = await _context.Students.ToListAsync();
            return result;
        }

        public async Task<Guid> UpdateStudent(Student model)
        {
            var student = await _context.Students.FindAsync(model.Id);
            if (student != null)
                _context.Students.Update(student);
            return student.Id;
        }
    }
}
