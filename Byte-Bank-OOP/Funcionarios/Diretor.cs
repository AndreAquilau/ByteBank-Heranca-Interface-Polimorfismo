using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000.00, cpf: cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override double GetBonificacao()
        {
            return base.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            base.Salario *= 1.15;
        }
    }
}
