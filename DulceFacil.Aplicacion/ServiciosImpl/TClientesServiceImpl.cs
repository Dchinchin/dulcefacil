using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServiciosImpl
{
    public class TClientesServiceImpl : ITClientesService
    {

        private ITClientes tClientesRepo;

        public TClientesServiceImpl(DulceFacilContext context)
        {
            this.tClientesRepo = new TClientesRepoImpl(context);
        }

        public async Task AddAsync(TClientes entity)
        {
            try
            {
                await tClientesRepo.AddAsync(entity);

            }
            catch (Exception ex)
            {

                throw new Exception("Error no se puede añadir la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                await tClientesRepo.DeleteAsync(id);

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede eliminar la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task<IEnumerable<TClientes>> GetAllAsync()
        {
            try
            {
                return await tClientesRepo.GetAllAsync();

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede obtener las entidades de la base " + ex.Message + ". ");
            }
        }

        public async Task<TClientes> GetByIdAsync(int id)
        {
            try
            {
                return await tClientesRepo.GetByIdAsync(id);

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede obtener la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task UpdateAsync(TClientes entity)
        {
            try
            {
                await tClientesRepo.UpdateAsync(entity);

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede actualizar la entidad a la base " + ex.Message + ". ");
            }
        }
    }
}
