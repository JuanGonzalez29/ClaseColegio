namespace Forms_App1.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumnos")]
    public partial class Alumno
    {
        [Key]
        public int Id_alumno { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public DateTime Nacimiento { get; set; }

        public int Id_Curso { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
