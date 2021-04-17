using System;
using System.Globalization;

namespace Aula06_ConversaoImplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de Declaracao de Variaveis

            Console.Clear();
            float notaFiscal, valorNotaComImpostos2;
            double valorNotaComImpostos, notaFiscal2;

            #endregion

            #region Programa Passando 4 Bytes (Float) para 8 Bytes (Double) - CONVERSAO IMPLICITA

            //Entrada de dados
            Console.WriteLine("==============================================================================");
            Console.WriteLine("==== Passando 4 Bytes (Float) para 8 Bytes (Double) - CONVERSAO IMPLICITA ====");
            Console.WriteLine("==============================================================================");
            Console.Write("Digite o valor da nota Fiscal: ");
            notaFiscal = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
            //Processamento
            valorNotaComImpostos = notaFiscal*10000;

            //Saida
            Console.WriteLine($"\nValor da nota sem imposto R$: {notaFiscal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor da nota com imposto R$: {valorNotaComImpostos.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            #region Programa Passando 8 Bytes (Double) para 4 Bytes (float) - CONVERSAO EXPLICITA

            //Entrada de dados
            Console.WriteLine("==============================================================================");
            Console.WriteLine("==== Passando 8 Bytes (Double) para 4 Bytes (float) - CONVERSAO EXPLICITA ====");
            Console.WriteLine("==============================================================================");
            Console.Write("Digite o valor da nota Fiscal: ");
            notaFiscal2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
            //Processamento
            valorNotaComImpostos2 = (float)notaFiscal2*10000;

            //Saida
            Console.WriteLine($"\nValor da nota sem imposto R$: {notaFiscal2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor da nota com imposto R$: {valorNotaComImpostos2.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            #region  Area de Encerramento do Programa

            Console.Write("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey(); 
            Console.Clear();

            #endregion


        }
    }
}
