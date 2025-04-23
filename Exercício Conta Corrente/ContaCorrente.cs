using static System.Net.Mime.MediaTypeNames;

namespace Exercício_Conta_Corrente
{
   public  class ContaCorrente
    {
        public double saldo = 0;
        public int numero = 0;
        public double limite = 0;
        public double valor = 0;


        public double Sacar()
        {
            Console.Write("Informe um valor para sacar: ");
            valor = Convert.ToInt32(Console.ReadLine());
            saldo = saldo - valor;
            return saldo;
        }

        public double Depositar()
        {
            Console.Write("Informe um valor para depositar: ");
            valor = Convert.ToInt32(Console.ReadLine());
            saldo = saldo + valor;
            return saldo;
        }
    }
}
