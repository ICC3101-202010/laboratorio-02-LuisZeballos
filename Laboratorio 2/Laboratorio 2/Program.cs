using System;
using System.Collections.Generic;

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

            string[] nombresr = { C1.nombre, C2.nombre };
            string[] albumesr = { C1.album, C2.album};
            string[] artistasr = { C1.artista, C2.artista};
            string[] generosr = { C1.genero, C2.genero};

            Playlist Play = new Playlist("Luis", nombresr, artistasr, albumesr, generosr);

            Espotifai Espoti = new Espotifai(nombres, artistas, albumes, generos);



            Console.WriteLine("Bienvenido a Espotifai");
            Console.Write("Presione 1 para ver las canciones");
            Console.Write(" Presione 2 para agregar una canción");
            Console.Write(" Presione 3 para ver canciones por criterio");
            Console.Write(" Presione 4 para agregar una playlist");
            Console.Write(" Presione 5 para ver las playlists");
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
            else if (num == "4") 
            {
                Console.WriteLine("Escriba el nombre de la nueva playlist: ");
                string nombreplay = Console.ReadLine();
                Console.WriteLine("Escriba el criterio de la Playlist: ");
                string c = Console.ReadLine();
                if (c == "Nombre" || c == "nombre" || c == "Artista" || c == "artista" || c == "Album" || c == "album" || c == "Álbum" || c == "álbum" || c == "Genero" || c == "genero" || c == "Género" || c == "género")
                {
                    Console.WriteLine("Escriba el " + c + ": ");
                    string valr = Console.ReadLine();
                    bool boo = Espoti.GenerarPlaylist(c, valr, nombreplay);
                    Console.WriteLine(boo);

                }
                else
                {
                    Console.WriteLine("Criterio no válido");
                }
                


            }
            else if (num == "5")
            {
                Console.WriteLine(Espoti.VerMisPlaylists());
            }



                Console.ReadLine();
        }
    }
}
