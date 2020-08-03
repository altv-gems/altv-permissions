namespace AltV.Gems.Permissions.Storage.Entities
{
    public interface IUserPermission
    {
        IUser Player { get; set; }

        string Permission { get; set; }

        string Value { get; set; }
    }
}
