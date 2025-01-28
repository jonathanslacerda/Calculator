using System;

namespace Calculator {

    class Program {

        static void Main(string[] args) {

            Menu();

        }

        static void Menu() {

            Console.Clear();
            
            Console.WriteLine(" ___________________________________");
            Console.WriteLine("|                                   |");
            Console.WriteLine("| Escolha a operação básica:        |");
            Console.WriteLine("| 1 - Soma                          |");
            Console.WriteLine("| 2 - Subtração                     |");
            Console.WriteLine("| 3 - Multiplicação                 |");
            Console.WriteLine("| 4 - Divisão                       |");
            Console.WriteLine("| 5 - Sair                          |");
            Console.WriteLine("|___________________________________|");

            Console.WriteLine("");
            Console.WriteLine(" ___________________________________");
            Console.WriteLine("        Selecione uma opção: ");

            int selection = int.Parse (Console.ReadLine());

            switch(selection) {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


            Console.ReadKey();

        }


        static void Sum() {

            var (valor1, valor2) = Values();

            Console.WriteLine("A Soma dos números é: " + (valor1 + valor2));

            Console.ReadKey();

            Menu();

        }

        static void Subtraction() {

            var (valor1, valor2) = Values();

            Console.WriteLine("A Subtração dos números é: " + (valor1 - valor2));

            Console.ReadKey();

            Menu();

        }


        static void Multiplication() {

            var (valor1, valor2) = Values();

            Console.WriteLine("A Multiplicação dos números é: " + (valor1 * valor2));

            Console.ReadKey();
            Menu();

        }

        static void Division() {

            var (valor1, valor2) = Values();

            Console.WriteLine("A Divisão dos números é: " + (valor1 / valor2));

            Console.ReadKey();

            Menu();

        }


        static (double, double) Values() {

            Console.Clear();

            Console.WriteLine("Insira o primeiro valor: ");
            double valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            double valor2 = float.Parse(Console.ReadLine());

            return (valor1, valor2);
        }

    }

}