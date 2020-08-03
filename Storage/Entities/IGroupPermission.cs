namespace AltV.Gems.Permissions.Storage.Entities
{
    public interface IGroupPermission
    {
        IGroup Group {get;set;}

        string Permission { get; set; }
        
        string Value { get; set; }
    }
}
