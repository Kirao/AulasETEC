using System;

namespace Aula09_OperEAtrib
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Area de Declaração de variaveis

            Console.Clear();
            int valor1 = 10 , valor2 = 10;

            #endregion

            #region Programa Principal

            //Mostrando o resultado de valor1 e valor2
            Console.WriteLine($"O valor da variavel valor1 é: {valor1}");
            Console.WriteLine($"O valor da variavel valor2 é: {valor2}");

            //Calculando valor1 e valor2 somando 2
            
            valor1 = valor1 + 2;
            valor2 += 2;        //Faz a mesma função da de cima so que de uma forma simplificada


            //Mostrando o resultado de valor1 e valor2 apos a soma
            Console.WriteLine($"\nvalor1 = valor1 + 2 : {valor1}");
            Console.WriteLine($"valor2 += 2: {valor2}");

            #endregion

            #region  Area de Encerramento do Programa

            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey(); 
            Console.Clear(); 

            #endregion
        }
    }
}
