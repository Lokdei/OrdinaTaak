
namespace OrdinaTaak.Auth
{
    public interface IReadPermission: IRole
    {
        string Name { get; }
        string ReadFile(string fileName);
    }
}
