namespace AltV.Gems.Permissions.Api
{
    public class PermissionManager
        : IPermissionManager
    {
        public PermissionManager()
        {

        }

        string Name { get; }

        ICollection<string> Groups { get; }

        bool isPlayerInGroup(IPlayer player, string groupName);
        bool isPlayerInGroup(string player, string groupName);

        bool addPlayerToGroup(IPlayer player, string groupName);
        bool addPlayerToGroup(string player, string groupName);

        bool removePlayerFromGroup(IPlayer player, string groupName);
        bool removePlayerFromGroup(string player, string groupName);

        bool addPlayerPermission(IPlayer player, string permission);
        bool addPlayerPermission(string player, string permission);

        bool removePlayerPermission(IPlayer player, string permission);
        bool removePlayerPermission(string player, string permission);

        bool addGroupPermission(string groupName, string permission);

        bool removeGroupPermission(string groupName, string permission);

        bool hasGroupPermission(string groupName, string permission);

        ICollection<string> getPlayerGroups(IPlayer player);
        ICollection<string> getPlayerGroups(string player);

        string getPlayerPrimaryGroup(IPlayer player);
        string getPlayerPrimaryGroup(string player);

        bool hasPlayerPermission(IPlayer player, string permission);
        bool hasPlayerPermission(string player, string permission);

        bool addPlayerPermissionTransient(IPlayer player, string permission);

        bool removePlayerPermissionTransient(IPlayer player, string permission);

    }
}
