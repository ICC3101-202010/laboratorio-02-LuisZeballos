using System;

namespace Laboratorio_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Canción C1 = new Canción("Vete", "Bad Bunny", "YHLQMDLG", "Reggaeton");
            Canción C2 = new Canción("Diosa", "Myke Towers", "Easy Money Baby", "Reggaeton");
            Canción C3 = new Canción("Lo malo de ser bueno", "El Cuarteto De Nos", "Porfiado", "Rock en español");

           
            string[] nombres = { C1.nombre, C2.nombre, C3.nombre };
            string[] albumes = { C1.album, C2.album, C3.album };
            string[] artistas = { C1.artista, C2.artista, C3.artista };
            string[] generos = { C1.genero, C2.genero, C3.genero };

            Espotifai Espoti = new Espotifai(nombres, artistas, albumes, generos);

            Console.WriteLine("Bienvenido a Espotifai");
            Console.Write("Presione 1 para ver las canciones, 2 para agregar una canción, 3 para ver canciones por criterio o  Enter para salir: ");
            string num = Console.ReadLine();
            if (num == "1")
            {
                Espoti.VerCanciones();
            }
            else if (num == "2") 
            {
                Console.WriteLine("Escriba el nombre de la canción: ");
                string nom = Console.ReadLine();
                Console.WriteLine("Escriba el nombre del artista: ");
                string art = Console.ReadLine();
                Console.WriteLine("Escriba el nombre del album: ");
                string alb = Console.ReadLine();

                Console.WriteLine(Espoti.AgregarCancion(nom,art,alb));
            }
            else if (num == "3")
            {
                Console.WriteLine("Escriba el criterio de busqueda: ");
                string c = Console.ReadLine();
                if (c == "Nombre" || c == "nombre" || c == "Artista" || c == "artista" || c == "Album" || c == "album" || c == "Álbum" || c == "álbum" || c == "Genero" || c == "genero" || c == "Género" || c == "género")
                {
                    Console.WriteLine("Escriba el " + c + ": ");
                    string valr = Console.ReadLine();
                    Espoti.CancionesPorCriterio(c, valr);
                }else
                {
                    Console.WriteLine("Criterio no válido");
                }
            }

            

                Console.ReadLine();
        }
    }
}
