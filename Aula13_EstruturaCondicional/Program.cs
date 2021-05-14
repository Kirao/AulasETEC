using System;

namespace Aula13_EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de variaveis

            Console.Clear();
            int horario = 1, numero, horarioDigitado;
            string nome;

            #endregion

            #region Programa Condicional Simples

            //Verificando o Horario
            //Tirulo
            Console.WriteLine("======================================================");
            Console.WriteLine("=============== Usando IF simples ====================");
            Console.WriteLine("======================================================");

            //Criando a condicional
            if(horario > 5)
            {
                Console.WriteLine("Bom dia");
            }
            if(horario < 5)
            {
                Console.WriteLine("Boa tarde");
            }
            if(horario != 5)
            {
                Console.WriteLine("Boa noite");
            }

            #endregion

            #region Programa Condicional Composta

            //Titulo
            Console.WriteLine("\n\n======================================================");
            Console.WriteLine("================ Usando IF e ELSE ====================");
            Console.WriteLine("======================================================");

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite um valor inteiro: ");
            numero = int.Parse(Console.ReadLine());

            //Buscando o resto da divisao
            int resto = numero % 2 ;

            //Verificando se o valor é par
            if(resto == 0)
            {
                Console.WriteLine($"{nome}, o valor {numero} tem resto = {resto}. Portanto é PAR");
            }

            else
            {
                Console.WriteLine($"{nome}, o valor {numero} tem resto = {resto}. Portanto é IMPAR");
            }

            #endregion

            #region Programa Condicional Composta Com encadeamento

            //Titulo
            Console.WriteLine("\n\n===============================================================");
            Console.WriteLine("================ Usando IF, ELSE e ELSE IF ====================");
            Console.WriteLine("===============================================================");

            Console.Write("Digite um Horario: ");
            horarioDigitado = int.Parse(Console.ReadLine());

            //Area da Condicional 
            if(horarioDigitado >= 0 && horarioDigitado <= 24)
            {
                //Começando uma Nova Condicional - Condicional Encadeada
                if(horarioDigitado < 12)
                {
                    Console.WriteLine("Bom dia!");
                }
                else if(horarioDigitado < 18)
                {
                    Console.WriteLine("Boa tarde!");
                }
                else if(horarioDigitado < 24)
                {
                    Console.WriteLine("Boa noite!");
                }
            }
            else
            {
                Console.WriteLine("Por favor, Digite um valor entre 0 e 24!");
            }

            #endregion
           
            #region Area de Encerramento do Programa
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
