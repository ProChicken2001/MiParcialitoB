namespace MiParcialitoB.Models
{
    public class Inscripciones
    {
        public int InscripcionesId { get; set; }

        public int EstudianteId { get; set; }
        public virtual Estudiantes Estudiante { get; set; }

        public int CursoId { get; set; }
        public virtual Cursos Curso { get; set; }
    }
}
