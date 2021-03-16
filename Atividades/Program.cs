using System;

namespace Atividades
{  /*1)
Crie um programa para ler:
* O nome de um Time;
* Quantidade de jogadores;
* Se a modalidade é masculina ou feminina.
-> Imprima os resultados */

    class Program
    {
        static void Main(string[] args)
        {
            string nomeTime;     //Variavel usada para colocar o nome do time pois pode ser colocado qualquer caracter
            int quantidadeJogador;          // Variavel para colocar apenas numeros inteiros
            char modalidadeTime;         //Variavel usada para colcoar apenas uma letra 

            Console.WriteLine("\n");   //espaço
            Console.WriteLine("==========Dados de entrada==========");  //Entrada de dados do time
            Console.WriteLine("\n");    //espaço
            Console.Write("Qual nome do Time?................: ");
            nomeTime = Console.ReadLine();                          //usando a variavel string
            Console.Write("Quantos jogadores tem o Time?.....: ");
            quantidadeJogador = int.Parse(Console.ReadLine());     //converte int em string
            Console.Write("Qual modalidade é o time? (M ou F): ");
            modalidadeTime = char.Parse(Console.ReadLine());       //Converte char em string
            Console.WriteLine("\n");   //espaço


            Console.WriteLine("=========Informaçoes do time=========");  //saida de dados do time
            Console.WriteLine("\n");  //espaço
            Console.WriteLine($"Nome do Time...........: {nomeTime}");  //Usando a variavel do nome do time
            Console.WriteLine($"Quantidade de Jogadores: {quantidadeJogador}");  //usando a variavel de quantidade de jogadores
            Console.WriteLine($"Modalidade.............: {modalidadeTime}");    // usando a variavel de modalidade 
            Console.WriteLine("\n");   //espaço  
        
         }
    }
} 
