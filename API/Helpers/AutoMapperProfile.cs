using API.DTOs.Course;
using API.DTOs.Language;
using API.DTOs.Lesson;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Course, GetCourseDto>();
            CreateMap<Language, GetLanguageDto>();
            CreateMap<Language, GetCourseLanguageDto>();
            CreateMap<Lesson, GetLessonDto>();
        }
    }
}