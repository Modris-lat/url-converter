namespace NeuedaHomeTask.GetCharactersForShortUrlCode
{
    public static class GetFirstChar
    {
        public static string GetFirstCharacter(string url)
        {
            return url.Length.ToString().Substring(0, 1);
        }
    }
}
