namespace Sample.Core.Helpers
{
    public static class StudentExtension
    {
        public static long GenerateStudentId(this int id)
        {
            var now = DateTime.UtcNow;
            var paddedId = id.ToString().PadLeft(3, '0');
            return long.Parse($"{now.ToString("yyMM")}{paddedId}");
        }
    }
}
