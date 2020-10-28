using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IStudentsRepository Students { get; }
        IHostelRepository Hostel { get; }
        IBookingsRepository Bookings { get; }
        void Save();
    }
}
