using System;

namespace Aula05_MinEMaxDasVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Bloco de Var

            sbyte valorMinimoSbyte = sbyte.MinValue;
            sbyte valorMaximoSbyte = sbyte.MaxValue;
            byte valorMinimoByte = byte.MinValue;
            byte valorMaximoByte = byte.MaxValue;
            short valorMinimoShort = short.MinValue;
            short valorMaximoShort = short.MaxValue;
            ushort valorMinimoUshort = ushort.MinValue;
            ushort valorMaximoUshort = ushort.MaxValue;
            int valorMinimoInt = int.MinValue;
            int valorMaximoInt = int.MaxValue;
            uint valorMinimoUint = uint.MinValue;
            uint valorMaximoUint = uint.MaxValue;
            long valorMinimoLong = long.MinValue;
            long valorMaximoLong = long.MaxValue;
            ulong valorMinimoUlong = ulong.MinValue;
            ulong valorMaximoUlong = ulong.MaxValue;
            float valorMinimoFloat = float.MinValue;
            float valorMaximoFloat = float.MaxValue;
            double valorMinimoDouble = double.MinValue;
            double valorMaximoDouble = double.MaxValue;
            decimal valorMinimoDecimal = decimal.MinValue;
            decimal valorMaximoDecimal = decimal.MaxValue;
           
            #endregion

            #region Bloco Principal

            Console.Clear();

            Console.WriteLine("\t*** IMPRIMINDO OS MÁXIMOS E MÍNIMOS DAS VARIÁVEIS ***");
            Console.WriteLine($"Minimo SBYTE....: {valorMinimoSbyte}");
            Console.WriteLine($"Máximo SBYTE....: {valorMaximoSbyte}");
            Console.WriteLine($"Minimo BYTE.....: {valorMinimoByte}");
            Console.WriteLine($"Máximo BYTE.....: {valorMaximoByte}");
            Console.WriteLine($"Minimo SHORT....: {valorMinimoShort}");
            Console.WriteLine($"Máximo SHORT....: {valorMaximoShort}");
            Console.WriteLine($"Minimo USHORT...: {valorMinimoUshort}");
            Console.WriteLine($"Máximo USHORT...: {valorMaximoUshort}");
            Console.WriteLine($"Minimo INT......: {valorMinimoInt}");
            Console.WriteLine($"Máximo INT......: {valorMaximoInt}");
            Console.WriteLine($"Minimo UINT.....: {valorMinimoUint}");
            Console.WriteLine($"Máximo UINT.....: {valorMaximoUint}");
            Console.WriteLine($"Minimo LONG.....: {valorMinimoLong}");
            Console.WriteLine($"Máximo LONG.....: {valorMaximoLong}");
            Console.WriteLine($"Minimo ULONG....: {valorMinimoUlong}");
            Console.WriteLine($"Máximo ULONG....: {valorMaximoUlong}");
            Console.WriteLine($"Minimo FLOAT....: {valorMinimoFloat}");
            Console.WriteLine($"Máximo FLOAT....: {valorMaximoFloat}");
            Console.WriteLine($"Minimo DOUBLE...: {valorMinimoDouble}");
            Console.WriteLine($"Máximo DOUBLE...: {valorMaximoDouble}");
            Console.WriteLine($"Minimo DECIMAL..: {valorMinimoDecimal}");
            Console.WriteLine($"Máximo DECIMAL..: {valorMaximoDecimal}");

            #endregion

            #region Bloco de Saida

            //pausando a tela
            Console.WriteLine("\n\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();

            //limpando a tela ao encerrar o programa
            Console.Clear();

            #endregion

        }
    }
}