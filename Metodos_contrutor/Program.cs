﻿namespace metodos_construtor;
class Program
{
    static void Main(string[] args)
    {
       
       //Produto p1 = new Produto();
       //Produto p1 = new Produto(100);
       Produto p1 = new Produto("ABC",10);

       p1.MostraDados();
    }
}
