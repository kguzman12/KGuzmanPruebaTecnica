namespace ML
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Nombre { get; set; }
        public int NumeroPaginas { get; set; }
        public string FechaPublicacion { get; set; }
        public string Edicion { get; set; }

        public List<Libro> Libros { get; set; }


    //Foreig key
        public ML.Autor Autor { get; set; }
        public ML.Editorial Editorial { get; set; }
        public ML.Genero Genero { get; set; }

    }
}