using System;

namespace Aula18Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Jogador neymar = new Jogador();
            neymar.Nome = "Neymar";

            neymar.Peso = 85f;

            neymar.Altura = 1.80f;

            neymar.Posicao = "Atacante";

            neymar.Nascimento = DateTime.Parse( "15/08/1989" );

            
            System.Console.WriteLine(neymar.CalcularIdade());
            System.Console.WriteLine(neymar.VerificarAposentadoria());

        }
    }
}
