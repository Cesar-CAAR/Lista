using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLIsta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lista miLista = new lista();
            miLista.Add(4);
            miLista.Add(5);
            miLista.Add(9);
            miLista.Add(12);

            miLista.Print();

            Console.ReadLine();
        }
    }
}
