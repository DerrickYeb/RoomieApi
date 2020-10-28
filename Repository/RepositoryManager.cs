using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RoomieDbContext _context;
        private IStudentsRepository _students;
        private IHostelRepository _hostel;
        private IBookingsRepository _bookings;
        public RepositoryManager(RoomieDbContext context)
        {
            _context = context;
        }

        public IStudentsRepository Students
        {
            get
            {
                if (_students == null)
                    _students = new StudentRepository(_context);
                return _students;
            }
            
        }

        public IHostelRepository Hostel
        {
            get
            {
                if (_hostel == null)
                    _hostel = new HostelRepository(_context);
                return _hostel;
            }
        }

        public IBookingsRepository Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new BookingsRepository(_context);
                return _bookings;
            }
        }

        public void Save() => _context.SaveChanges();
        
    }
}
