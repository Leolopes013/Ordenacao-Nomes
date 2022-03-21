using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string auxNomes;

            // cadastrando os valores no vetor
            Console.WriteLine("CADASTRANDOS OS NOMES\n\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe um nome..: ");
                nomes[i] = Console.ReadLine();
            }

            // impressão antes da ordenação
            Console.WriteLine("IMPRESSÃO ANTES DA ORDENAÇÃO\n\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            // Ordenação do vetor nomes
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (nomes[i].CompareTo(nomes[j]) == 1)
                    {
                        auxNomes = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = auxNomes;
                    }
                }
            }

            //IMPRESSÃO DOS NOMES ORDENADOS
            Console.WriteLine("IMPRESSÃO DOS NOMES ORDENADOS\n\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.ReadKey();
        }
    }
}
