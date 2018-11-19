using Models.Contracts;
using System;

namespace Repositories.Contracts
{
    public interface IRepository<TModel> where TModel : class, IModel
    {
        Guid Save(TModel model);
        TModel Get(Guid id);
        void Update(TModel model);
        void delete(Guid id);
    }
}
