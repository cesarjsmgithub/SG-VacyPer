using System.ComponentModel.DataAnnotations;

namespace SG_VacyPer.Models
{
    public class Vacaciones
    {
        [Key]
        public int IdVacaciones { get; set; }

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(40)]
        [Display(Name ="Descripción")]
        public string Descripcion { get; set; } = String.Empty;

        [Required(ErrorMessage = "*Requerido")]
        [Display(Name = "Cantidad de días oficiales")] 
        public int DiasOficiales { get; set; } = 22;

        [Display(Name = "Cantidad de días adicionales")]
        public int DiasAdicionales { get; set; } = 0;

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(15)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } = String.Empty;

        // para las relaciones con otra tablas - NOTA: le coloco una "s" de más al final 
        public ICollection<Empleados>? Empleadoss { get; set; }
        public ICollection<SolicitudVacaciones>? SolicitudVacacioness { get; set; }
    }
}
