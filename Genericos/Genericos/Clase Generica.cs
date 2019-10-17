using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Clase_Generica <T>
    {
        public  Clase_Generica (int x)
        {
            datoElemento = new T[x];
        }

        public void Add(T obj)
        {
            datoElemento[i] = obj;
            i++;
        }

        public T getElemento(int x)
        {
            return datoElemento[x];
        }

        // array de tipo t para admitir cualquier tipo de objeto
        private T [] datoElemento;
        //Contador para el array
        private int i = 0;
    }
}
