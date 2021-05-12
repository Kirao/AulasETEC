using System;

namespace Aula12_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de Declaração de Vars
            Console.Clear();

            bool comparacao1, comparacao2, comparacao3, comparacao4, comparacao5, comparacao6, comparacao7;

            #endregion

            #region Processamento de Dados

            comparacao1 = 4 != 5;
            comparacao2 = 2 > 3;
            comparacao3 = 2 > 3 && 4 != 5;  //&& Representa [ e ] 
            comparacao4 = 2 > 3 || 4 != 5;  // || Representa [ ou ]
            comparacao5 = !(2 > 3) && 4 != 5;  // ! antes de algum numero ou texto inverte o resultado 

            /*
            && (e) - PRECISA QUE TODOS DEEM TRUE PARA RETORNAR TRUE
            || (OU) - SE UMA ÚNICA CONDIÇÃO DER TRUE ELE RETORNA TRUE
            ! (NEGAÇÃO) - Inverte o resultado. ELe nega o valor obtido
            */

            //Comparando resultado e nao numero
            comparacao6 = comparacao1 || comparacao3 && comparacao4;
            comparacao7 = (comparacao1 || comparacao3) && comparacao2;

            #endregion

            #region Bloco de saida de dados

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("*** Saída de dados das comparações E(&&) OU(||) ***");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($" A comparação [4 != 5] tem resultado............: {comparacao1}");
            Console.WriteLine($" A comparação [2 > 3] tem resultado.............: {comparacao2}");
            Console.WriteLine($" A comparação [2 > 3 && 4 != 5] tem resultado...: {comparacao3}");
            Console.WriteLine($" A comparação [2 > 3 || 4 != 5] tem resultado...: {comparacao4}");
            Console.WriteLine($" A comparação [!(2 > 3) && 4 != 5] tem resultado: {comparacao5}");
            Console.WriteLine($" A comparacao1 || comparacao3 && comparacao4 é..: {comparacao6}");
            Console.WriteLine($" A (comparacao1 || comparacao3) && comparacao2 é: {comparacao7}");

            #endregion

            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
