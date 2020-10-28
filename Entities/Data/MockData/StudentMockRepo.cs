using Entities.Hostels;
using Entities.Models;
using Entities.Repositories;
using Entities.Students;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Data.MockData
{
    public class StudentMockRepo : IStudentsRepo
    {
        private RoomieDbContext _context;


        public StudentMockRepo(RoomieDbContext context)
        {
            _context = context;
        }
        public Task Authenticate(AuthenticateStudent authenticate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hostel>> BookedHostel(int id)
        {
            //return await (from t in _context.Bookings where t.StudentID == id).
            throw new NotImplementedException();
        }

        public Task<Student> DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetStudent()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Register(Student student)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAccount(Student student)
        {
            throw new NotImplementedException();
        }

        Task<Hostel> IStudentsRepo.BookedHostel()
        {
            throw new NotImplementedException();
        }
    }
}
