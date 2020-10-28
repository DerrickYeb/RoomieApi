using Entities.Hostels;
using Entities.Models;
using Entities.Students;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repositories
{
    public interface IStudentsRepo
    {
        public Task<Student> GetStudentById(int id);
        public Task Register(Student student);
        public Task UpdateAccount(Student student);
        public Task<Student> DeleteAccount(int id);
        public Task<IEnumerable<Student>> GetStudent();
        public Task Authenticate(AuthenticateStudent authenticate);
        public Task<Hostel> BookedHostel();
        public bool SaveChanges();
    }
}
