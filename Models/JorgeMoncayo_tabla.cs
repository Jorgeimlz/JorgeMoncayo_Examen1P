using System.ComponentModel.DataAnnotations;

namespace JorgeMoncayo_Examen1P.Models
{
    public class JorgeMoncayo_tabla
    {
        public int Id { get; set; }
        [Required] //Verifica que se escriba obligatoriamente el campo

        [MaxLength(20, ErrorMessage = "Su juego tiene muchos caracteres")] //Verifica que el juego no tenga mas de 20 caracteres
        public string? NombreJuego { get; set; }
        public bool Ps4 {  get; set; }

        public bool Ps5 { get; set; }
        [VerificarRango] //Verifica que el rango de precio no sea menor de 15 dolares
        public decimal Precio { get; set; }

        [Display(Name = "Fecha actual de la compra")] //Cambia nombre del atributo
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha no válido.")] // Verifica que el formato sea dia,mes,anio
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
