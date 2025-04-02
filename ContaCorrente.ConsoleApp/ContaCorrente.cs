using System.Reflection.Metadata;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public int saldo;
        public int numero;
        public int limite;

        public void Depositar(int valor)
        {
            saldo += valor;
            limite = saldo;
        }

        public void Sacar(int valor)
        {
            saldo -= valor;
            limite = saldo;
            while(limite < 0)
                Console.WriteLine($"Saldo insuficiente: Saldo em conta = {saldo}");
        }

        public void TransferirPara(ContaCorrente conta, int valor)
        {
            Sacar(valor);

            conta.saldo += valor;
            conta.limite = conta.saldo;
        }

        //public Movimentacao[] movimentacoes;

        public void ExibirExtrato()
        {
            Console.WriteLine($"Conta: {numero}");
            Console.WriteLine($"Saldo: R$ {saldo:F2}");
            Console.WriteLine($"Limite: R$ {limite:F2}");
        }

    }
}
