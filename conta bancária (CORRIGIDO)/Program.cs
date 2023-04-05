namespace CONTA_BANCARIA;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício conta bancaria etec mcm");
        Conta conta = new Conta();

        conta.nomeCliente = "Ana Freitas";
        conta.limite = 2000;
        conta.depositar(500);
        conta.sacar(100);

        double saldo = conta.ConsultaSaldo();

        Console.WriteLine("Seu saldo é de: " + saldo);

        //conta.nomeCliente = "Ana Freitas";
        //conta.numeroConta = 777;
        //conta.limite = 2000;
       // conta.saldo = 5000;

        //Console.WriteLine("Olá, "+ conta.nomeCliente + " , Seu saldo é de: " + conta.saldo);
        //Console.WriteLine("Seu limite de saque é de:  "+ conta.limite);
        //Console.WriteLine("O número da sua conta é :  "+ conta.numeroConta);

    }
}
