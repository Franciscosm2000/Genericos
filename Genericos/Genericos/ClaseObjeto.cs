using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class ClaseObjeto
    {
        public ClaseObjeto(int x)
        {
            datoElemento = new object[x];
        }

        public void Add(Object obj)
        {
            datoElemento[i] = obj;
            i++;
        }

        public Object getElemento(int x)
        {
            return datoElemento[x];
        }

        // array de tipo object para admitir cualquier tipo de objeto
        private Object[] datoElemento;
        //Contador para el array
        private int i = 0;
    }
}
