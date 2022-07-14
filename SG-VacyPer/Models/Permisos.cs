using System.ComponentModel.DataAnnotations;

namespace SG_VacyPer.Models
{
    public class Permisos
    {
        [Key]
        public int IdPermisos { get; set; }

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(40)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "*Requerido")]
        [Display(Name = "Cantidad de días oficiales")]
        public int DiasOficiales { get; set; } = 0;

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(20)]
        [Display(Name = "Tipo de permiso")]
        public string Tipo { get; set; } = string.Empty;

    }
}
