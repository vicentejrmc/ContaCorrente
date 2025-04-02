
using System.ComponentModel;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public int saldo { get; set; }
        public int numero { get; set; }
        public int limite { get;  set; }

        internal void Depositar()
        {
            
        }

        internal void Sacar()
        {
  
        }

        internal void TransferirPara(ContaCorrente conta, int valor)
        {

        }

        public Movimentacao[] movimentacoes;

        internal void ExibirExtrato()
        {
            Console.WriteLine($"Conta: {numero}");
            Console.WriteLine($"Saldo: R$ {saldo:F2}");
            Console.WriteLine($"Limite: R$ {limite:F2}");
        }

    }
}
