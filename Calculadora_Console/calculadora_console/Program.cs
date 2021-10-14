using System;

namespace calculadora_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int opcao;
            bool escolha = true;

            Program program = new Program();

            Console.WriteLine("#### BEM-VINDO A CALCULADORA DO DOTENET ####");

            do
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção:\n(1) Divisão\n(2) Substração\n(3) Multiplicação\n(4) Soma\n(5) Parar");
                Console.WriteLine("----------------------------");
                Console.Write("Escolha: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------\nSeu reultado é: \n" + program.Divisao(num1, num2) + "\n------------------");
                        break;
                    case 2:
                        Console.WriteLine("Primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------\nSeu reultado é: \n" + program.Subtracao(num1, num2) + "\n------------------");
                        break;
                    case 3:
                        Console.WriteLine("Primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------\nSeu reultado é: \n" + program.Multiplicacao(num1, num2) + "\n------------------");
                        break;
                    case 4:
                        Console.WriteLine("Primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------\nSeu reultado é: \n" + program.Soma(num1, num2) + "\n------------------");
                        break;
                    case 5:
                        Console.WriteLine("---------- Saindo Do programa --------");
                        escolha = false;
                        break;
                    default:
                        Console.WriteLine("------------------ Você não digitou uma opção ------------------");
                        break;
                }

                Console.WriteLine("\nAperte ENTER para Continuar");
                Console.ReadLine();
                Console.Clear();

            }

            while (escolha);

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
