using System;
using System.Globalization;

namespace Atividade_Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* 1 - Escreva um algoritmo que realiza as 4 operações matemáticas. Deve ser inserido pelo usuário 8 números inteiros,
            sendo que os 2 primeiros números serão para realizar a adição, o 3º e 4º números para realizar divisão, o 5º e o 6º números para realizar a multiplicação e o 7º e 8º números para realizar a subtração.
            Antes de mostrar o resultado a tela deverá ser limpa. Mostrar os resultados dos caçulos e os 8 números digitados.
            
            /****************************************************************************************
            * ÁREA DE DECLARAÇÃO DAS VARIAVEIS
            ****************************************************************************************/
            string nomePessoa;
            int soma , soma2 , totalSoma , subtração , subtração2 , totalSubtração, multiplicação , multiplicação2 , totalMultiplicação;
            double divisao , divisao2 , totalDivisao;

            /****************************************************************************************
            *ÁREA DE ENTRADA DE DADOS 
            ****************************************************************************************/
            Console.WriteLine("\n");
            Console.WriteLine("======Digite seu Nome!======= ");
            nomePessoa = Console.ReadLine();
            Console.Write("Olá "+ nomePessoa);
            Console.WriteLine(" Bora fazer umas contas! ");
            Console.WriteLine("\n");

            Console.WriteLine("========Vamos começar com Adição:========");
            Console.WriteLine("Informe o Primeiro Numero: ");
            soma = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Numero: ");
            soma2 = int.Parse(Console.ReadLine());

            Console.WriteLine("======Vamos Agr para subtração:========== ");
            Console.WriteLine("Informe o Primeiro Numero: ");
            subtração = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Numero: ");
            subtração2 = int.Parse(Console.ReadLine());

            Console.WriteLine("======Vamos Agora para Multiplicação:==== ");
            Console.WriteLine("Informe o Primeiro Numero: ");
            multiplicação = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Numero: ");
            multiplicação2 = int.Parse(Console.ReadLine());

            Console.WriteLine("=======Para finalizar a Divisao:========= ");
            Console.WriteLine("Informe o Primeiro Numero: ");
            divisao = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Numero: ");
            divisao2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Clear();


             
            /****************************************************************************************
            *ÁREA DE CALCULOS
            ****************************************************************************************/
            totalSoma = soma + soma2;
            totalSubtração = subtração - subtração2;
            totalMultiplicação = multiplicação * multiplicação2;
            totalDivisao = divisao / divisao2;


            /****************************************************************************************
            *ÁREA DE SAIDA DE RESULTADO
            ****************************************************************************************/
            
            Console.WriteLine("===================Resultados das Contas=================");
            Console.WriteLine("Total da soma é.........: " + totalSoma);
            Console.WriteLine("Total da Subtração é....: " + totalSubtração);
            Console.WriteLine("Total da Multiplicação é: " + totalMultiplicação);
            Console.WriteLine("Total da Divisao é......: " + totalDivisao.ToString("F2"));
            Console.WriteLine("Numeros usados Para adisao: "+ soma + "+" + soma2 + " Subtração: "+ subtração + "-" + subtração2 + " Multiplicação: " + multiplicação + "*" + multiplicação2 + " Divisao: "+ divisao + "+" + divisao2);
            Console.WriteLine("Tecle qualquer tecla para sair....");
            Console.ReadKey();


        }
    }
}
