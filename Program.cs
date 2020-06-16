using System;

namespace Aula18Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Jogador jogador = new Jogador();
            jogador.Peso = 75f;
            jogador.Altura = 1.80f;
            jogador.Nacionalidade = "Brasileiro";


            System.Console.WriteLine("Digite o nome do jogador:");
            jogador.Nome = Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine("Digite a data de nascimento do jogador:");
            jogador.Nascimento = DateTime.Parse( Console.ReadLine() );
            Console.Clear();

            System.Console.WriteLine("Digite a posição do jogador:");
            jogador.Posicao = Console.ReadLine();
            Console.Clear();
            
            System.Console.WriteLine($"O jogador tem {jogador.CalcularIdade()} anos");
            System.Console.WriteLine( jogador.VerificarAposentadoria() );


            
            
            
            

        }
    }
}
