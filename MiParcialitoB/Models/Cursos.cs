namespace MiParcialitoB.Models
{
    public class Cursos
    {
        public int CursosId { get; set; }

        public string NombreCurso { get; set; }

        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
