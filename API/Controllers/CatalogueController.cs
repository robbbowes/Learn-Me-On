using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs.Course;
using API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class CatalogueController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CatalogueController(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCourseDto>>> GetCourses()
        {
            List<Course> dbCourses = await _context.Courses
                .Include(c => c.Language)
                .Include(c => c.Lessons)
                .ToListAsync();
            return dbCourses.Select(c => _mapper.Map<GetCourseDto>(c)).ToList();
        }

    }
}