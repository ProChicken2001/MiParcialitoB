namespace MiParcialitoB.Models
{
    public class Estudiantes
    {
        public int EstudianteId { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
