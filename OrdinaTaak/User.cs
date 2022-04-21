using OrdinaTaak.Auth;
using OrdinaTaak.Decrypt;
using OrdinaTaak.Readers;

namespace OrdinaTaak
{
    public class User : IPermissions
    {
        private readonly IOFileDecryptionStrategy ODecryptStrategy = new ReverseTextStrategy();

        private readonly List<IRole> _roles = new();

        public void AddRole(IRole role)
        {
            if (role == null) throw new ArgumentNullException(nameof(role));

            if (_roles.Contains(role)) return;

            _roles.Add(role);
        }

        public void RevokeRole(IRole role)
        {
            if (role == null) throw new ArgumentNullException(nameof(role));

            for (int i = 0; i < _roles.Count; i++)
            {
                if (string.Equals(_roles[i].Name, role.Name))
                {
                    _roles.RemoveAt(i);
                    break;
                }
            }

        }

        public bool HasRole(IRole role)
        {
            if (role == null) throw new ArgumentNullException(nameof(role));

            return _roles.Contains(role);
        }

        public bool CanPerform(IReadPermission action)
        {
            foreach (var role in _roles)
            {
                // Looking for role.GetType() match with action
                var allowed = RoleValidation.Instance.GetActions(role.GetType());
                if (allowed.Count > 0) return true;
            }

            return false;
        }

        public string ReadFile(
            string filePath,
            OFileType fileType,
            bool isEncrypted,
            IOFileDecryptionStrategy decryptionStrategy
            )
        {

            if (isEncrypted && decryptionStrategy == null) throw new ArgumentNullException(nameof(decryptionStrategy));

            var content = ReadFile(filePath, fileType);

            if (isEncrypted)
            {
                content = decryptionStrategy.Decrypt(content);
            }

            return content;
        }

        public string ReadFile(
            string filePath,
            OFileType fileType
            )
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            string content = string.Empty;
            OFileReader reader;

            switch (fileType)
            {
                case OFileType.Text:
                    reader = new OReadTextFile();
                    if (!CanPerform((OReadTextFile)reader)) throw new UnauthorizedAccessException();
                    content = reader.ReadFile(filePath);
                    break;

                case OFileType.XML:
                    reader = new OReadXMLFile();
                    if (!CanPerform((OReadXMLFile)reader)) throw new UnauthorizedAccessException();
                    content = reader.ReadFile(filePath);
                    break;

                case OFileType.JSON:
                    reader = new OReadJsonFile();
                    if (!CanPerform((OReadJsonFile)reader)) throw new UnauthorizedAccessException();
                    content = reader.ReadFile(filePath);
                    break;

                default:
                    throw new NotImplementedException();
            }

            return content;
        }
    }
}

