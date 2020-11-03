namespace API.Entities
{
    public class Translation
    {
        public int Id { get; set; }
        public LanguageEnum TranslationLanguage { get; set; }
        public string TranslationText { get; set; }
        public Sentence Sentence { get; set; }
        public int SentenceId { get; set; }
    }
}