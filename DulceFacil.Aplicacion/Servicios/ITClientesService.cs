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
    public interface ITClientesService
    {
        [OperationContract]
        Task AddAsync(TClientes entity); 
                                            
        [OperationContract]
        Task UpdateAsync(TClientes entity); 
        [OperationContract]
        Task DeleteAsync(int id); 

        [OperationContract]
        Task<IEnumerable<TClientes>> GetAllAsync(); 

        [OperationContract]
        Task<TClientes> GetByIdAsync(int id); 
                                                 
    }
}
