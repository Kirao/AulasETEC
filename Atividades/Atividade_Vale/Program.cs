using System;
using System.Globalization;

namespace Atividade_Vale
{
    class Program
    {
        static void Main(string[] args)
        {
/****************************************************************************************
            * ÁREA DE DECLARAÇÃO DAS VARIAVEIS
            ****************************************************************************************/
            double vale , vale2 , valeTotal;

            /****************************************************************************************
            * ÁREA DE ENTRADA DE DADOS
            ****************************************************************************************/

            Console.WriteLine("Vicente seu saldo é: ");
            vale = double.Parse(Console.ReadLine());


            /****************************************************************************************
            * ÁREA DE CALCULO
            ****************************************************************************************/
            vale2 = 300;
            valeTotal = vale2 + vale;


            /****************************************************************************************
            * ÁREA DE SAIDA DE DADOS
            ****************************************************************************************/
            Console.WriteLine("Total valor creditado no mês vigente é: " + valeTotal);
            Console.WriteLine("Tecle qualquer tecla para sair....");

            Console.ReadKey();
            
        }
            
    }
}
