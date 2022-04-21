
namespace OrdinaTaak.Auth
{
    public interface IPermissions
    {
        void AddRole(IRole role);
        void RevokeRole(IRole role);
        bool HasRole(IRole role);
    }
}
