﻿
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class TClientesDirecciones
{
    public int? ClienteId { get; set; }

    public string ClienteDireccion { get; set; }

    public string ClienteDireccionDetalles { get; set; }

    public virtual TClientes Cliente { get; set; }
}