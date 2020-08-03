namespace AltV.Gems.Permissions
{
    public class JsonFile
    {
        public string Path { get; set; }
    }

    public class Database
    {
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DbName { get; set; }
        public string TablePrefix { get; set; }
    }

    public class Storage
    {
        public string Type { get; set; }
        public JsonFile JsonFile { get; set; }
        public Database Database { get; set; }
    }

    public class Configuration
    {
        public bool Enabled { get; set; }
        public Storage Storage { get; set; }
    }
}
