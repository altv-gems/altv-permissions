namespace AltV.Gems.Permissions.Storage.Entities
{
    public interface ILog
    {
        DateTime Date { get; set; }

        IUser Actor { get; set; }

        string Action { get; set; }

        IUser Acted { get; set; }
    }
}
