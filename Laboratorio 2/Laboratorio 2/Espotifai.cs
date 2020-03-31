using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Espotifai
    {
        public string[] nombres = { };
        public string[] artistas = { };
        public string[] albumes = { };
        public string[] generos = { };
        List<Playlist> playlists = new List<Playlist>();


        public Espotifai(string[] aNombres, string[] aArtistas, string[] aAlbums, string[] aGeneros)
        {
            nombres = aNombres;
            artistas = aArtistas;
            albumes = aAlbums;
            generos = aGeneros;
        }


        public bool AgregarCancion(string bNombre, string bArtista, string bAlbumes)
        {
            int i = 0;
            while (i <= 2)
            {
                if (nombres[i] == bNombre && artistas[i] == bArtista && albumes[i] == bAlbumes)
                {
                    return false;
                }
                i++;
            }
            return true;
        }   
        public void VerCanciones()
        {
            int i = 0;
            while (i <= 2)
            {
                Console.WriteLine(i+1 + ". " + nombres[i] + " de " + artistas[i] + " del album " + albumes[i] + " del género " + generos[i]);
                i++;
            }
        }
        public void CancionesPorCriterio(String criterio, String valor)
        {
            if (criterio == "Nombre" || criterio == "nombre")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (nombres[i] == valor)
                    {
                        Console.WriteLine(nombres[i] + " de " + artistas[i] + " del album " + albumes[i] + " del género " + generos[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else if (criterio == "Artista" || criterio == "artista")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (artistas[i] == valor)
                    {
                        Console.WriteLine(nombres[i] + " de " + artistas[i] + " del album " + albumes[i] + " del género " + generos[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else if (criterio == "Album" || criterio == "album" || criterio == "Álbum" || criterio == "álbum")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (albumes[i] == valor)
                    {
                        Console.WriteLine(nombres[i] + " de " + artistas[i] + " del album " + albumes[i] + " del género " + generos[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else if (criterio == "Genero" || criterio == "genero" || criterio == "Género" || criterio == "género")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (generos[i] == valor)
                    {
                        Console.WriteLine(nombres[i] + " de " + artistas[i] + " del album " + albumes[i] + " del género " + generos[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }else 
            {
                Console.WriteLine("No hubo resultados");
            }
        }
        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)
        {   List<string> nombress = new List<string>();
            List<string> artistass = new List<string>();
            List<string> albumess = new List<string>();
            List<string> geneross = new List<string>();
            int largo = playlists.Count;
            int e = 0;
            while (e < largo)
            {
                if (playlists[e].name == nombrePlaylist)
                {
                    Console.WriteLine("Ya existe una Playlist con ese nombre");
                    return false;
                }

                e++;
            }
            if (criterio == "Nombre" || criterio == "nombre")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (nombres[i] == valorCriterio)
                    {
                        nombress.Add(valorCriterio);
                        artistass.Add(valorCriterio);
                        albumess.Add(valorCriterio);
                        geneross.Add(valorCriterio);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                string[] arraynombres = nombress.ToArray();
                string[] arrayartistas = artistass.ToArray();
                string[] arrayalbumes = albumess.ToArray();
                string[] arraygeneros = geneross.ToArray();
                Playlist playlist = new Playlist(nombrePlaylist, arraynombres, arrayartistas, arrayalbumes, arraygeneros);
                playlists.Add(playlist);
                int u = nombress.Count;
                if (u>0)
                {
                    Console.WriteLine("Playlist creada con exito");
                    return true;
                }
                else
                {
                    Console.WriteLine("No hubo resultados");
                    return false;
                }
            }
            else if (criterio == "Artista" || criterio == "artista")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (artistas[i] == valorCriterio)
                    {
                        nombress.Add(valorCriterio);
                        artistass.Add(valorCriterio);
                        albumess.Add(valorCriterio);
                        geneross.Add(valorCriterio);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                string[] arraynombres = nombress.ToArray();
                string[] arrayartistas = artistass.ToArray();
                string[] arrayalbumes = albumess.ToArray();
                string[] arraygeneros = geneross.ToArray();
                Playlist playlist = new Playlist(nombrePlaylist, arraynombres, arrayartistas, arrayalbumes, arraygeneros);
                playlists.Add(playlist);
                int u = artistass.Count;
                if (u > 0)
                {
                    Console.WriteLine("Playlist creada con exito");
                    return true;
                }
                else
                {
                    Console.WriteLine("No hubo resultados");
                    return false;
                }
            }
            else if (criterio == "Album" || criterio == "album" || criterio == "Álbum" || criterio == "álbum")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (albumes[i] == valorCriterio)
                    {
                        nombress.Add(valorCriterio);
                        artistass.Add(valorCriterio);
                        albumess.Add(valorCriterio);
                        geneross.Add(valorCriterio);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                string[] arraynombres = nombress.ToArray();
                string[] arrayartistas = artistass.ToArray();
                string[] arrayalbumes = albumess.ToArray();
                string[] arraygeneros = geneross.ToArray();
                Playlist playlist = new Playlist(nombrePlaylist, arraynombres, arrayartistas, arrayalbumes, arraygeneros);
                playlists.Add(playlist);
                int u = albumess.Count;
                if (u > 0)
                {
                    Console.WriteLine("Playlist creada con exito");
                    return true;
                }
                else
                {
                    Console.WriteLine("No hubo resultados");
                    return false;
                }
            }
            else if (criterio == "Genero" || criterio == "genero" || criterio == "Género" || criterio == "género")
            {
                int i = 0;
                while (i <= 2)
                {
                    if (generos[i] == valorCriterio)
                    {
                        nombress.Add(valorCriterio);
                        artistass.Add(valorCriterio);
                        albumess.Add(valorCriterio);
                        geneross.Add(valorCriterio);
                        i++;

                    }
                    else
                    {
                        i++;
                    }
                }
                string[] arraynombres = nombress.ToArray();
                string[] arrayartistas = artistass.ToArray();
                string[] arrayalbumes = albumess.ToArray();
                string[] arraygeneros = geneross.ToArray();
                Playlist playlist = new Playlist(nombrePlaylist, arraynombres, arrayartistas, arrayalbumes, arraygeneros);
                playlists.Add(playlist);
                int u = geneross.Count;
                if (u > 0)
                {
                    Console.WriteLine("Playlist creada con exito");
                    return true;
                }
                else
                {
                    Console.WriteLine("No hubo resultados");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("No hubo resultados");
                return false;
            }
        }
        public string VerMisPlaylists() 
        {
            int largo = playlists.Count;
            int e = 0;
            int a = 0;
            while (e < largo)
            {
                int lar = playlists[e].nom.Length;
                while(a <= lar)
                {
                    return (playlists[e].name[a] + " de " + playlists[e].art[a] + " del álbum " + playlists[e].alb[a] + " del género"  + playlists[e].gen[a]);
                    a++;
                }
            }e++;

            return "";
        }   
    }
}
