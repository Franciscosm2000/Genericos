using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Secretaria : IParaEmpleado
    {
        private Double Salario;
        public Secretaria(double Salario)
        {
            this.Salario = Salario;
        }

        public double getSalario()
        {
            return Salario;
        }
    }
}
