using System.ComponentModel.DataAnnotations;

namespace Parcial.Shared.Entities
{
    public class Entrance
    {
        public int Id { get; set; }


        public string FechaDeUso { get; set; } = null!;



        public bool FueUsada { get; set; } = false!;



        public string Porteria { get; set; } = null!;
    }
}
