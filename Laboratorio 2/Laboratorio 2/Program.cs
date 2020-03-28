using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Canción C1 = new Canción("Vete","Bad Bunny","YHLQMDLG","Reggaeton");
            Canción C2 = new Canción("Diosa", "Myke Towers", "Easy Money Baby", "Reggaeton");
            Canción C3 = new Canción("Lo malo de ser bueno", "El Cuarteto De Nos", "Porfiado", "Rock en español");

            Console.WriteLine(C1.Informacion());
            Console.WriteLine(C2.Informacion());
            Console.WriteLine(C3.Informacion());
            Console.ReadLine();
        }
    }
}
