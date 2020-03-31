using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Playlist
    {
        public string name;
        public string[] nom;
        public string[] art;
        public string[] alb;
        public string[] gen;

        public Canción[] canciones = { };

        public Playlist(string aName, string[] anom, string[] aart, string[] aalb, string[] agen )
        {
            name = aName;
            nom = anom;
            art = aart;
            alb = aalb;
            gen = agen;
        }
        public void VerPlaylist()
        {
            Console.WriteLine("La Playlist " + name + " contiene: ");
            int i = 0;
            while (i <= 2) 
            {
                Console.WriteLine(canciones[i]);
                i++;
            }
        }
    }
}
