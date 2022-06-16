using System.ComponentModel.DataAnnotations;
using IES9012.core.Enum;


namespace IES9012.core.Model
{
    public class Inscripcion
    {

        public int InscripcionId { get; set; }

        public int MateriaId { get; set; }
        public int EstudianteId { get; set; }

        [DisplayFormat(NullDisplayText ="Sin calificacion")]
        public Calificaciones? Calificacion { get; set; }

        public Materia? Materia { get; set; }
        public Estudiante? Estudiante { get; set; }


    }
}