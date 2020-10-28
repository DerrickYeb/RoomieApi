
using Entities.Configuration;
using Entities.Hostels;
using Entities.Students;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class RoomieDbContext:DbContext
    {
        public RoomieDbContext(DbContextOptions<RoomieDbContext> options)
           : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new HostelConfiguration());
            modelBuilder.ApplyConfiguration(new BookingsConfiguration());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
    }
}
