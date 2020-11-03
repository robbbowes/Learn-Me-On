using API.Entities;

namespace API.DTOs.Language
{
    public class GetCourseLanguageDto
    {
        public int Id { get; set; }
        public LanguageEnum LanguageEnum { get; set; }
        public string Name { get; set; }
    }
}