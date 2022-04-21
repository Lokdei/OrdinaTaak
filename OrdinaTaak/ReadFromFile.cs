namespace OrdinaTaak
{
    public class ReadFromFile
    {
        public static string ReadFile(string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath)) throw new FileNotFoundException();

            string text = File.ReadAllText(filePath);
            return text;
        }
    }


}