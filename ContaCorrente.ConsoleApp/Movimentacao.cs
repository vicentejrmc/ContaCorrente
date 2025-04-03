namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public int numero;
        public int saldo;
        public int limite;

        public void Movimentacoes(int numero, int saldo, int limite )
        {
            this.saldo = saldo;
            this.limite = limite;
            this.numero = numero;
        }

    }
}