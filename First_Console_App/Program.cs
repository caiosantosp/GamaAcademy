using System;

namespace first_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seu nome é {0}", nome);
            Console.WriteLine("Sua idade é {0}", idade);

            if(idade < 18){
                Console.WriteLine("Você é menor de idade");
            }else{
                Console.WriteLine("Você é maior de idade");
            }
        }
    }
}
