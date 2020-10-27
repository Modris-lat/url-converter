namespace NeuedaHomeTask.GetCharactersForShortUrlCode
{
    public static class GetSecondChar
    {
        public static string GetSecondCharacter(string url)
        {
            return url.Split('.')[0].Length.ToString().Substring(0, 1);
        }
    }
}
