using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Director : IParaEmpleado
    {
        private Double Salario;
        public Director(double Salario)
        {
            this.Salario = Salario;
        }

        public double getSalario()
        {
            return Salario;
        }
    }
}
