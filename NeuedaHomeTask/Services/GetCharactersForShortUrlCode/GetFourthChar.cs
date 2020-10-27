namespace NeuedaHomeTask.GetCharactersForShortUrlCode
{
    public static class GetFourthChar
    {
        public static string GetFourthCharacter(string url)
        {
            return url[url.Length - 1].ToString().ToUpper();
        }
    }
}
