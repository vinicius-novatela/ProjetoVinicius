using ProjetoVinicius.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVinicius.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable where TEntity : class
    {
       

        protected ProjetoViniciusContexto Db;
        protected DbSet<TEntity> DbSet;

        public RepositoryBase()
        {
            Db = new ProjetoViniciusContexto();
            DbSet = Db.Set<TEntity>();

        }


        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public virtual void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public virtual TEntity Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
            return obj;
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
