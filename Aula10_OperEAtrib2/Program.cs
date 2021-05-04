using System;

namespace Aula09_OperEAtrib2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bloco 1
            int valor1 = 10, valor2, valor3;

            //mostrando os valores
            Console.WriteLine("*** Mostrando Valores ***");
            Console.WriteLine($"O valor1 Foi declarado como: {valor1}");

            //Calculando
            valor2 = valor1;
            valor3 = ++valor2;   //Adiciona 1 ao valor de valor2

            //mostrando os valores
            Console.WriteLine("*** Mostrando Valores ***");
            Console.WriteLine($"O valor2 Foi declarado como 10 e vem atualizado com o valor: {valor2}");
            Console.WriteLine($"O valor3 recebera o valor de 11 da variavel valor 2: {valor3}");  //com a soma de 1 pois o ++ esta antes da variavel

            //mostrando os valores
            Console.WriteLine("\n*** Mostrando Valores ***");
            Console.WriteLine($"O valor1 Foi declarado como: {valor1}");

            //Calculando
            valor2 = valor1;
            valor3 = valor2++;   //Adiciona 1 ao valor de valor2

            //mostrando os valores
            Console.WriteLine("*** Mostrando Valores ***");
            Console.WriteLine($"O valor2 Foi declarado como 10 e vem atualizado com o valor: {valor2}");
            Console.WriteLine($"O valor3 recebera o valor da variavel valor2: {valor3}");  //sem a soma de 1 pois o ++ esta depois da variavel

            #endregion

            #region Area de Encerramento do Programa

            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();

            #endregion
        }
    }
}
