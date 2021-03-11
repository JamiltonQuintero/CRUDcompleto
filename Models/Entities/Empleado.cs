using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUDcompleto.Models.Entities
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId{ get; set; }

        [Column("NombreEmpleado", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        public int Documento { get; set; } 
        public int CargoId { get; set; }
        public string Telefono { get; set; }



    }
}