using System;

namespace Aula12_OperadoresComparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de declaração de VArs

            Console.Clear();
            int a = 10;
            bool comparacao1, comparacao2, comparacao3, comparacao4, comparacao5, comparacao6, comparacao7, comparacao8;

            #endregion

            #region Bloco de Processamento

            //Comparação maior menor
            comparacao1 = a < 10;
            comparacao2 = a < 20;
            comparacao3 = a > 10;
            comparacao4 = a > 05;

            //diferença, maior igual, menor igual, igual
            comparacao5 = a != 10;  //Diferença 
            comparacao6 = a == 10;  //Igual Igual
            comparacao7 = a >= 10;  //Maior ou Igual
            comparacao8 = a <= 10;  //Menor ou igual

            #endregion

            #region Bloco de saida de Dados

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("*** BLOCO DE COMPARAÇÃO (MAIOR >) OU (MENOR <) ***");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"O valor atribuido a variavel a é: {a}");
            Console.WriteLine($"Na verificação se [a < 10] o resultado é: {comparacao1}");
            Console.WriteLine($"Na verificação se [a < 20] o resultado é: {comparacao2}");
            Console.WriteLine($"Na verificação se [a > 10] o resultado é: {comparacao3}");
            Console.WriteLine($"Na verificação se [a > 05] o resultado é: {comparacao4}");

            Console.WriteLine("\n--------------------------------------------------------------------------------------");
            Console.WriteLine("*** BLOCO DE COMPARAÇÃO (Diferente !=) (Menor igual <=) (Maior igual >=) (Igual ==)***");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"O valor atribuido a variavel a é: {a}");
            Console.WriteLine($"Na verificação se [a != 10] o resultado é: {comparacao5}");
            Console.WriteLine($"Na verificação se [a == 10] o resultado é: {comparacao6}");
            Console.WriteLine($"Na verificação se [a >= 10] o resultado é: {comparacao7}");
            Console.WriteLine($"Na verificação se [a <= 10] o resultado é: {comparacao8}");

            #endregion

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
