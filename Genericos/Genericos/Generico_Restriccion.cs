using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    //Generica con restricciones, permite manejar objeto de cualquier tipo pero que tengas salario
    class Generico_Restriccion <T> where T: IParaEmpleado
    {
        private T [] DE;
        private int i = 0;

        public Generico_Restriccion(int z)
        {
            DE = new T[z];
        }

        public void add(T obj)
        {
            DE[i] = obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return DE[i];
        }
    }
}
