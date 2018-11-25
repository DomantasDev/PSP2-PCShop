using Models.Contracts;
using System;
using System.Collections.Generic;

namespace Repositories.Contracts
{
    public interface IRepository<TModel> where TModel : class, IEntity
    {
        TModel Save(TModel model);
        TModel Get(Guid id);
        IEnumerable<TModel> Get();
        void Update(TModel model);
        void Delete(Guid id);
    }
}
