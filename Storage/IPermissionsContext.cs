using AltV.Gems.Permissions.Storage.Entities;

namespace AltV.Gems.Permissions.Storage
{
    public interface IPermissionsContext
    {
        IQueryable<IGroup> Groups { get; set; }
        IQueryable<IGroupPermission> GroupPermissions { get; set; }
        IQueryable<ILog> Logs { get; set; }
        IQueryable<IUser> Users { get; set; }
        IQueryable<IUserPermission> UserPermissions { get; set; }
    }
}
