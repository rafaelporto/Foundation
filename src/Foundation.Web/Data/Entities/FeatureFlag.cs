namespace Foundation.Web.Data
{
    public class FeatureFlag : AuditableEntity, IAuditableEntity
    {
        public string Name { get; protected set; }
        public bool Enabled { get; protected set; }

        public FeatureFlag(string name, bool enabled)
        {
            Name = name;
            Enabled = enabled;
        }
    }
}