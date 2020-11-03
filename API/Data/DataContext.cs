using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Assimil Swedish Old",
                    LanguageId = 1
                },
                new Course
                {
                    Id = 2,
                    Name = "Korean Linguaphone",
                    LanguageId = 2
                }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language
                {
                    Id = 1,
                    LanguageEnum = LanguageEnum.Swedish,
                    Name = "Swedish"
                },
                new Language
                {
                    Id = 2,
                    LanguageEnum = LanguageEnum.Korean,
                    Name = "Korean"
                }
            );

            modelBuilder.Entity<Lesson>().HasData(
                new Lesson
                {
                    Id = 1,
                    Number = 1,
                    LessonLanguage = LanguageEnum.Swedish,
                    CourseId = 1,
                    LessonAudio = "local data",
                    Sentences = null,
                    LessonStatus = LessonStatus.ListenBlindFirst
                },
                new Lesson
                {
                    Id = 2,
                    Number = 2,
                    LessonLanguage = LanguageEnum.Swedish,
                    CourseId = 1,
                    LessonAudio = "local data",
                    Sentences = null,
                    LessonStatus = LessonStatus.NotStarted
                },
                                new Lesson
                {
                    Id = 3,
                    Number = 1,
                    LessonLanguage = LanguageEnum.Korean,
                    CourseId = 2,
                    LessonAudio = "local data",
                    Sentences = null,
                    LessonStatus = LessonStatus.ListenBlindFirst
                },
                new Lesson
                {
                    Id = 4,
                    Number = 2,
                    LessonLanguage = LanguageEnum.Korean,
                    CourseId = 2,
                    LessonAudio = "local data",
                    Sentences = null,
                    LessonStatus = LessonStatus.NotStarted
                }
            );

            modelBuilder.Entity<Sentence>().HasData(
                new Sentence
                {
                    Id = 1,
                    Number = 1,
                    SentenceLanguage = LanguageEnum.Swedish,
                    SentenceText = "Hurdy gurdy",
                    SentenceAudio = "local sentence audio file",
                    RecordedAudio = "local saved user audio",
                    LessonId = 1
                },
                new Sentence
                {
                    Id = 2,
                    Number = 2,
                    SentenceLanguage = LanguageEnum.Swedish,
                    SentenceText = "Hurdy gurdy line 2",
                    SentenceAudio = "local sentence audio file 2",
                    RecordedAudio = "local saved user audio 2",
                    LessonId = 1
                }
            );

            modelBuilder.Entity<Translation>().HasData(
                new Translation
                {
                    Id = 1,
                    TranslationLanguage = LanguageEnum.English,
                    TranslationText = "The English for hurdy gurdy",
                    SentenceId = 1
                },
                new Translation
                {
                    Id = 2,
                    TranslationLanguage = LanguageEnum.French,
                    TranslationText = "The French for hurdy gurdy",
                    SentenceId = 1
                },
                new Translation
                {
                    Id = 3,
                    TranslationLanguage = LanguageEnum.English,
                    TranslationText = "The English for hurdy gurdy 2",
                    SentenceId = 2
                },
                new Translation
                {
                    Id = 4,
                    TranslationLanguage = LanguageEnum.French,
                    TranslationText = "The French for hurdy gurdy 2",
                    SentenceId = 2
                }
            );

        }


    }
}