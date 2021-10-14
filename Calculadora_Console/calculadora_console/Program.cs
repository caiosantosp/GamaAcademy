using System;

namespace calculadora_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int opcao;

            Program program = new Program();

            Console.WriteLine("#### BEM-VINDO A CALCULADORA DO DOTENET ####");

            Console.WriteLine("Escolha uma opção:\n(1) Divisão\n(2) Substração\n(3) Multiplicação\n(4) Soma");

            opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 4:
                    Console.WriteLine("------------------\nSeu reultado é: \n" + program.Soma(num1, num2));
                    break;
                case 1:
                    Console.WriteLine("------------------\nSeu reultado é: \n" + program.Divisao(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("------------------\nSeu reultado é: \n" + program.Subtracao(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("------------------\nSeu reultado é: \n" + program.Multiplicacao(num1, num2));
                    break;

            }

        }
        public double Soma(double n1, double n2)
        {
            double res = n1 + n2;
            return res;
        }

        public double Divisao(double n1, double n2)
        {
            double res = n1 / n2;
            return res;
        }

        public double Multiplicacao(double n1, double n2)
        {
            double res = n1 * n2;
            return res;
        }

        public double Subtracao(double n1, double n2)
        {
            double res = n1 - n2;
            return res;
        }
    }
}
