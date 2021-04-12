using System;

namespace Aula04_TestandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bloco de variavies 

            sbyte valorSbytePossitivo = 127, valorSbyteNegativo = -128;                                   //sbyte le numeros de -128 ate 127 
            byte valorByte1 = 0, valorByte2 = 255;                                                        //Byte usa de 0 ate 255
            short valorShortPossitivo = 32767, valorShortNegativo = -32768;                               //short le de 32767 ate -32768
            ushort valorUshortInicial = 0, valorUshortFinal = 65535;                                      //ushort vai de 0 ate 65535
            int valorIntPossitivo = 2147483647, valorIntNegativo = -2147483648;                           //Int vai de -2147483648 ate 2147483647
            uint valorUintInicial = 0, valorUintFinal = 4294967295;                                       //Uint vai de 0 ate 4294967295
            long valorLongPossitivo = 9223372036854775807, valorLongNegativo = -9223372036854775808;      //Long vai de 9223372036854775807 ate -9223372036854775808
            ulong valorUlongInicial = 0, valorUlongFinal = 18446744073709551615;                          //Longvai de 0 ate 18446744073709551615
            char opcao = '1', sexo = 'M';                                                                 //Aceita apenas um caracter
            bool seVerdadeiro = true, seFalse = false;                                                    //Aceita apenas true e false
            float altura = 1.77f;                                                                         //Aceita Valores com , com precisao de 7 Digitos E precisa ser colocado F no final
            double altura2 = 1.77;                                                                        //aceita Valores com , com precisao de 15 a 16 Digitos
            
            
            #endregion

            #region  Programa

            //Limpando a tela
            Console.Clear();

            //Testando variaveis
            Console.WriteLine("\t\n *** Variavel Sbyte ***");                                           //aceita de -128 ate 127 -Gastando 1 Byte de Memoria 
            Console.WriteLine($"O valorSbytePossitivo CHEGA a: {valorSbytePossitivo}");
            Console.WriteLine($"O valorSbyteNegativo CHEGA a.: {valorSbyteNegativo}");

            Console.WriteLine("\t\n *** Variavel Byte ***");                                             //aceita de 0 ate 255 Gastando 1 Byte de memoria 
            Console.WriteLine($"O valorByte1 Inicia em.......: {valorByte1}");
            Console.WriteLine($"O valorByte2 Termina em......: {valorByte2}");

            Console.WriteLine("\t\n *** Variavel short ***");                                           //aceita de -32768 ate 32767 Gastando 2 Bytes de memoria 
            Console.WriteLine($"O valorShortPossitivo CHEGA a: {valorShortPossitivo}");
            Console.WriteLine($"O valorShortNegativo CHEGA a.: {valorShortNegativo}");

            Console.WriteLine("\t\n *** Variavel Ushort ***");                                           //aceita de 0 ate 65535 Gastando 2 Bytes de memoria 
            Console.WriteLine($"O valorUshortInicial CHEGA a.: {valorUshortInicial}");
            Console.WriteLine($"O valorUshortFinal CHEGA a...: {valorUshortFinal}");

            Console.WriteLine("\t\n *** Variavel Int ***");                                             //aceita de -2³¹ ate 2³¹-1 Gastando 4 Bytes de memoria 
            Console.WriteLine($"O valorIntPossitivo CHEGA a..: {valorIntPossitivo}");
            Console.WriteLine($"O valorIntNegativo CHEGA a...: {valorIntNegativo}");

            Console.WriteLine("\t\n *** Variavel Uint ***");                                             //aceita de 0 ate 4294967295 Gastando 4 Bytes de memoria 
            Console.WriteLine($"O valorUintInicial CHEGA a...: {valorUintInicial}");
            Console.WriteLine($"O valorUintFinal CHEGA a.....: {valorUintFinal}");

            Console.WriteLine("\t\n *** Variavel Long ***");                                             //aceita de -9223372036854775808 ate 9223372036854775807 Gastando 8 Bytes de memoria 
            Console.WriteLine($"O valorLongPossitivo CHEGA a.: {valorLongPossitivo}");
            Console.WriteLine($"O valorLongNegativo CHEGA a..: {valorLongNegativo}");

            Console.WriteLine("\t\n *** Variavel Ulong ***");                                            //aceita de 0 ate 18446744073709551615 Gastando 8 Bytes de memoria 
            Console.WriteLine($"O valorUlongInicial CHEGA a.: {valorUlongInicial}");
            Console.WriteLine($"O valorUlongFinal CHEGA a...: {valorUlongFinal}");

            Console.WriteLine("\t\n *** Variavel char ***");                                            //aceita Aceita apenas um caracter Gastando 2 Bytes de memoria 
            Console.WriteLine($"A opção escolhida foi.......: {opcao}");
            Console.WriteLine($"O Sexo escolhido foi........: {sexo}");

            Console.WriteLine("\t\n *** Variavel bool ***");                                            //aceita aceita apenas true ou false  um caracter Gastando 1/2 Byte de memoria  
            Console.WriteLine($"Se for verdadeiro..........: {seVerdadeiro}");
            Console.WriteLine($"Se for falso...............: {seFalse}");

            Console.WriteLine("\t\n *** Variavel float ***");                                           //aceita Valores com , com precisao de 7 Digitos Gastando Gastando 4 Bytes
            Console.WriteLine($"A sua altura é.............: {altura}");

            Console.WriteLine("\t\n *** Variavel double ***");                                          //aceita Valores com , com precisao de 15 a 16 Digitos Gastando Gastando 8 Bytes
            Console.WriteLine($"A sua altura é.............: {altura2}");
            

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
