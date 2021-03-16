using System; //biblioteca para execução de recursos básicos do computador
using System.Globalization; //Bibioteca para complementações

namespace Aula01
{
    public class Program //Declaração de uma CLASSE pública com o nome de Program
    {
        public static void Main(string[] args) //Declaração de um método ESTÁTICO com o nome main

        {   /*************************************************************************************************************
            * Área de declaração de VARIAVEIS
            *************************************************************************************************************/
            String nomePessoa , nomePessoa2;    //variavel para aceitar 2 ou mais letras,Numeros e qualquer caracter especial
            char sexoPessoa , sexoPessoa2;      //Aceita Uma letra apenas
            int idadePessoa , idadePessoa2;      //Aceita no max ate 4 bits numeros de -32k a + 32k e que seja numero inteiro, caso passe dessa numeração usar longint
            Double alturaPessoa , alturaPessoa2 , mediaIdades , mediaAlturas; //Aceita qualquer numero com Virgula


            /*************************************************************************************************************
            * Área de  entrada de Dados
            *************************************************************************************************************/
            Console.WriteLine("==========Dados de Entrada Pessoa 01==========");      //Sera solocitado os dados de entrada do Usuario
            Console.Write("Digite Seu Nome...........: ");                  //mensagem de solicitação do nome do Usuario
            nomePessoa = Console.ReadLine();                                //Comando que solicita o nome para ser guardado e usado na variavel nomePessoa
            Console.Write("Digite seu Sexo: F, M ou O: ");                  //Mensagem de solicitação do nome de Usuario
            sexoPessoa = char.Parse(Console.ReadLine());                    //char.Parse vai analisar oq vc digitou e transformar em string
            Console.Write("Digite sua Idade..........: ");                  //Mensagem que solicita a idade do usuario
            idadePessoa = int.Parse(Console.ReadLine());                    //int.parse vai analisar oq vc digitou e transformar em string
            Console.Write("Digite sua Altura..........: ");                 //Mensagem que solicita a altura do usuario
            alturaPessoa = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);   //Double.parse vai analisar oq vc digitou e transformar em string o culture info deixa o programa internacional
            Console.WriteLine("\n");                                               //espaço

            Console.WriteLine("==========Dados de Entrada Pessoa 02==========");      //Sera solocitado os dados de entrada do Usuario
            Console.Write("Digite Seu Nome...........: ");                  //mensagem de solicitação do nome do Usuario
            nomePessoa2 = Console.ReadLine();                                //Comando que solicita o nome para ser guardado e usado na variavel nomePessoa
            Console.Write("Digite seu Sexo: F, M ou O: ");                  //Mensagem de solicitação do nome de Usuario
            sexoPessoa2 = char.Parse(Console.ReadLine());                    //char.Parse vai analisar oq vc digitou e transformar em string
            Console.Write("Digite sua Idade..........: ");                  //Mensagem que solicita a idade do usuario
            idadePessoa2 = int.Parse(Console.ReadLine());                    //int.parse vai analisar oq vc digitou e transformar em string
            Console.Write("Digite sua Altura..........: ");                 //Mensagem que solicita a altura do usuario
            alturaPessoa2 = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);   //Double.parse vai analisar oq vc digitou e transformar em string o culture info deixa o programa internacional

        
            /*************************************************************************************************************
            * Area de Calculo
            *************************************************************************************************************/
            //Calculando a media de idada das pessoas
            mediaIdades = (idadePessoa + idadePessoa2) /2;

            //Calculando a media de altura das pessoas
            mediaAlturas = (alturaPessoa + alturaPessoa2) /2;


            /*************************************************************************************************************
            * Area de Saida de Dados
            *************************************************************************************************************/
            Console.WriteLine("\n\n===========Dados de Saida Pessoa 01===========");                             //Mostra os dados que foi inserida na entrada 
            Console.WriteLine("Olá " + nomePessoa + ", seu sexo é: " + sexoPessoa + ", sua idade é: " + idadePessoa + ", sua altura é: " + alturaPessoa.ToString("F2")); //Mensagem com a variavel do nome da pessoa,sexo,idade e altura
            Console.WriteLine("Olá " + nomePessoa2 + ", seu sexo é: " + sexoPessoa2 + ", sua idade é: " + idadePessoa2 + ", sua altura é: " + alturaPessoa2.ToString("F2")); //Mensagem com a variavel do nome da pessoa,sexo,idade e altura
            Console.WriteLine("A média das Alturas é: " + mediaAlturas.ToString("F2"));      //Calcula a media de altura das pessoas
            Console.WriteLine("A média das Idades é.: " + mediaIdades.ToString("F2"));       //Calcula a media de idade das pessoas 
            Console.WriteLine("\n");                                                                             // espaço

        }
    }
}