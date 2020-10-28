using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public class HostelRepository:RepositoryBase<Hostel>,IHostelRepository
    {
        public HostelRepository(RoomieDbContext context):
            base(context)
        {
        }
    }
}
