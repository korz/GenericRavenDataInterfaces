namespace Korz.GenericRavenDataInterfaces
{
    public interface IEntity : IAuditingEntity
    {
        string Id { get; set; }
    }
}
