using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repositories
{
    public interface IBookingsRepo
    {
        public Task Book(Bookings bookings);
        public Task<IEnumerable<Bookings>> BookedStudents();
        public Task<Bookings> GetBookingById(int id);
        public Task<Bookings> DeleteBookings(int id);
        bool SaveChanges();
    }
}
