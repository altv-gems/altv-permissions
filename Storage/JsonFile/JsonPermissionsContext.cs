namespace AltV.Gems.Permissions.Storage.JsonFile
{
    public class JsonPermissionsContext : IPermissionsContext
    {
        public JsonPermissionsContext(Configuration configuration)
        {

        }

        IQueryable<IGroup> Groups { get; set; }
        IQueryable<IGroupPermission> GroupPermissions { get; set; }
        IQueryable<ILog> Logs { get; set; }
        IQueryable<IUser> Users { get; set; }
        IQueryable<IUserPermission> UserPermissions { get; set; }

        private void Initialize()
        {

        }
    }
}
