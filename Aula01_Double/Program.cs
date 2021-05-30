using System; //biblioteca para execução de recursos básicos do computador
using System.Globalization; //Bibioteca para complementações

namespace Aula01
{
    public class Program //Declaração de uma CLASSE pública com o nome de Program
    {
        public static void Main(string[] args) //Declaração de um método ESTÁTICO com o nome main
        {
            //Area de declaração de VARIAVEIS
            String nomePessoa;    //variavel para aceitar 2 ou mais letras,Numeros e qualquer caracter especial
            char sexoPessoa;      //Aceita Uma letra apenas
            int idadePessoa;      //Aceita no max ate 4 bits numeros de -32k a + 32k e que seja numero inteiro, caso passe dessa numeração usar longint
            Double alturaPessoa , multIdadePelaAlt; //Aceita qualquer numero com Virgula


            //Área de  entrada de Dados
            Console.WriteLine("==========Dados de Entrada==========");      //Sera solocitado os dados de entrada do Usuario
            Console.Write("Digite Seu Nome...........: ");                  //mensagem de solicitação do nome do Usuario
            nomePessoa = Console.ReadLine();                                //Comando que solicita o nome para ser guardado e usado na variavel nomePessoa
            Console.Write("Digite seu Sexo: F, M ou O: ");                  //Mensagem de solicitação do nome de Usuario
            sexoPessoa = char.Parse(Console.ReadLine());                    //char.Parse vai analisar oq vc digitou e transformar em string
            Console.Write("Digite sua Idade..........: ");                  //Mensagem que solicita a idade do usuario
            idadePessoa = int.Parse(Console.ReadLine());                    //int.parse vai analisar oq vc digitou e transformar em string
            Console.Write("Digite sua Altura..........: ");                 //Mensagem que solicita a altura do usuario
            alturaPessoa = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);   //Double.parse vai analisar oq vc digitou e transformar em string o culture info deixa o programa internacional

            //Area de Calculos
            //Calculando a idade da pessoa * pela altura declaração
            multIdadePelaAlt = idadePessoa * alturaPessoa;

            
            //Area de Saida de Dados
            Console.WriteLine("\n\n===========Dados de Saida===========");                                       //Mostra os dados que foi inserida na entrada 
            Console.WriteLine("Seu nome é.............................: " + nomePessoa);                         //Mensagem com a variavel do nome da pessoa
            Console.WriteLine("Seu Sexo é.............................: " + sexoPessoa);                         //Mensagem com a variavel do sexo da pessoa
            Console.WriteLine("Sua Idade é............................: " + idadePessoa);                        //Mensagem com a Variavel da idade da Pessoa
            Console.WriteLine("Sua Altura é...........................: " + alturaPessoa.ToString("F2"));        //Mensagem com a Variavel da altura da Pessoa o .ToString("F2") adiciona 2 casa depois da ,
            Console.WriteLine("A multiplicação  da idade * a altura é : " + multIdadePelaAlt.ToString("F2"));    //Mensagem com A variavel de multiplicação de idade e altura
            Console.WriteLine("\n");                                                                             // espaço
        }
    }
}