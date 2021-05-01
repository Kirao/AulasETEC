using System;

namespace Aula08_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Área principal do programa 
            //Declaração de variáveis para cálculo com precedencia
            int calculo1 = 3 + 4 * 2;
            int calculo2 = (3 + 4) * 2;

            //Apresentando o resultado
            Console.WriteLine("\n*** Precedencia Matematica ***");
            Console.WriteLine($" 3 + 4 * 2 = {calculo1} ");
            Console.WriteLine($" (3 + 4) * 2 = {calculo2} ");

            //Declaração de variável para (Divisão e resto)
            //Achando o quociente da divisão
            double divisao = 15 / 3;
            //Achando o resto da divisao 
            double restoDiv = 15 % 3;

            //Apresentando o resultado 
            Console.WriteLine("\n*** Resto e divisao matematica ***");
            Console.WriteLine($" 15 / 3 = {divisao} ");
            Console.WriteLine($" 15 % 3 = {restoDiv} ");

            //Declaração de variável
            double semDizima = 10 / 3;
            double comDizima = 10.0 / 3.0;

            //Apresentando o resultado 
            Console.WriteLine("\n*** Arredondando e sem arredondamento ***");
            Console.WriteLine($"10 / 3 = {semDizima} ");
            Console.WriteLine($"10.0 / 3.0 = {comDizima} ");

            //declaração de variáveis (Usando método POW)
            //báscara
            double a = 1.0 , b = -3.0 , c = -4.0;
            double deltaConvencional = (b * b) -4.0 * (a * c);
            double deltaComMetodo = Math.Pow(b , 2.0 ) - 4.0 * (a * c);

            //Apresentando o resultado 
            Console.WriteLine("\n*** Calculando convencional e com Metodo ***");
            Console.WriteLine($"(b * b) -4.0 * (a * c) = {deltaConvencional} ");
            Console.WriteLine($"Com metodo Math.Pow(b , 2.0 ) -4.0 * (a * c) = {deltaComMetodo} ");

            //Square Root (Raiz quadrada = sqrt)
            //raiz de deltaConvencional = POSSITIVO
            double raiz1 = (-b + Math.Sqrt(deltaConvencional)) / (2.0 * a);
             //raiz de deltaConvencional = NEGATIVO
            double raiz2 = (-b - Math.Sqrt(deltaConvencional)) / (2.0 * a);

             //Apresentando o resultado 
            Console.WriteLine("\n*** Calculando x' x'' ***");
            Console.WriteLine($"Raiz Possitiva x' = {raiz1} ");
            Console.WriteLine($"Raiz Negativa x'' = {raiz2} ");
            
            #endregion

            #region  Area de Encerramento do Programa

            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey(); 
            Console.Clear(); 

            #endregion


        }
    }
}
