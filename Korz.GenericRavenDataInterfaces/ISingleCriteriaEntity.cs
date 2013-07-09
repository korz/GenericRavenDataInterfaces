namespace Korz.GenericRavenDataInterfaces
{
    public interface ISingleCriteriaEntity : IAuditingSingleCriteriaEntity
    {
        string Id { get; set; }
    }
}
