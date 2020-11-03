using System.Collections.Generic;

namespace API.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public LanguageEnum LessonLanguage { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public string LessonAudio { get; set; }
        public List<Sentence> Sentences { get; set; }
        public LessonStatus LessonStatus { get; set; }
        public string FullAudio { get; set; }
    }
}