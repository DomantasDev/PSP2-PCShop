using Microsoft.EntityFrameworkCore;
using Models.Contracts;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repositories.Implementation
{
    public abstract class GenericRepository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly PcContext _ctx;

        public GenericRepository(PcContext ctx)
        {
            _ctx = ctx;
        }

        public virtual void Delete(Guid id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _ctx.Set<TModel>().Remove(entity);
                _ctx.SaveChanges();
            }
        }

        public virtual TModel Get(Guid id)
        {
            return _ctx.Set<TModel>().Find(id);
        }

        public virtual IEnumerable<TModel> Get()
        {
            return _ctx.Set<TModel>().ToList();
        }

        public virtual TModel Save(TModel model)
        {
            var entity = _ctx.Set<TModel>().Add(model).Entity;
            _ctx.SaveChanges();
            return entity;
        }

        public virtual void Update(TModel model)
        {
            _ctx.Entry(model).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
