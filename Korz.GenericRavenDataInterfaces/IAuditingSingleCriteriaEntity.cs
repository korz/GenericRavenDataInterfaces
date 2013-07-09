using System;

namespace Korz.GenericRavenDataInterfaces
{
    public interface IAuditingSingleCriteriaEntity
    {
        string CreatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
