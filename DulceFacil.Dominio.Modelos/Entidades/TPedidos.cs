
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class TPedidos
{
    public int PedidoId { get; set; }

    public int? CentroDistribucionId { get; set; }

    public int? PuntoVentaId { get; set; }

    public int? RutaId { get; set; }

   

    
}