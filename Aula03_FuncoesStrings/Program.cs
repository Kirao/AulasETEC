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
            string textoARetirar, textoAAcrescentar, substituiTextoOriginal, textoOriginal, textoMaiusculo, textoMinusculo, textoSemEspaço, textoOriginalaPartirDe, textoOriginalEntre, textoOriginalSubstituido;
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
            textoOriginalaPartirDe = textoOriginal.Substring(posicaoInicial);                      //Substring usa para cortar o começo do texto e o final tambem           
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
            textoOriginalSubstituido = textoOriginal.Replace(retirarLetra,alterarLetra);        //Rplace usado para tirar alguma letra e colocar alguma outra no lugar das letras retirada

            //bloco de impressao de dados
            Console.WriteLine($"O texto original é {textoOriginal}");
            Console.WriteLine($"O texto substituido é {textoOriginalSubstituido}");

            #endregion

            #region Substituição de String


            Console.WriteLine("\n\n\t***Substituindo Strings ***");

            //Bloco de entrada de dados
            Console.Write("Digite a palavra que quer substituir do textoOriginal........................: ");
            textoARetirar = Console.ReadLine();
            
            Console.Write("Digite o texto que quer colocar noo trecho a ser substituido do textoOriginal: ");
            textoAAcrescentar = Console.ReadLine();
            

            //Bloco de análise de daos 
            substituiTextoOriginal = textoOriginal.Replace(textoARetirar , textoAAcrescentar);    //Replace é usado para substituir palavras ou letras dentro do texto

            //bloco de saida de Dados
            Console.WriteLine($"O textoOriginal é {textoOriginal}");
            Console.WriteLine($"O substituido é: {substituiTextoOriginal}");

            #endregion

            #region Teste de String Vazia


            //bloco de declaração de var
            string nuloOuVazio;

            //bloco de entrada de Dados
            Console.WriteLine("\n\n\t ***Testando String Vazia ***");
            Console.Write("Digite um texto ou Simplesmente de ENTER: ");
            nuloOuVazio = Console.ReadLine();

            //Bloco de analise de Dados
            bool verificaNuloOuVazio = string.IsNullOrEmpty(nuloOuVazio);          //bool é o tipo de variavel que aceita true ou false nada alem de true ou false (True =1(Ligado) / False = 0(Desligado))  / IsNullOrEmpty verifica se essa variavel é nula ou vazia

            //Bloco de saida de dados
            Console.WriteLine($"O texto digitado foi: {nuloOuVazio}");
            Console.WriteLine($"Sendo assim, o texto esta vazio? {verificaNuloOuVazio}");
            #endregion

            #region Achando a posição dentro do texto
            

            Console.WriteLine("\n\n\t *** Ache a posição ***");

            //bloco de variavel
            string achaTexto;
            int primeiraPosicao , ultimaPosicao;

            //Bloco de entrada de dados
            Console.Write("Digite o texto que queria achar na variavel textoOriginal");
            achaTexto = Console.ReadLine();

            //Bloco de analise de Dados
            //Achando a primeira posição da palavra digitada a
            primeiraPosicao = textoOriginal.IndexOf(achaTexto);     //Index acha primeira referencia
            //achando a ultima posição da palavra digitada
            ultimaPosicao = textoOriginal.LastIndexOf(achaTexto);    //last(Ultima) index acha a ultima referencia

            //Bloco de saida de dados
            Console.WriteLine($"A PRIMEIRA posição encontrada foi: {primeiraPosicao}");
            Console.WriteLine($"A ULTIMA posição encontrada foi: {ultimaPosicao}");

            #endregion

            #region Bloco Para Encerramento de Programa
            //Pedindo pro usuario encerrar o programa
            Console.Write("Clique em qualquer tecla para encerrar..........");     //Mensagem de solicitação de encerramento do programa
            Console.ReadKey();      //Comando para que o usuario use qualquer tecla para fechar o programa
                                                           
            #endregion                                                     

        }
    }
}