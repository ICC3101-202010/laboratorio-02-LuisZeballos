using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Canción
    {
        protected string nombre;
        protected string artista;
        protected string album;
        protected string genero;

        public string Informacion()
        {
            return ("Género: " + genero + ", Artista: " + artista + ", Álbum: " + album + ", Nombre: " + nombre);
        }

        public Canción(string aNombre, string aArtista, string aAlbum, string aGenero)
        {
            nombre = aNombre;
            artista = aArtista;
            album = aAlbum;
            genero = aGenero;

        }
    }
}
