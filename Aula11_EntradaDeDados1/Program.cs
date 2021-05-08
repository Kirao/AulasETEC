using System;

namespace Aula11_EntradaDeDados1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Area de Variaveis

            Console.Clear();
            string frase,cor1,cor2,cor3;
            string palavra1, palavra2, palavra3;
            string[] palavras;

            #endregion

            #region Entrada Individual de Dados

            //entrada de Dados
            Console.WriteLine("===========================================================");
            Console.Write("Digite uma frase.....: ");
            frase = Console.ReadLine();
            Console.Write("Digite a primeira Cor: ");
            cor1 = Console.ReadLine();
            Console.Write("Digite a segunda Cor.: ");
            cor2 = Console.ReadLine();            
            Console.Write("Digite a terceira Cor: ");
            cor3 = Console.ReadLine();
            Console.WriteLine("===========================================================");

            //Saida de dados 1
            Console.WriteLine("\n===========================================================");
            Console.WriteLine($"A Frase: {frase} , tem as cores {cor1} , {cor2} e {cor3}");
            Console.WriteLine("===========================================================");

            #endregion

            #region Entrada de Dados em Bloco (Cumulativa)
            
            //entrada de dados
            Console.WriteLine("\n\n===========================================================");
            Console.Write("Digite 3 palavras separadas por espaço: ");
            palavras = Console.ReadLine().Split(' ');
            Console.WriteLine("===========================================================");

            //Processamento de dados
            palavra1 = palavras[0];
            palavra2 = palavras[1];
            palavra3 = palavras[2];

            //Saida de dados
            Console.WriteLine("\n===========================================================");
            Console.WriteLine($"{palavras[0]} , {palavras[1]} , {palavras[2]}");
            Console.WriteLine($"{palavras[1]} , {palavras[2]} , {palavras[0]}");
            Console.WriteLine($"{palavras[2]} , {palavras[0]} , {palavras[1]}");
            Console.WriteLine($"{palavra1} , {palavra2} , {palavra3}");
            Console.WriteLine("===========================================================");            

            #endregion

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
