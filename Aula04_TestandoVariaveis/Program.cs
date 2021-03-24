using System;

namespace Aula04_TestandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bloco de variavies 

            sbyte valorSbytePossitivo = 127, valorSbyteNegativo = -128;                                   //sbyte le numeros de -128 ate 127 
            short valorShortPossitivo = 32767, valorShortNegativo = -32768;                               //short le de 32767 ate -32768
            int valorIntPossitivo = 2147483647, valorIntNegativo = -2147483648;                           //Int vai de -2147483648 ate 2147483647
            long valorLongPossitivo = 9223372036854775807, valorLongNegativo = -9223372036854775808;      //Long vai de 9223372036854775807 ate -9223372036854775808
            byte valorByte1 = 0, valorByte2 = 255;                                                        //Byte usa de 0 ate 255
            
            #endregion

            #region  Programa

            //Limpando a tela
            Console.Clear();

            //Testando variaveis
            Console.WriteLine("\t\n *** Variavel Sbyte ***");                                           //aceita de -128 ate 127 -Gastando 1 Byte de Memoria 
            Console.WriteLine($"O valorSbytePossitivo CHEGA a: {valorSbytePossitivo}");
            Console.WriteLine($"O valorSbyteNegativo CHEGA a: {valorSbyteNegativo}");

            Console.WriteLine("\t\n *** Variavel short ***");                                           //aceita de -32768 ate 32767 Gastando 2 Bytes de memoria 
            Console.WriteLine($"O valorShortPossitivo CHEGA a: {valorShortPossitivo}");
            Console.WriteLine($"O valorShortNegativo CHEGA a.: {valorShortNegativo}");


            Console.WriteLine("\t\n *** Variavel Int ***");                                             //aceita de -2³¹ ate 2³¹-1 Gastando 4 Bytes de memoria 
            Console.WriteLine($"O valorIntPossitivo CHEGA a: {valorIntPossitivo}");
            Console.WriteLine($"O valorIntNegativo CHEGA a.: {valorIntNegativo}");

            
            Console.WriteLine("\t\n *** Variavel Long ***");                                             //aceita de -9223372036854775808 ate 9223372036854775807 Gastando 8 Bytes de memoria 
            Console.WriteLine($"O valorLongPossitivo CHEGA a: {valorLongPossitivo}");
            Console.WriteLine($"O valorLongNegativo CHEGA a.: {valorLongNegativo}");

            Console.WriteLine("\t\n *** Variavel Byte ***");                                             //aceita de 0 ate 255 Gastando 1 Byte de memoria 
            Console.WriteLine($"O valorByte1 Inicia em......: {valorByte1}");
            Console.WriteLine($"O valorByte2 Termina em.....: {valorByte2}");

            #endregion

            #region Pausando a tela

            //Pausando a tela
            Console.Write("\n\nPressione qualquer tecla para encerrar......");
            Console.ReadKey();

            #endregion

            #region Limpando o Console

            //Limpando a tela ao encerrar o programa
            Console.Clear();

            #endregion

        }
    }
}
