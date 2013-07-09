using System.Collections.Generic;

namespace Korz.GenericRavenDataInterfaces
{
    public interface IDataFactory<TEntity, in TEntityCriteria>
        where TEntity : IEntity
        where TEntityCriteria : ISingleCriteriaEntity
    {
        TEntity New();
        TEntity Create(TEntity entity);
        IEnumerable<TEntity> Load();
        TEntity Load(string id);
        IEnumerable<TEntity> Load(TEntityCriteria criteria);
        TEntity Update(string id, TEntity entity);
        void Delete(string id);
    }
}
