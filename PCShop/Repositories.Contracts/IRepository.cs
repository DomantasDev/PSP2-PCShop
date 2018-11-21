using Models.Contracts;
using System;
using System.Collections.Generic;

namespace Repositories.Contracts
{
    public interface IRepository<TModel> where TModel : class, IModel
    {
        Guid Save(TModel model);
        TModel Get(Guid id);
        IEnumerable<TModel> Get();
        void Update(TModel model);
        void delete(Guid id);
    }
}
