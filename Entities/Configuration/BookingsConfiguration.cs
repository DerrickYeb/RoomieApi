using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class BookingsConfiguration : IEntityTypeConfiguration<Bookings>
    {
        public void Configure(EntityTypeBuilder<Bookings> builder)
        {
            builder.HasData(
                new Bookings
                {
                    Id = 1,
                    StudentName = "Derrick Yeboah",
                    Course = "Computer Science",
                    RoomCapacity = "2 in a room",
                    Phone = "0549234591",
                    Level = "200",
                    IsConfirmed = true
                });
        }
    }
}
