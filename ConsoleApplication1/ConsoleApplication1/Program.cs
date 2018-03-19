using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisor r = new Televisor("Panasonic", "KCV-25", Televisor.EnumTipoPantalla.LCD , true, Televisor.EnumEstado.APAGADO, 50, 50, 50);
            Console.ReadLine();
            Console.WriteLine(r);
            r.Brillo = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
