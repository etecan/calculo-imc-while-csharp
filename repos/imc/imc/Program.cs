using System;

namespace imc
{
    class Program

    {
        static void Main(string[] args)
        {
            float peso, altura;
            double imc;
            string cor = "White";
            string situacao = null;
            int repetir = 1;

            Console.WriteLine("Calculo IMC");


            while (repetir == 1)
            {
                Console.Write("\n\nInforme seu peso em KG (exemplo ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("90");
                Console.ResetColor();
                Console.WriteLine(") :");

                peso = float.Parse(Console.ReadLine());


                Console.Write("\nInforme sua altura em metros (exemplo ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1,87");
                Console.ResetColor();
                Console.WriteLine(") :");
                altura = float.Parse(Console.ReadLine());

                imc = peso / (Math.Pow(altura, 2));

                if (imc < 16)
                {
                    cor = "Red";
                    situacao = "Magreza grave";
                }
                else if (imc < 17)
                {
                    cor = "Red";
                    situacao = "Magreza moderada";
                }
                else if (imc < 18.5)
                {
                    cor = "Yellow";
                    situacao = "Abaixo do peso";
                }
                else if (imc < 25)
                {
                    cor = "Green";
                    situacao = "Peso Normal";
                }
                else if (imc < 30)
                {
                    cor = "Yellow";
                    situacao = "Acima do peso";
                }
                else if (imc < 35)
                {
                    cor = "Red";
                    situacao = "Obesidade";

                }
                else if (imc < 40)
                {
                    cor = "Red";
                    situacao = " Obesidade Severa";
                }
                else if (imc >= 40)
                {
                    cor = "Red";
                    situacao = " Obesidade Morbida";
                }

                Console.WriteLine("\nSeu IMC : " + Math.Round(imc, 1));
                Console.Write("Situação : ");
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cor);
                Console.Write(situacao);
                Console.ResetColor();

                Console.Write("\n\nDigite ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1");
                Console.ResetColor();
                Console.Write(" para fazer outro calculo ou ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("0");
                Console.ResetColor();
                Console.WriteLine(" para Sair");

                repetir = int.Parse(Console.ReadLine());

            }



        }
    }
}
