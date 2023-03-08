namespace aula;
class Exemplo
{
   //atributos
   public string nome = "";
   public int idade = 0;
   public bool vacinado = false;

   //métodos

//Sem retorno / sem parametros
   public void mostramsg(){
    Console.WriteLine("Oi 2F :)");
   }

//Sem retorno / com parametros
   public void mostranome(string texto){
     Console.WriteLine("Oi " + texto);
   }

//Com retorno / sem parametros   
   public string msg(){
    return "Olá, tudo bem?";
   }

//Com retorno / com parametros
public int somar(int a, int b){
   return a+b;
}

}