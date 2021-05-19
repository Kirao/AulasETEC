using System;
using System.Globalization;

namespace Aula14_EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de variaveis

            Console.Clear();
            double raizQuadrada, numero;
            string opcao = "s";

            #endregion

            #region Entrada de Dados 1

            /*****************************************************************************************************
            * Após fazer a ENTRADA DE DADOS 1 e testá-la, vamos deixá-la comentada e criar a ENTRADA DE DADOS 2.
            * Na ENTRADA DE DADOS 2, vamos criá-la com o laço de repetição WHILE
            *****************************************************************************************************/
            
            /*
            //Entrada de valor a ser calculado
            Console.Write("Digite um valor para verificar a raiz: ");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Processamento do Calculo da raiz
            raizQuadrada = Math.Sqrt(numero);

            //Saida de dados
            Console.WriteLine($"A raiz de: {numero} é: {raizQuadrada.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            #endregion

            #region Entrada de Dados 2
            
            //Criando um laço de repetição
            while (opcao == "s" || opcao == "S")
            {
                //Entrada de valor a ser calculado
                Console.Write("Digite um valor para verificar a raiz: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Processamento do Calculo da raiz
                raizQuadrada = Math.Sqrt(numero);

                //Saida de dados
                Console.WriteLine($"A raiz de: {numero} é: {raizQuadrada.ToString("F2", CultureInfo.InvariantCulture)}");

                //Verificando se o usuario deseja continuar
                Console.Write("Se pretende continuar a calcular raiz, Digite S ou s: ");
                opcao = Console.ReadLine();

            }

            //Mensagem final
            Console.WriteLine("Voce saiu do laço. Muito Obrigado por usar o Programa.");
            #endregion

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
