Generic Raven Data Interfaces is a collection of interfaces of compose POCO objects to be used with Raven DB.

IEntity - adds the Id property that Raven looks for and specifies what other fields (interfaces) to include.

ISingleCriteriaEntity - adds the Id property to criteria objects

IMultipleCriteriaEntity - adds the list of Id properties to criteria objects

IAuditingEntity - adds CreatedBy, CreatedDate, ModifiedBy, and ModifiedDate to your object

IAuditingSingleCriteriaEntity - creates nullable fields of the IAuditingEntity used for creating data criteria objects

IAuditingMultipleCriteriaEntity - creates collections of fields of the IAuditingSingleCriteriaEntity so we can search for multiple things at once

IDataFactory - specifies what methods have to exist in your data factory

Language: C#