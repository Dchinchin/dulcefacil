using DulceFacil.Dominio.Modelos.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    
    public class RepositoryImpl<T> : IRepository<T> where T : class
    {
        private readonly DulceFacilContext _DulceFacilContext; 
        private readonly DbSet<T> _dbSet; 

    
        public RepositoryImpl(DulceFacilContext context)
        {
            _DulceFacilContext = context;
            _dbSet = context.Set<T>();
        }

        
        public async Task AddAsync(T entity)
        {
            try 
            { 
                await _dbSet.AddAsync(entity);
                await _DulceFacilContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase genérica: No se pudo insertar Datos" + ex.Message);
            }
           
        }

      
        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                _dbSet.Remove(entity);
                await _DulceFacilContext.SaveChangesAsync();

            }

            catch (Exception ex) 
            {
                throw new Exception("Error - Clase genérica: No se pudo eliminar Datos" + ex.Message);

            }
        }

      
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo traer los Datos" + ex.Message);
            }
        }

       
        public async Task<T> GetByIdAsync(int id)
        {
            try 
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex) 
            {
                throw new Exception("Error - Clase Genérica; No se pudo encontrar el dato" + ex.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _DulceFacilContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo actualizar el dato" + ex.Message);
            }
        }
    }
}
