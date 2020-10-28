using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
                (
                new Student
                {
                    Id = 1,
                    StudentId = 1,
                    FirstName = "Derrick",
                    LastName = "Yeboah",
                    Phone = "0549234567",
                    Password = "24533",
                }
                );
        }
    }
}
