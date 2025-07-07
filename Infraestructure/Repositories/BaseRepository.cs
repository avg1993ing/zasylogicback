using Core.Entities;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.ContextEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly PruTecContext _contex;
        protected readonly DbSet<T> _entities;

        public BaseRepository(PruTecContext context)
        {
            _contex = context;
            _entities = context.Set<T>();
        }
        public async Task<T> Add(T entity)
        {
            try
            {
                var resul = await _entities.AddAsync(entity);   
                await _contex.SaveChangesAsync();
                return resul.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteById(T id)
        {
            try
            {
                _entities.Remove(id);
                await _contex.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                return await _entities.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _entities.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Update(T entity)
        {
            try
            {
                var entityUpdate = _entities.Update(entity).Entity;
                _contex.SaveChanges();
                return entityUpdate;  
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

