using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Empleado
    {
        private String Nombre;
        private double salario;

        public Empleado(String a, double b)
        {
            this.Nombre = a;
            this.salario = b;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public double getSalario()
        {
            return salario;
        }
    }
}
