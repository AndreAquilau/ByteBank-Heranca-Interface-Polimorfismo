using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{ 

    public class GerenciadorBonicacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return this._totalBonificacao;
        }
    }
}
