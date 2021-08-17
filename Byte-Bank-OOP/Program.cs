using ByteBank.Sistemas;
using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program.CalcularBonificacao();
            Program.UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");


        }

        public static void CalcularBonificacao()

        {
            GerenciadorBonicacao gerenciadorBonicacao = new GerenciadorBonicacao();

            Desenvolvedor desenvolvedor = new Desenvolvedor("035.540.032-96");
            desenvolvedor.Nome = "André";


            Designer pedro = new Designer("833.22.048-49");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonicacao.Registrar(pedro);
            gerenciadorBonicacao.Registrar(roberta);
            gerenciadorBonicacao.Registrar(igor);
            gerenciadorBonicacao.Registrar(camila);

            Console.WriteLine($"Nome:{pedro.Nome} Bonificação: {pedro.GetBonificacao()} ");
            Console.WriteLine($"Nome:{roberta.Nome} Bonificação: {roberta.GetBonificacao()} ");
            Console.WriteLine($"Nome:{igor.Nome} Bonificação: {igor.GetBonificacao()} ");
            Console.WriteLine($"Nome:{camila.Nome} Bonificação: {camila.GetBonificacao()} ");
            Console.WriteLine($"Total de Bonifição do Mês: {gerenciadorBonicacao.GetTotalBonificacao()}");

        }
    }
}
