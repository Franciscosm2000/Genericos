using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Electrisista : IParaEmpleado
    {
        private Double Salario;
        public Electrisista (double Salario)
        {
            this.Salario = Salario;
        }

        public double getSalario()
        {
            return Salario;
        }
    }
}
