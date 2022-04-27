using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasBimestrais();
            Console.ReadKey();
        }

        static void NotasBimestrais()
        {
            float[,] nota = new float[3, 4];
            float[] media = new float[3];
            float soma;
            int a, b;
            for (a = 0; a < 3; a++)
            {
                soma = 0;
                Console.WriteLine("Informe as notas do " + (a + 1) + "º ano: ");
                for (b = 0; b < 4; b++)
                {
                    Console.WriteLine("Informe a " + (b + 1) + " ª nota:");
                    nota[a, b] = float.Parse(Console.ReadLine());
                    soma = soma + nota[a, b];
                }
                media[a] = soma / 4;
            }
            for (a = 0; a < 3; a++)
            {
                Console.WriteLine("Resultado das notas do " + (a + 1) + "º ano: ");
                for (b = 0; b < 4; b++)
                {
                    Console.WriteLine("O valor da " + (b + 1) + "ª nota é: " + nota[a, b]);
                }
                Console.WriteLine("A média do " + (a + 1) + "º ano é: " + media[a]);
            }
            
        }

        static void Notas()
        {
            float[] nota = new float[4];
            int i;
            Console.WriteLine("Leitura das notas:");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe a " + (i + 1) + "ª nota: ");
                nota[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Apresentação das notas lidas:");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("O valor da " + (i + 1) + "ª nota é: " + nota[i]);
            }
        }
    }

}