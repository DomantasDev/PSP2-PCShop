using Microsoft.EntityFrameworkCore;
using Models.Contracts;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementation
{
    public class GenericRepository<TModel> : IRepository<TModel> where TModel : class, IModel
    {
        private readonly PcContext _ctx;

        public GenericRepository(PcContext ctx)
        {
            _ctx = ctx;
        }

        public void delete(Guid id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _ctx.Set<TModel>().Remove(entity);
                _ctx.SaveChanges();
            }
        }

        public TModel Get(Guid id)
        {
            return _ctx.Set<TModel>().Find(id);
        }

        public Guid Save(TModel model)
        {
            var id =_ctx.Set<TModel>().Add(model).Entity.Id;
            _ctx.SaveChanges();
            return id;
        }

        public void Update(TModel model)
        {
            _ctx.Entry(model).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
