using AutoMapper;
using Entities.DTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomieApi
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentsDto>()
                .ForMember(c => c.FullName, opts => opts.MapFrom(x => string.Join(" ", x.FirstName, x.LastName)));
                
        } 
    }
}
