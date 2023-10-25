using System.ComponentModel.DataAnnotations;

namespace JorgeMoncayo_Examen1P.Models
{
    public class JorgeMoncayo_tabla
    {
        public int Id { get; set; }
        [Required]
        public string? NombreJuego { get; set; }
        public bool Ps4 {  get; set; }

        public bool Ps5 { get; set; }
        public decimal Precio { get; set; }

        public DateTime? PrecioDate { get; set;}
    }



  
}
