using System;

namespace Aula03_FuncoesStrings
{
    class Program
    {
        static void Main(string[] args)
        {


            //Limpanmdo o terminal antes de executar com
            Console.Clear();


            //Bloco de variaveis 

            String textoOriginal, textoMaiusculo, textoMinusculo, textoSemEspaço;


            /**************************************************************************************************
            ******************************************** BLOCO 01 ********************************************
            *********************************** DIGITE ABC abc DEF def ***************************************
            **************************************************************************************************/

            //Manipulando os valores atraves de funçoes (ToUPPER, TOLOWER E TRIM)
            Console.WriteLine("=============================================================================================================");
            Console.WriteLine("==================================CONVERTENDO TEXTO DIGITADO=================================================");
            Console.WriteLine("=============================================================================================================");
            Console.Write("\n Digite uma sequencia de caracteres Maiusculas e Minuscula: ");
            textoOriginal = Console.ReadLine();
            textoMaiusculo = textoOriginal.ToUpper();             //Converte tudo que foi digitado em MAIUSCULO
            textoMinusculo = textoOriginal.ToLower();             //Converte tudo que foi digitado em Minusculo
            textoSemEspaço = textoOriginal.Trim();                //Retira qualquer espaço antes e depois do texto original

            //Mostrando o RESULTADO
            Console.WriteLine($"\nFoi Digitado: << {textoOriginal} >>, Com ToUpper foi transformado em: {textoMaiusculo}");     //Imprimindo o texto digitado e o o texto modificado com o TOUPPER
            Console.WriteLine($"\nFoi Digitado: << {textoOriginal} >>, Com ToLower foi transformado em: {textoMinusculo}");     //Imprimindo o texto digitado e o texto modificado com o TOLOWER
            Console.WriteLine($"\nFoi Digitado: << {textoOriginal} >>, Com Trim foi transformado em...: {textoSemEspaço}");     // Imprimindo o texto digitado e tirando os espaços antes e depois do textoOriginal
            Console.WriteLine("\n\n");


            //Pedindo pro usuario encerrar o programa
            Console.Write("Clique em qualquer tecla para encerrar..........");     //Mensagem de solicitação de encerramento do programa
            Console.ReadKey();                                                         //Comando para que o usuario use qualquer tecla para fechar o programa


        }
    }
}
