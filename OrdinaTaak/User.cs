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

            _roles.Remove(role);
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
                if (RoleValidation.Instance.GetActions(role.GetType()).Contains(action))
                    return true;
            }
            return false;
        }

        public string ReadFile(string filePath, OFileType fileType, bool isEncrypted = false)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));

            string content = string.Empty;
            if (fileType == OFileType.Text)
            {
                var reader = new OReadTextFile();
                content = reader.ReadFile(filePath);
            }
            else if (fileType == OFileType.XML)
            {
                var reader = new OReadXMLFile();
                if (!CanPerform(reader)) throw new UnauthorizedAccessException();
                content = reader.ReadFile(filePath);
            }

            if (isEncrypted)
            {
                ODecryptStrategy.Decrypt(content);
            }

            return string.Empty;
        }
    }
}
