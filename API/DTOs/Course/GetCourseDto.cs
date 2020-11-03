using System.Collections.Generic;
using API.DTOs.Language;
using API.DTOs.Lesson;

namespace API.DTOs.Course
{
    public class GetCourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public GetCourseLanguageDto Language { get; set; }
        public List<GetLessonDto> Lessons { get; set; }
    }
}