using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BookingsRepository : RepositoryBase<Bookings>,IBookingsRepository
    {
        public BookingsRepository(RoomieDbContext context)
            :base(context)
        {
        }
    }
}
