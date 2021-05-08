using System;
using System.Globalization;

namespace Aula11_EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Area de Variavel

            Console.Clear();
            string[] dadosPessoais;
            string nomePessoa;
            char sexoPessoa;
            int idadePessoa;
            double alturaPessoa;

            #endregion

            #region Area do Programa

            //Entrada de Dados
            Console.Write("Digite: nome, sexo, idade, altura. Separados por espaço: ");
            dadosPessoais = Console.ReadLine().Split(' ');

            //Processamento de dados
            nomePessoa = dadosPessoais[0];
            sexoPessoa = char.Parse(dadosPessoais[1]);
            idadePessoa = int.Parse(dadosPessoais[2]);
            alturaPessoa = double.Parse(dadosPessoais[3]);

            //Saida de dados
            Console.WriteLine($"\nOlá {dadosPessoais[0]} voce é do sexo: {dadosPessoais[1]}, possui {dadosPessoais[2]} anos e sua altura é de: {dadosPessoais[3]}");
            Console.WriteLine($"\nOlá {nomePessoa} voce é do sexo: {sexoPessoa}, possui {idadePessoa} anos e sua altura é de: {alturaPessoa.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            #region Area de Encerramento do Programa

            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
            Console.Clear();

            #endregion
        }
    }
}
