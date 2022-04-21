namespace OrdinaTaak
{
    public class User
    {
        public string ReadFile(string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            return ReadFile(filePath);
        }
    }
}
