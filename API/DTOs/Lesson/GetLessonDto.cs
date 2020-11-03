using System.Collections.Generic;
using API.DTOs.Sentence;
using API.Entities;

namespace API.DTOs.Lesson
{
    public class GetLessonDto
    {
        public int Number { get; set; }
        public LanguageEnum LessonLanguage { get; set; }
        public int CourseId { get; set; }
        public string LessonAudio { get; set; }
        public List<GetSentenceDto> Sentences { get; set; }
        public LessonStatus LessonStatus { get; set; }
        // public string FullAudio { get; set; }
    }
}