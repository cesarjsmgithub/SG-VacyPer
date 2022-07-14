using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SG_VacyPer.Models
{
    public class SolicitudVacaciones
    {
        [Key]
        [Display(Name = "ID")]
        public int IdSolicitudVacaciones { get; set; } = 0;


        [Required(ErrorMessage = "*Requerido")]
        [Display(Name = "ID. Empleado ")]
        [ForeignKey("Empleados")]
        public int IdEmpleado { get; set; } = 0;
        // Claves externas - FK
        public Empleados? Empleados { get; set; }


        [Required(ErrorMessage ="*Requerido")]
        [StringLength(10)]
        [Display(Name ="Doc. de identidad empleado")]
        public string DocIdentidad { get; set; } = string.Empty;

                
        [Required(ErrorMessage = "*Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de comienzo")]
        public DateTime FechaComienzo { get; set; } = DateTime.Now;


        [Required(ErrorMessage = "*Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de finalización")]
        public DateTime FechaFinalizacion { get; set; } = DateTime.Now;


        [Required(ErrorMessage = "*Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de solicitud")]
        public DateTime FechaSolicitud { get; set; } = DateTime.Now;

        
        [Required(ErrorMessage = "*Requerido")]
        [StringLength(15)]
        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Borrador";

        
        [StringLength(200)]
        [Display(Name = "Comentarios")]
        public string? Comentarios { get; set; } = string.Empty;

        
        [StringLength(200)]
        [Display(Name = "Motivo del rechazo")]
        public string? MotivoRechazo { get; set; } = string.Empty;

        [Display(Name = "ID Vacaciones")]
        [ForeignKey("Vacaciones")]
        public int? IdVacaciones { get; set; } = 0;
        // Claves externas - FK
        public Vacaciones? Vacaciones { get; set; }

    }

}

