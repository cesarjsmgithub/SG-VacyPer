using System.ComponentModel.DataAnnotations;

namespace SG_VacyPer.Models
{
    public class Calendario
    {
        [Key]
        public int IdCalendario { get; set; }

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(40)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "*Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Comienzo")]
        public DateTime Comienzo { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "*Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Finaliza")]
        public DateTime Fin { get; set; } = DateTime.Now;

    }
}
