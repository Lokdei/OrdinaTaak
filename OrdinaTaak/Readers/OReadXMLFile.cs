using OrdinaTaak.Auth;

namespace OrdinaTaak.Readers
{
    public class ReadXMLRole : IRole
    {
        public string Name { get { return "ReadXML"; } }
    }

    internal class OReadXMLFile : OFileReader, IReadPermission
    {
        public string Name { get { return "ReadXML"; } }

        public override string ReadFile(string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath)) throw new FileNotFoundException();

            string text = File.ReadAllText(filePath);
            return text;
        }
    }
}
