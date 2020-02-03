using EminentTest.DB.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EminentTest.Abstraction.Service.Data
{
    public interface IStudentDataService
    {
        public Task<Guid> AddStudent(Student model);
        public Task<IEnumerable<Student>> GetStudents();
        public Task<Student> GetStudent(Guid id);
        public Task<Guid> UpdateStudent(Student model);
        public Task DeleteStudent(Guid id);
    }
}
