namespace OrdinaTaak.Helpers
{
    internal class StringUtility
    {
        // Copies the characters of input to a new string and reverses the new string in-place.
        // https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string
        public static string ReverseInPlace(string input)
        {
            return string.Create(input.Length, input, (chars, state) =>
            {
                state.AsSpan().CopyTo(chars);
                chars.Reverse();
            });
        }
    }
}
