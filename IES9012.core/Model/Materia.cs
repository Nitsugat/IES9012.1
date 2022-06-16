using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IES9012.core.Model
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string? NombreMateria { get; set; }

        public int Creditos { get; set; }


        public ICollection<Inscripcion>? Inscripciones { get; set; }



    }
}
