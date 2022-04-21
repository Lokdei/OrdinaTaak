using OrdinaTaak.Readers;

namespace OrdinaTaak
{
    public class User
    {
        public string ReadFile(string filePath, OFileType fileType)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            if (fileType == OFileType.Text)
            {
                var reader = new OReadTextFile();
                return reader.ReadFile(filePath);
            }
            else if (fileType == OFileType.XML)
            {
                var reader = new OReadXMLFile();
                return reader.ReadFile(filePath);
            }

            return string.Empty;
        }
    }
}
