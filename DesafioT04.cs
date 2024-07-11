using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

class desafio04
{
    static  Dictionary<string, string> Qualidades = new Dictionary<string, string>();
    public struct Amigo
    {
        public string Nome;
        public short Idade;
        public string Qualidade;
    }
    static void Periodo (short idade)
    {
        if (idade < 15) Console.WriteLine("\nPeríodo Clássico, época que o anime era bom");
        else if (idade >= 15 && idade < 30) Console.WriteLine("\nPeríodo Shippuden, ó a Guerra Ninja na sua porta");
        else if (idade >= 30) Console.WriteLine("\nBoruto é surto coletivo");
        else Console.WriteLine($"\n{idade}??? Então tá joia :D");

    }
    static void Main()
    {
        short opcao;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Vamos salvar o contato dos amigos do Gaara...");
        Console.ResetColor();
        do { 
        Console.WriteLine("\nQuantos amigos você deseja salvar?");
        short quantidade = short.Parse(Console.ReadLine());
        
            for (var i = 0; i < quantidade; i++)
            {

                Amigo amigo;
                Console.WriteLine("\nEscreva o nome do(a) amiga:");
                amigo.Nome = Console.ReadLine();
                Console.WriteLine("Qual é a idade dele(a)? (Para sabermos em que período está)");
                amigo.Idade = short.Parse(Console.ReadLine());
                Console.WriteLine("Escreva uma qualidade dele(a): (Pra deixar de bio)");
                amigo.Qualidade = Console.ReadLine();

                Qualidades.Add(amigo.Nome, amigo.Qualidade);
                Periodo(amigo.Idade);
            }
            Console.WriteLine("\nContato(s) salvo(s), você deseja salvar mais algum? \nSIM = 1 \nNÃO = 0");
            opcao = short.Parse(Console.ReadLine());
        } while (opcao != 0);


        Console.WriteLine("\nDigite o nome do(a) que deseja ver a qualidade:");
        string amigoDesejado = Console.ReadLine();

        foreach (var amg in Qualidades )
        {
            if (amigoDesejado == amg.Key)
            {
                Console.WriteLine($"{amg.Key} tem essas qualidades: {amg.Value}");
            }
        }


        // PS: tentei fazer função e falhei miseravelmente

        /*static Amigo AdicionarAmigo()
        {
            Amigo amigo;
            Console.WriteLine("\nEscreva o nome do(a) amiga:");
            amigo.Nome = Console.ReadLine();
            Console.WriteLine("Qual é a idade dele(a)?");
            amigo.Idade = short.Parse(Console.ReadLine());
            Console.WriteLine("Escreva uma qualidade dele(a):");
            amigo.Qualidade = Console.ReadLine();

            return amigo;
        }*/

        /*  static void ListadeAmigos()
          {
              string Amigo = AdicionarAmigo().Nome;
              string Qualidade = AdicionarAmigo().Qualidade;

              Qualidades.Add(Amigo, Qualidade);
          }*/

    }