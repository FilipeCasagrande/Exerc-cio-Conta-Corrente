using static System.Net.Mime.MediaTypeNames;

namespace Exercício_Conta_Corrente
{
    public class ContaCorrente
    {
        public decimal saldo;
        public int numero;
        public decimal limite;


        public void Sacar(decimal quantia)
        {
            if (quantia < saldo + limite)
            {
                saldo -= quantia;
            }

        }

        public void Depositar(decimal quantia)
        {
            saldo += quantia;
        }

        public void TransferirPara(ContaCorrente destinatario, decimal quantia)
        {
            destinatario.Depositar(quantia);

            this.Sacar(quantia);
        }
    }
}
