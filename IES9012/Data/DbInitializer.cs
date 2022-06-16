namespace IES9012.UI.Data;
using IES9012.core.Enum;
using IES9012.core.Model;


    public class DbInitializer
    {
    public static void Initialize(IES9012Context context)
    {
        // Look for any students.
        if (context.Estudiantes.Any())
        {
            return; // DB has been seeded
        }
        var estudiantes = new Estudiante[]
        {

new Estudiante{Nombre="Carson",Apellido="Alexander",FechaInscripcion=DateTime.Parse("2019-09-01")},

new Estudiante{Nombre="Meredith",Apellido="Alonso",FechaInscripcion=DateTime.Parse("2017-09-01")},

new Estudiante{Nombre="Arturo",Apellido="Anand",FechaInscripcion=DateTime.Parse("2018-09-01")},

new Estudiante{Nombre="Gytis",Apellido="Barzdukas",FechaInscripcion=DateTime.Parse("2017-09-01")},

new Estudiante{Nombre="Yan",Apellido="Li",FechaInscripcion=DateTime.Parse("2017-09-01")},

new Estudiante{Nombre="Peggy",Apellido="Justice",FechaInscripcion=DateTime.Parse("2016-09-01")},

new Estudiante{Nombre="Laura",Apellido="Norman",FechaInscripcion=DateTime.Parse("2018-09-01")},

new Estudiante{Nombre="Nino",Apellido="Olivetto",FechaInscripcion=DateTime.Parse("2019-09-01")}

        };
        context.Estudiantes.AddRange(estudiantes);
        context.SaveChanges();
        var materias = new Materia[]
        {
new Materia{MateriaId=1050,NombreMateria="Chemistry",Creditos=3},

new Materia{MateriaId=4022,NombreMateria="Microeconomics",Creditos=3},

new Materia{MateriaId=4041,NombreMateria="Macroeconomics",Creditos=3},

new Materia{MateriaId=1045,NombreMateria="Calculus",Creditos=4},

new Materia{MateriaId=3141,NombreMateria="Trigonometry",Creditos=4},

new Materia{MateriaId=2021,NombreMateria="Composition",Creditos=3},
new Materia{MateriaId=2042,NombreMateria="Literature",Creditos=4}
        };
        context.Materias.AddRange(materias);
        context.SaveChanges();
        var inscripciones = new Inscripcion[]
        {

new Inscripcion{EstudianteId=1,MateriaId=1,Calificacion=Calificaciones.Mal},

new Inscripcion{EstudianteId=1,MateriaId=2,Calificacion=Calificaciones.Bien},

new Inscripcion{EstudianteId=1,MateriaId=3,Calificacion=Calificaciones.Bien},

new Inscripcion{EstudianteId=2,MateriaId=4,Calificacion=Calificaciones.Mal},

new Inscripcion{EstudianteId=2,MateriaId=5,Calificacion=Calificaciones.Mal},

new Inscripcion{EstudianteId=2,MateriaId=2021,Calificacion=Calificaciones.Bien},

new Inscripcion{EstudianteId=3,MateriaId=6},
new Inscripcion{EstudianteId=4,MateriaId=7},

new Inscripcion{EstudianteId=4,MateriaId=8,Calificacion=Calificaciones.Bien},

new Inscripcion{EstudianteId=5,MateriaId=9,Calificacion=Calificaciones.Mal},

new Inscripcion{EstudianteId=6,MateriaId=10},

new Inscripcion{EstudianteId=7,MateriaId=11,Calificacion=Calificaciones.Sobresaliente},

        };
        context.Inscripciones.AddRange(inscripciones);
        context.SaveChanges();
    }
}

