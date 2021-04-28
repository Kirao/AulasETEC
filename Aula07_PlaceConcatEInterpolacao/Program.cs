using System;
using System.Globalization;

namespace Aula07_PlaceConcatEInterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de Variaveis

            int idadeFuncionario;
            double salarioFuncionario;
            string nomeFuncionario;

            #endregion

            #region Area Principal

            //Entrada de dados
            Console.Write("Digite seu nome...: ");
            nomeFuncionario = Console.ReadLine();
            Console.Write("Digite sua idade..: ");
            idadeFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Digite seu Salario: ");
            salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saida de dados
            Console.WriteLine("\n**** Saida por Placeholder ****");
            Console.WriteLine("{0} tem {1} ano(s) e seu salário é R$ {2:F2}.", nomeFuncionario , idadeFuncionario , salarioFuncionario);
            Console.WriteLine("{0} tem {1} ano(s) e seu salário é R$ {2}.", nomeFuncionario , idadeFuncionario , salarioFuncionario.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("\n**** Saida por Interpolação ****");
            Console.WriteLine($"{nomeFuncionario} tem {idadeFuncionario} ano(s) e seu salario é R$ {salarioFuncionario.ToString("F3", CultureInfo.InvariantCulture)}.");

            Console.WriteLine("\n**** Saida por Concatenação ****");
            Console.WriteLine(nomeFuncionario + " tem " + idadeFuncionario + " ano(s) e seu salario é R$ " + salarioFuncionario.ToString("F3", CultureInfo.InvariantCulture));




            #endregion

            #region Area de Limpeza do programa
            //Pausando a tela
            Console.Write("\n\nPressione qualquer tecla para encerrar......");
            Console.ReadKey();

            //Limpando a tela ao encerrar o programa
            Console.Clear();

            #endregion
        }
    }
}
