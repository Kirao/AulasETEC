using System;

namespace Aula03_FuncoesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bloco de Declaração de Variaveis

            //Limpanmdo o terminal antes de executar com
            Console.Clear();


            //Bloco de variaveis 

            String textoOriginal, textoMaiusculo, textoMinusculo, textoSemEspaço, textoOriginalaPartirDe, textoOriginalEntre, textoOriginalSubstituido;
            int posicaoInicial , posicaoFinal;
            char retirarLetra, alterarLetra;
            #endregion

            #region Bloco de Funçoes ToUpper, ToLower e Trim
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
            #endregion

            #region Bloco Mostrando os Resultados
            //Mostrando o RESULTADO
            Console.WriteLine($"\nFoi Digitado: << {textoOriginal} >>, Com ToUpper foi transformado em: {textoMaiusculo}");     //Imprimindo o texto digitado e o o texto modificado com o TOUPPER
            Console.WriteLine($"\nFoi Digitado: << {textoOriginal} >>, Com ToLower foi transformado em: {textoMinusculo}");     //Imprimindo o texto digitado e o texto modificado com o TOLOWER
            Console.WriteLine($"\nFoi Digitado: << {textoOriginal} >>, Com Trim foi transformado em...: {textoSemEspaço}");     // Imprimindo o texto digitado e tirando os espaços antes e depois do textoOriginal
            #endregion
            
            #region Bloco que determina o inicio e fim de uma frase/palavra
            Console.WriteLine("\n\n\t*** RETIRE LETRAS DO INICIO E DO FIM DA PALAVRA/FRASE ***");


            //Bloco de Entrada de Dados
            Console.Write("Digite que posição deseja iniciar: ");
            posicaoInicial = int.Parse(Console.ReadLine());
            Console.Write("Digite até oque posição deseja ir:");
            posicaoFinal = int.Parse(Console.ReadLine());


            //Bloco de analise de Dados
            textoOriginalaPartirDe = textoOriginal.Substring(posicaoInicial);
            textoOriginalEntre = textoOriginal.Substring(posicaoInicial, posicaoFinal);


            //Bloco de impressao de dados
            Console.WriteLine($"O texto original é: {textoOriginal} e irá inicar em: {textoOriginalaPartirDe}");
            Console.WriteLine($"O texto original é: {textoOriginal} e irá inicar em: {textoOriginalEntre}");

            #endregion
  
            #region Bloco de substituição de letras
             
            Console.WriteLine("\n\n\t*** SUBSTITUA LETRAS DA FRASE/PALAVRAS ***");

            //Bloco de entrada de dados para
            Console.Write("Digite a Letra que deseja Retirar: ");
            retirarLetra = char.Parse(Console.ReadLine());
            Console.Write("Digite a Letra que deseja incluir: ");
            alterarLetra = char.Parse(Console.ReadLine());

            //Bloco de analise de dados
            textoOriginalSubstituido = textoOriginal.Replace(retirarLetra,alterarLetra);


            //bloco de impressao de dados
            Console.WriteLine($"O texto original é {textoOriginal}");
            Console.WriteLine($"O texto substituido é {textoOriginalSubstituido}");

            #endregion

            #region Bloco Para Encerramento de Programa
            //Pedindo pro usuario encerrar o programa
            Console.Write("Clique em qualquer tecla para encerrar..........");     //Mensagem de solicitação de encerramento do programa
            Console.ReadKey();                                                     //Comando para que o usuario use qualquer tecla para fechar o programa
            #endregion                                                     

        }
    }
}