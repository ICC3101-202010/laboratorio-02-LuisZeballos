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

        public Espotifai(string[] aNombres, string[] aArtistas, string[] aAlbums, string[] aGeneros)
        {
            nombres = aNombres;
            artistas = aArtistas;
            albumes = aAlbums;
            generos = aGeneros;
        }


        public bool AgregarCancion(string bNombre, string bArtista, string bAlbumes)
        {
            if (nombres[0] == bNombre && artistas[0] == bArtista && albumes[0] == bAlbumes)
            {

                return false;
            }
            else if (nombres[1] == bNombre && artistas[1] == bArtista && albumes[1] == bAlbumes)
            {
                return false;
            }
            else if (nombres[2] == bNombre && artistas[2] == bArtista && albumes[2] == bAlbumes)
            {
                return false;
            }
            else
            {
                return true;
            }

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
    }
}
