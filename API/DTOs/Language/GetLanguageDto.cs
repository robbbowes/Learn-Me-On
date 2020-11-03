using System.Collections.Generic;
using API.DTOs.Course;
using API.Entities;

namespace API.DTOs.Language
{
    public class GetLanguageDto
    {
        public int Id { get; set; }
        public LanguageEnum LanguageEnum { get; set; }
        public string Name { get; set; }
        public List<GetCourseDto> Courses { get; set; }
    }
}