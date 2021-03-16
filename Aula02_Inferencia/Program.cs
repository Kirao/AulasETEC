using System;
using System.Globalization;


namespace Aula02_Inferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************************************
            * Declaraando Variavel para trabalhar baseado em INFERENCIA
            ****************************************************************************************/

            var numero = 10;                 //Compilador transforma em Int
            var resultado = 20.0;            //Compilador transforma em Double
            var nome = "Guilherme";          //Compilador transforma em String
            var sexo = "M";                  //Compilador transforma em Char


            /****************************************************************************************
            * Imprimindo o resultado
            ****************************************************************************************/

            //limoando a tela antes de iniciar a impressao dos dados
            Console.Clear();

            //imprimindo as vars

            Console.WriteLine("O valor que esta dentro da variavel numero é: " + numero);
            Console.WriteLine("O valor que esta dentro da variavel resultado é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor que esta dentro da variavel nome é: " + nome);
            Console.WriteLine("O valor que esta dentro da variavel sexo é: " + sexo);

            /****************************************************************************************
            * Problemas ao trabalhar com inferencia
            * Usar variavel por inferencia precisa ser muito bem pensado e 
            * estudado pelo programador.
            * Pois, é muito facil cometer falhas e o compilador pode apontar erro diversos.
            ****************************************************************************************/

            //apontar uma variavel em outra que nao é do mesmo tipo

            // n da pra transformar string em int numero = nome;
            
            Console.WriteLine("A quantidade de usuarios é: " + numero);


            //Programa que pausa a tela quando executamos em modo terminal
            Console.WriteLine("=== Pressione qualquer tecla para encerrar o programa ===");
            Console.ReadKey();


            Console.Clear();


        }
    }
}
