using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Models
{
    internal class Empresa
    {
     
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public DateTime FechayHoraCreacion { get; set; }
        public DateTime FechayHoraModificacion { get; set; }
    }
}
