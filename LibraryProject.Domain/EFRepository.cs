using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Data
{
    public class EFRepository<TEntity>:IEFREpository<TEntity> where TEntity : Entity
    {
        #region Fileds

        private IApplicationService _context;

        public EFRepository(IApplicationService context)
        {
            _context = context;
        }

        private DbSet<TEntity> _entities;

        public DbSet<TEntity> Entites
        {
            get
            {
                if(_entities == null )
                    _entities =  _context.Set<TEntity>();
                return _entities;
            }
        }



        #endregion
        public TEntity GetById(params object[] ids)=> _context.Set<TEntity>().Find(ids);

        public async Task<TEntity> GetByIdAsync(params object[] ids) => await _context.Set<TEntity>().FindAsync(ids);

        public TEntity GetByIdAsNoTracking(params object[] ids)
        {
            var entity = _context.Set<TEntity>().Find(ids);
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }

            return entity;
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<TEntity> Table => Entites;
        public IQueryable<TEntity> TableAsNoTracking => Entites.AsNoTracking();
    }
}
