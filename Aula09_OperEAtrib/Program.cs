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
            Console.WriteLine("*** Valor Atribuido a Variavel ***");
            Console.WriteLine($"O valor da variavel valor1 é: {valor1}");
            Console.WriteLine($"O valor da variavel valor2 é: {valor2}");

            //Calculando valor1 e valor2 somando 2
            
            valor1 = valor1 + 2;
            valor2 += 2;        //Faz a mesma função da de cima so que de uma forma simplificada


            //Mostrando o resultado de valor1 e valor2 apos a soma
            Console.WriteLine("\n*** Valor Atribuido a Variavel ***");
            Console.WriteLine($"valor1 = valor1 + 2 : {valor1}");
            Console.WriteLine($"valor2 += 2: {valor2}");

            //subtraindo valor1 e valor2

            valor1 = valor1 - 2;
            valor2 -= 2;

            Console.WriteLine("\n*** Valor Atribuido a Variavel ***");
            Console.WriteLine($"valor1 = valor1 - 2 : {valor1}");
            Console.WriteLine($"valor2 -= 2: {valor2}");

            //multiplicando valor1 e valor2

            valor1 = valor1 * 2;
            valor2 *= 2;

            Console.WriteLine("\n*** Valor Atribuido a Variavel ***");
            Console.WriteLine($"valor1 = valor1 * 2 : {valor1}");
            Console.WriteLine($"valor2 *= 2: {valor2}");

            //declaração de Variavel
            
            string sigla = "ETEC";
            string nome = " João Belarmino";

            //Juntando strings

            sigla += nome;

            Console.WriteLine("\n*** Valor Atribuido a Variavel ***");
            Console.WriteLine($"A sigla + nome é : {sigla}");




            #endregion

            #region  Area de Encerramento do Programa

            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey(); 
            Console.Clear(); 

            #endregion
        }
    }
}
