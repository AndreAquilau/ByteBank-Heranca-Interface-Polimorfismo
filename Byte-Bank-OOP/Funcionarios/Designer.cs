using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf): base(3000.00, cpf: cpf) {
            Console.WriteLine("Criando Designer");
        }

        public override double GetBonificacao()
        {
            return base.Salario * .17;
        }

        public override void AumentarSalario()
        {
            base.Salario *= 1.15;
        }
    }
}
