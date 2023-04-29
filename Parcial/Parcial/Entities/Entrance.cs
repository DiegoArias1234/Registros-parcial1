using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parcial.Shared.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [Display(Name = "Entrada")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string FechaDeUso { get; set; } = null!;



        public bool FueUsada { get; set; } = false!;



        public string Porteria { get; set; } = null!;
    }
}
