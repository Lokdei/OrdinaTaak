using OrdinaTaak.Helpers;

namespace OrdinaTaak.Decrypt
{
    public class ReverseTextStrategy : IOFileDecryptionStrategy
    {
        public string Decrypt(string content)
        {
            if (content == null) throw new ArgumentNullException(nameof(content));

            return StringUtility.ReverseInPlace(content);
        }
    }
}
