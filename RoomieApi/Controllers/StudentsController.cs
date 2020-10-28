using AutoMapper;
using Contracts;
using Entities.Data;
using Entities.DTO;
using Entities.Models;
using Entities.Students;
using LoggerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomieApi.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private IRepositoryManager _reposistory;
        private readonly IMapper _mapper;

        public StudentsController(ILoggerManager logger, IRepositoryManager repository, IMapper mapper)
        {
            _logger = logger;
            _reposistory = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
           
            var students = _reposistory.Students.GetAllStudents(trackChanges: false);
            var studentsDto = _mapper.Map<IEnumerable<StudentsDto>>(students);
            return Ok(studentsDto);


        }

        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    _reposistory.Bookings.ToString();
        //    return new string[] { "value1", "value2" };
        //}

    }
}
