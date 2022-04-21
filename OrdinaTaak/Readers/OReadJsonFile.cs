using OrdinaTaak.Auth;

namespace OrdinaTaak.Readers
{
    public class ReadJSONRole : IRole
    {
        public string Name { get { return "ReadJSON"; } }
    }

    internal class OReadJsonFile : OFileReader, IReadPermission
    {
        public string Name { get { return "ReadJSON"; } }

        public override string ReadFile(string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath)) throw new FileNotFoundException();

            string text = File.ReadAllText(filePath);
            return text;
        }
    }
}
