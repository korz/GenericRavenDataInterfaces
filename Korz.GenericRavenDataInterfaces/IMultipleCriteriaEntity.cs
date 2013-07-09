using System.Collections.Generic;

namespace Korz.GenericRavenDataInterfaces
{
    public interface IMultipleCriteriaEntity : IAuditingMultipleCriteriaEntity
    {
        IList<string> Id { get; set; }
    }
}
