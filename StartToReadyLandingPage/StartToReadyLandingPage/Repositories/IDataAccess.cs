using System.Collections.Generic;

namespace StartToReadyLandingPage.Repositories {
    public interface IDataAccess<TEntity, T> where TEntity : class {
        IEnumerable<TEntity> GetItens();
        TEntity GetItem(T id);
        int Add(TEntity b);
        int Update(T id, TEntity b);
        int Delete(T id);
    }
}