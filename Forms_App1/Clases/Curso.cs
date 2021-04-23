namespace Forms_App1.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            Alumnos = new HashSet<Alumno>();
        }

        [Key]
        public int Id_Curso { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        public int Id_Profesor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno> Alumnos { get; set; }

        public virtual Profesore Profesore { get; set; }
    }
}
