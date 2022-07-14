using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SG_VacyPer.Models
{
    public class Empleados
    {
        [Key]
        [Display(Name = "ID")]
        public int IdEmpleado { get; set; } = 0;

        [Required(ErrorMessage ="*Requerido")]
        [StringLength(10)]
        [Display(Name ="Doc. de identidad")]
        public string DocIdentidad { get; set; } = string.Empty;

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(60)]
        [Display(Name = "Nombre completo")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "*Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; } = DateTime.MinValue;

        [Required(ErrorMessage = "*Requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de salida")]
        public DateTime? FechaSalida { get; set; } = null;

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(20)]
        [Display(Name = "Rol")]
        public string Rol { get; set; } = "Empleado";

        [Display(Name = "Responsable")]
        public int ResponsableId { get; set; } = 0;

        [Required(ErrorMessage = "*Requerido")]
        [StringLength(15)]
        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Activo";

        [StringLength(200)]
        [Display(Name = "Dirección")]
        public string? Direccion { get; set; } = "";

        [StringLength(60)]
        [Display(Name = "Teléfonos de contacto")]
        public string? Telefonos { get; set; } = "";


        [Required(ErrorMessage = "*Requerido")]
        [Display(Name = "ID Vacaciones")]
        [ForeignKey("Vacaciones")]
        public int IdVacaciones { get; set; } = 0;
        // Claves externas - FK
        public Vacaciones? Vacaciones { get; set; }

        [Display(Name = "V. Disfrutadas")]
        public int VacacionesDisfrutadas { get; set; } = 0;

        [Display(Name = "Asuntos propios")]
        public int AsuntosPropios { get; set; } = 0;

        [Display(Name = "Formación")]
        public int Formacion { get; set; } = 0;

        [Display(Name = "Incapacidad temporal")]
        public int IncapacidadTemporal { get; set; } = 0;

        [Display(Name = "Nacimiento hijos")]
        public int NacimientoHijos { get; set; } = 0;

        [Display(Name = "Matrimonio")]
        public int Matrimonio { get; set; } = 0;

        [Display(Name = "Otros motivos")]
        public int OtrosMotivos { get; set; } = 0;

        // para las relaciones con otra tablas - NOTA: le coloco una "s" de más al final 
        public ICollection<SolicitudVacaciones>? SolicitudVacacioness { get; set; }
        public ICollection<SolicitudPermisos>? SolicitudPermisoss { get; set; }

    }
}
