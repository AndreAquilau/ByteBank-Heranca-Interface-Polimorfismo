using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf): base(2000.00, cpf: cpf) {
            Console.WriteLine("Criando Auxiliar");
        }

        public override double GetBonificacao()
        {
            return base.Salario * .2;
        }

        public override void AumentarSalario()
        {
            base.Salario *= 1.1;
        }
    }
}
