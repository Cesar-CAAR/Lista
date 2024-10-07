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

        public int Count()
        {
            //regresar el numero de nodos en la lista
            //regresar 0 si la lista esta vacia
        }

        public int Find(int pos)
        {
            //regresar el valor del nodo en la posición
            //indica, la primera posición es cero (como arreglo)
            //si no esta la posición, regresar -1
        }

        public int FindValue(int num)
        {
            //regresar la posición del nodo del valor indicado
            //la primera posición siempre es cero (como arreglo)
            //si no esta el valor, regresa -1
        }

        public bool Change(int pos)
        {
            //cambia el valor dol nodo en la posicion indicada
            //y regresa true si el cambio fue exitoso
            //si no encuentra el nodo o la lista esta vacia
            //regresar false, ya que el cambio no fue exitoso
        }

        public bool Delete(int pos)
        {
            //elimina el nodo en la posicion indicada
            //regresa true si la eliminacion fue exitosa
            //regresa false si la eliminacion no fue exitosa
            //si la lista esta vacia o no esta la posicion
        }
    }
}
