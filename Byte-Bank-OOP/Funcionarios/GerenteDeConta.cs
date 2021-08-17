using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf): base(4000.00, cpf: cpf) {
            Console.WriteLine("Criando GerenteDeConta");
        }

        public override double GetBonificacao()
        {
            return base.Salario * .25;
        }

        public override void AumentarSalario()
        {
            base.Salario *= 1.05;
        }
    }
}
