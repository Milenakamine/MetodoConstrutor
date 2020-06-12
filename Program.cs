using System;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto roupa = new Produto(32);
            roupa.Nome = "Dolce & Gabbana";

            Produto sapato = new Produto (34);
            System.Console.WriteLine(sapato.Codigo);


            Produto sobretudo = new Produto(37, "Amaro", "Bege,", 326);
            System.Console.WriteLine(sobretudo.Codigo);
            System.Console.WriteLine(sobretudo.Nome);
            System.Console.WriteLine(sobretudo.Descricao);
            System.Console.WriteLine(sobretudo.Estoque);

        }
    }
}
