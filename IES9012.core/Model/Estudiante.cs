using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IES9012.core.Model
{
    public class Estudiante
    {

        public int EstudianteId { get; set; }
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "0:yyyy/MM/dd", ApplyFormatInEditMode = true)]
        public DateTime FechaInscripcion { get; set; } = DateTime.Now;

        public ICollection<Inscripcion>? Inscripciones { get; set; }



    }
}
