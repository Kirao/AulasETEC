using System; //biblioteca para execução de recursos básicos do computador

namespace Aula01
{
    public class Program //Declaração de uma CLASSE pública com o nome de Program
    {
        public static void Main(string[] args) //Declaração de um método ESTÁTICO com o nome main
        {
            Console.WriteLine("\n");
            Console.WriteLine("=====Dados digitados em tempo de Programação=====");    //Dados de entrada colocado de forma manual 
            Console.WriteLine("Nome..: Guilherme");
            Console.WriteLine("Idade.: 20 ");
            Console.WriteLine("Altura: 1,73");
            Console.WriteLine("Sexo..: M");
            Console.WriteLine("=================================================");
            Console.WriteLine("\n");
                        

            //Criando o mesmo texto acima, Porém com VARIÁVEIS
            String nomePessoa;    //variavel para aceitar 2 ou mais letras,Numeros e qualquer caracter especial
            char sexoPessoa;      //Aceita Uma letra apenas
            int idadePessoa;      //Aceita no max ate 4 bits numeros de -32k a + 32k e que seja numero inteiro, caso passe dessa numeração usar longint

            Console.WriteLine("==========Dados de Entrada==========");      //Sera solocitado os dados de entrada do Usuario
            Console.Write("Digite Seu Nome...........: ");                  //mensagem de solicitação do nome do Usuario
            nomePessoa = Console.ReadLine();                                //Comando que solicita o nome para ser guardado e usado na variavel nomePessoa
            Console.Write("Digite seu Sexo: F, M ou O: ");                  //Mensagem de solicitação do nome de Usuario
            sexoPessoa = char.Parse(Console.ReadLine());                    //char,Parse vai analisar oq vc digitou e transformar em string
            Console.Write("Digite sua Idade..........: ");                  //Mensagem que solicita a idade do usuario
            idadePessoa = int.Parse(Console.ReadLine());

            
            Console.WriteLine("\n\n===========Dados de Saida===========");  //Mostra os dados que foi inserida na entrada 
            Console.WriteLine($"Seu nome é.: {nomePessoa}");                //Mensagem com a variavel do nome da pessoa
            Console.WriteLine($"Seu Sexo é.: {sexoPessoa}");                //Mensagem com a variavel do sexo da pessoa
            Console.WriteLine($"Sua Idade é: {idadePessoa}");               //Mensagem com a Variavel da idade da Pessoa
            Console.WriteLine("\n");                                        // espaço
        }
    }
}