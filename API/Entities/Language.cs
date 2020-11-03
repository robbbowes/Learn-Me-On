using System.Collections.Generic;

namespace API.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public LanguageEnum LanguageEnum { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}