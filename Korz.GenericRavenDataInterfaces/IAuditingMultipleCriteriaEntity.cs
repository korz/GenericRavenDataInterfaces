using System;
using System.Collections.Generic;

namespace Korz.GenericRavenDataInterfaces
{
    public interface IAuditingMultipleCriteriaEntity
    {
        IList<int> CreatedBy { get; set; }
        IList<DateTime> CreatedDate { get; set; }
        IList<int> ModifiedBy { get; set; }
        IList<DateTime> ModifiedDate { get; set; }
    }
}
