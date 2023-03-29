namespace exemplo;
class Produto
{
    private string? Nome {get; set;}
    private double Preco {get; set;}

    public void MostraDdos(){
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Preço: " + Preco);
    }

    public void AlteraNome(string nome){
        this.Nome = nome;
    }

    public void AlteraPreco(double preco){
        this.Preco = preco;
    }
}
