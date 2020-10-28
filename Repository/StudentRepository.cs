using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class StudentRepository :RepositoryBase<Student>,IStudentsRepository
    {
        public StudentRepository(RoomieDbContext context) :
            base(context)
        {
        }

        public IEnumerable<Student> GetAllStudents(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.FirstName)
            .ToList();
        
    }
}
