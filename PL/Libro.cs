using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Libro
    {
        public static void Add(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.KGuzmanProgramacionNCapasEntity context = new DL.KGuzmanProgramacionNCapasEntity())
                {
                    DL.Libros librosDL = new DL.Libros();

                    librosDL.Nombre = libro.Nombre();
                    librosDL.IdAutor = libro.IdAutor;
                    librosDL.NumeroPaginas = libro.NumeroPaginas;
                    librosDL.FechaPublicacion = libro.FechaPublicacion;
                    librosDL.IdEditorial = libro.IdEditorial;
                    librosDL.Edicion = libro.Edicion;
                    librosDL.Genero = libro.Genero;

                    context.Add(libroDL);
                    
                }
                result.Correct = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
