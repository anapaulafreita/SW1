namespace CONTA_BANCARIA;
class Conta
{
    public string? nomeCliente {get;set;}
    public int numeroConta {get;set;}
    public double saldo {get;set;}
    public double limite {get;set;}

    //métodos para realizar um depósito
    public void depositar (double valor){
        this.saldo += valor;
    }

    
     //para sacar
     public void sacar (double valor){
        this.saldo -= valor;
    }

    

     //métodos consultar saldo, retorna um saldo disponivel e o limite.
     public double ConsultaSaldo(){
       return this.saldo + this.limite;
     }

}