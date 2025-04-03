namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal debito;
        public decimal saldo;

        public void Credito(decimal valor)
        {
            saldo = valor;
        }

        public void Debito(decimal valor)
        {
            debito = valor;
        }

    }
}