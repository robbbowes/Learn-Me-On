namespace API.Entities
{
    public enum LessonStatus
    {
        NotStarted = 0,
        ListenBlindFirst = 1,
        ListenReadL1First = 2,
        ReadAloudL2 = 3,
        ListenReadL1Second = 4,
        ListenReadL2 = 5,
        ListenBlindSecond = 6,
        ShadowBlind = 7,
        ReadComments = 8,
        TranscribeL2 = 9,
        TranslateIntoL1 = 10
    }
}