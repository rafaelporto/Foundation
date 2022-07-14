namespace Foundation.Web.Data
{
    public interface IAuditableEntity
    {
        DateTimeOffset Created { get; }
        DateTimeOffset Modified { get; }
        string CreatedBy { get; }
        string? ModifiedBy { get; }
    }
}