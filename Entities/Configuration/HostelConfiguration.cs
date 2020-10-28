using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class HostelConfiguration : IEntityTypeConfiguration<Hostel>
    {
        public void Configure(EntityTypeBuilder<Hostel> builder)
        {
            builder.HasData
                 (
                new Hostel
                {
                    Id = 1,
                    HostelName = "Harvard Green Hostel",
                    Location = "Sunyani",
                    Description = "Lucrative rooms with space",
                    IsRoomAvailable = true,
                    RoomCapacity = "1",
                    Region = "Bono Region",
                   
                }
                );
        }
    }
}
