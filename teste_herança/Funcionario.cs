namespace teste_herança;
class Funcionario
{
    public string? Nome {get;set;}
    public string? Idade {get;set;}

    public virtual double Lucro(){
        return 15000;
    }
   
}
