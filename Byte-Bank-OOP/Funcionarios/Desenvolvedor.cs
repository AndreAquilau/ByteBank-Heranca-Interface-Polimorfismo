using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf): base(2000.00, cpf: cpf) {
            Console.WriteLine("Criando Desenvolvedor");
        }

        public override double GetBonificacao()
        {
            return base.Salario * .1;
        }

        public override void AumentarSalario()
        {
            base.Salario *= .15;
        }
    }
}
