using System.Reflection.Metadata;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public decimal saldo;
        public decimal numero;
        public decimal limite;
        public decimal credito;
        public decimal debito;

        public Movimentacao[] movimentacoes;

        public void Depositar(decimal valor)
        {
            saldo += valor;
            limite = saldo;
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
            limite = saldo;
            while(limite < 0)
                Console.WriteLine($"Saldo insuficiente: Saldo em conta = {saldo}");
        }

        public void TransferirPara(ContaCorrente conta, decimal valor)
        {
            Sacar(valor);

            conta.saldo += valor;
            conta.limite = conta.saldo;
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Extrado da Conta: #{numero}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Movimentações:");
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Crédito: {credito:F2}");
            Console.WriteLine($"Débito: {debito:F2}");

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Saldo Atual: R$ {saldo:F2}");
 
        }

    }
}
