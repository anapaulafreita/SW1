namespace avião;
class Aviao
{
   public string modelo="";

   public int velocidade;

   public int altitude;

   public string marca="";

   public void acelerar(){
    velocidade = velocidade + 1;
   }

   public void reduzir(){
    velocidade = velocidade - 1;
   }

   public void subir(){
    altitude = altitude + 1;
   }

   public void descer(){
    altitude = altitude - 1;
   }

}