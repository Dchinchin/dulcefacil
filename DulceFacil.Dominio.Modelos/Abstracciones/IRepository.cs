using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelos.Abstracciones
{
    public interface IRepository <T> where T : class
    {
        Task AddAsync(T entity); 

        Task UpdateAsync(T entity); 
       
        Task DeleteAsync(int id); 

        Task<IEnumerable<T>> GetAllAsync(); 

        Task<T> GetByIdAsync(int id); 
    }
}
