namespace Foundation.Web.Data
{
    public abstract class AuditableEntity : IAuditableEntity
    {
        public DateTimeOffset Created { get; protected set; }
        public DateTimeOffset Modified { get; protected set; }
        public string CreatedBy { get; protected set; }
        public string? ModifiedBy { get; protected set; }
    }
}