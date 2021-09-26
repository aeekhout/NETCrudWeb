using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresoGastos.Models
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name = "Nombre Categoria")]
        public string nombrecategoria { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name = "Tipo")]
        public string tipo { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public bool estado { get; set; }
    }
}
