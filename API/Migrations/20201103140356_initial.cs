using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageEnum = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Passwordsalt = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    LessonLanguage = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    LessonAudio = table.Column<string>(type: "TEXT", nullable: true),
                    LessonStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    FullAudio = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sentence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    SentenceLanguage = table.Column<int>(type: "INTEGER", nullable: false),
                    SentenceText = table.Column<string>(type: "TEXT", nullable: true),
                    SentenceAudio = table.Column<string>(type: "TEXT", nullable: true),
                    RecordedAudio = table.Column<string>(type: "TEXT", nullable: true),
                    LessonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sentence_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TranslationLanguage = table.Column<int>(type: "INTEGER", nullable: false),
                    TranslationText = table.Column<string>(type: "TEXT", nullable: true),
                    SentenceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translation_Sentence_SentenceId",
                        column: x => x.SentenceId,
                        principalTable: "Sentence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "LanguageEnum", "Name" },
                values: new object[] { 1, 3, "Swedish" });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "LanguageEnum", "Name" },
                values: new object[] { 2, 4, "Korean" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Name" },
                values: new object[] { 1, 1, "Assimil Swedish Old" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Name" },
                values: new object[] { 2, 2, "Korean Linguaphone" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "FullAudio", "LessonAudio", "LessonLanguage", "LessonStatus", "Number" },
                values: new object[] { 1, 1, null, "local data", 3, 1, 1 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "FullAudio", "LessonAudio", "LessonLanguage", "LessonStatus", "Number" },
                values: new object[] { 2, 1, null, "local data", 3, 0, 2 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "FullAudio", "LessonAudio", "LessonLanguage", "LessonStatus", "Number" },
                values: new object[] { 3, 2, null, "local data", 4, 1, 1 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "FullAudio", "LessonAudio", "LessonLanguage", "LessonStatus", "Number" },
                values: new object[] { 4, 2, null, "local data", 4, 0, 2 });

            migrationBuilder.InsertData(
                table: "Sentence",
                columns: new[] { "Id", "LessonId", "Number", "RecordedAudio", "SentenceAudio", "SentenceLanguage", "SentenceText" },
                values: new object[] { 1, 1, 1, "local saved user audio", "local sentence audio file", 3, "Hurdy gurdy" });

            migrationBuilder.InsertData(
                table: "Sentence",
                columns: new[] { "Id", "LessonId", "Number", "RecordedAudio", "SentenceAudio", "SentenceLanguage", "SentenceText" },
                values: new object[] { 2, 1, 2, "local saved user audio 2", "local sentence audio file 2", 3, "Hurdy gurdy line 2" });

            migrationBuilder.InsertData(
                table: "Translation",
                columns: new[] { "Id", "SentenceId", "TranslationLanguage", "TranslationText" },
                values: new object[] { 1, 1, 1, "The English for hurdy gurdy" });

            migrationBuilder.InsertData(
                table: "Translation",
                columns: new[] { "Id", "SentenceId", "TranslationLanguage", "TranslationText" },
                values: new object[] { 2, 1, 2, "The French for hurdy gurdy" });

            migrationBuilder.InsertData(
                table: "Translation",
                columns: new[] { "Id", "SentenceId", "TranslationLanguage", "TranslationText" },
                values: new object[] { 3, 2, 1, "The English for hurdy gurdy 2" });

            migrationBuilder.InsertData(
                table: "Translation",
                columns: new[] { "Id", "SentenceId", "TranslationLanguage", "TranslationText" },
                values: new object[] { 4, 2, 2, "The French for hurdy gurdy 2" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LanguageId",
                table: "Courses",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_LessonId",
                table: "Sentence",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_SentenceId",
                table: "Translation",
                column: "SentenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Translation");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sentence");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
