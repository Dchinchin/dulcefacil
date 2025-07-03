using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.Servicios
{
    [ServiceContract]
    public interface ITClientesTipoService
    {
        [OperationContract]
        Task AddAsync(TClientesTipo entity); 
        [OperationContract]
        Task UpdateAsync(TClientesTipo entity); 

        [OperationContract]
        Task DeleteAsync(int id); 

        [OperationContract]
        Task<IEnumerable<TClientesTipo>> GetAllAsync(); 

        [OperationContract]
        Task<TClientesTipo> GetByIdAsync(int id); 
                                           
    }
}
