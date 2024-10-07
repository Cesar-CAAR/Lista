using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLIsta
{
    internal class lista
    {
        private Nodo inicio;

        public lista()
        {
            inicio = null;
        }

        //Metodo para insertar nodo 
        public void Add(int num)
        {
            Nodo nuevo = new Nodo(num);


            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
            }
        }


        public void Print()
        {
            Nodo act;
            act = inicio;

            if (act == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                while (act != null)
                {
                    Console.WriteLine($"{act.Valor}");
                    act = act.Sig;
                }
            }
        }
    }
}
