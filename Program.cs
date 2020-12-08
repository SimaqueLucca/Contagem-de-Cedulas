using System;

namespace Conhecendo_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int ValorInicial = N;
            int notasCem = 0;
            int notasCinquenta = 0;
            int notasVinte = 0;
            int notasDez = 0;
            int notasCinco = 0;
            int notasDois = 0;
            int notasUm = 0;

            int[] valorCedulas = { 100, 50, 20, 10, 5, 2, 1 };

            foreach (int valor in valorCedulas)
            {
                while (N >= valor)
                {
                    N = N - valor;

                    switch (valor)
                    {
                        case 100:
                            notasCem++;
                            break;

                        case 50:
                            notasCinquenta++;
                            break;

                        case 20:
                            notasVinte++;
                            break;

                        case 10:
                            notasDez++;
                            break;

                        case 5:
                            notasCinco++;
                            break;

                        case 2:
                            notasDois++;
                            break;

                        case 1:
                            notasUm++;
                            break;
                    }
                }
                continue;
            }

            Console.WriteLine(ValorInicial);
            Console.WriteLine(notasCem + " nota(s) de R$ 100,00");
            Console.WriteLine(notasCinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(notasVinte + " nota(s) de R$ 20,00");
            Console.WriteLine(notasDez + " nota(s) de R$ 10,00");
            Console.WriteLine(notasCinco + " nota(s) de R$ 5,00");
            Console.WriteLine(notasDois + " nota(s) de R$ 2,00");
            Console.WriteLine(notasUm + " nota(s) de R$ 1,00");
        }
    }
}
