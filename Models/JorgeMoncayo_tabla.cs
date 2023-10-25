using System.ComponentModel.DataAnnotations;

namespace JorgeMoncayo_Examen1P.Models
{
    public class JorgeMoncayo_tabla
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Su juego tiene muchos caracteres")]
        public string? NombreJuego { get; set; }
        public bool Ps4 {  get; set; }

        public bool Ps5 { get; set; }
        [VerificarRango]
        public decimal Precio { get; set; }

        [Display(Name = "Precio en la fecha actual")] //Cambia nombre del atributo
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha no válido.")]
        public DateTime? PrecioDate { get; set;}
    }
    public class VerificarRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if (valor < 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }






}
