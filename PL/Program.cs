using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ML.Libro libro = new ML.Libro();

            int opcion, opcion1, opcion2, opcion3, opcion4, opcion5;

            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1. Agregar un libro");
            Console.WriteLine("2. Actualizar un libro");
            Console.WriteLine("3. Lista de libros");
            Console.WriteLine("4. Buscar un libro");
            Console.WriteLine("5. Eliminar un libro");
            opcion1 = int.Parse(Console.ReadLine());

            switch (opcion1)
            {
                case 1:
                    Console.WriteLine("Agrega los datos del libro: ");
                    Console.WriteLine("Ingrese nombre: ");
                    libro.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el id del autor: ");
                    libro.IdAutor = Console.ReadLine();
                    Console.WriteLine("Ingrese el número de paginas: ");
                    libro.NumeroPaginas = Console.ReadLine();
                    Console.WriteLine("Ingrese fecha de publicación: ");
                    libro.FechaPublicacion = Console.ReadLine();
                    Console.WriteLine("Ingrese el id de la editorial: ");
                    libro.IdEditorial = Console.ReadLine();
                    Console.WriteLine("Ingrese la edicion:");
                    libro.Edicion = Console.ReadLine();
                    Console.WriteLine("Ingrese el id del genero");
                    libro.IdGenero = Console.ReadLine();

                    Libros.Add(libro);
                    Console.ReadKey();
                    SaveChanges();

                default:
                    break;
            }
        }
    }
}
