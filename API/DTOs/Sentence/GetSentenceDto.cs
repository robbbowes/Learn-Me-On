using System.Collections.Generic;
using API.DTOs.Text;
using API.Entities;

namespace API.DTOs.Sentence
{
    public class GetSentenceDto
    {
        public int Number { get; set; }
        public LanguageEnum BaseLanguage { get; set; }
        public List<LanguageEnum> TargetLanguages { get; set; }
        public string BaseText { get; set; }
        public List<GetTextDto> TargetTexts { get; set; }
        public string BaseAudio { get; set; }
        public string RecordedAudio { get; set; }
    }
}