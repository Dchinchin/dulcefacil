
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class TClientes
{
    public int ClienteId { get; set; }
    public int? ClienteTipoId { get; set; }

    public string ClienteNombre { get; set; }

    public string ClienteApellido { get; set; }

   
}