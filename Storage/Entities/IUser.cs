namespace AltV.Gems.Permissions.Storage.Entities
{
    public interface IUser
    {
        string Identifier { get; set; }

        IGroup PrimaryGroup { get; set; }
    }
}
