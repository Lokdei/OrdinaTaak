using OrdinaTaak.Auth;

namespace OrdinaTaak.Readers
{
    public class ReadTextRole : IRole
    {
        public string Name { get { return "ReadText"; } }
    }

    internal class OReadTextFile : OFileReader, IReadPermission
    {
        public string Name { get { return "ReadText"; } }

        public override string ReadFile(string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath)) throw new FileNotFoundException();

            string text = File.ReadAllText(filePath);
            return text;
        }
    }
}
