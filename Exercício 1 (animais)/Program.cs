namespace Exercício_1__animais_;
class Program
{
    static void Main(string[] args)
    {
      Homem xx = new Homem();
      Cao vv = new Cao();
      Gato cc = new Gato();

      Console.WriteLine("Chamei o homem e ele: " + xx.Fala());
      Console.WriteLine("Chamei o cão e ele: " + vv.Fala());
      Console.WriteLine("Chamei o gato e ele: " + cc.Fala());


    }
}
