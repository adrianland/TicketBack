using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsBack.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaActualizacion { get; set; }
        public bool? Estatus { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
    }
}


