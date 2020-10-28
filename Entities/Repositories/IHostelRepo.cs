
using Entities.Hostels;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repositories
{
    public interface IHostelRepo
    {
        public Task<IEnumerable<Hostel>> GetHostels();
        public Task AddHostel(Hostel hostel);
        public Task UpdateHostel(Hostel hostel);
        public Task<Hostel> GetHostelById(int id);
        public Task<Hostel> GetHostelBySchool(string schoolName);
        public Task<Hostel> GetHostelByLocation(string location);
        public Task<Hostel> Delete(int id);
        public Task Authenticate(Authenticate authenticate);
        public bool SaveChanges();
    }
}
