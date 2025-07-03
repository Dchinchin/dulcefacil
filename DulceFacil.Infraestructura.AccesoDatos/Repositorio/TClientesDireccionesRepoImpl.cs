using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    
    public class TClientesDireccionesRepoImpl : RepositoryImpl<TClientesDirecciones>, ITClientesDirecciones
    {
        public TClientesDireccionesRepoImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
