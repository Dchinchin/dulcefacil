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
    public class TClientesTipoServiceImpl : ITClientesTipoService
    {
        private ITClientesTipo _tClientesTipoRepo;

       

        public TClientesTipoServiceImpl(DulceFacilContext context)
        {
            this._tClientesTipoRepo = new TClientesTipoRepoImpl(context);
        }

        public async Task AddAsync(TClientesTipo entity)
        {
            try
            {
                await _tClientesTipoRepo.AddAsync(entity);

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede añadir la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                await _tClientesTipoRepo.DeleteAsync(id);

            }
            catch (Exception ex)
            {

                throw new Exception("Error no se puede eliminar la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task<IEnumerable<TClientesTipo>> GetAllAsync()
        {
            try
            {
                return await _tClientesTipoRepo.GetAllAsync();

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede obtener las entidades de la base " + ex.Message + ". ");
            }
        }

        public async Task<TClientesTipo> GetByIdAsync(int id)
        {
            try
            {
                return await _tClientesTipoRepo.GetByIdAsync(id);

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede obtener la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task UpdateAsync(TClientesTipo entity)
        {
            try
            {
                await _tClientesTipoRepo.UpdateAsync(entity);

            }
            catch (Exception ex)
            {

                throw new Exception("Error  no se puede actualizar la entidad a la base " + ex.Message + ". ");
            }
        }
    }
}
