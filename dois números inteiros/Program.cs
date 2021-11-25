using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dois_números_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double divisao, multiplicacao, n1, n2;

            Console.Write("Introduza o primeiro nº: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o segundo nº: ");
            n2 = double.Parse(Console.ReadLine());

            if(n1 >= n2)
            {
                divisao = n1/n2;
                Console.WriteLine("Como o 1º número é maior que o 2º, o programa fez a divisão e o resultado dá " + divisao + ".");
            }
            else
            {
                multiplicacao = n1 * n2;
                Console.WriteLine("Como o 2º número é maior que o 1º, o programa fez a multiplicação e o resultado dá " + multiplicacao + ".");
            }
            Console.ReadKey();
        }
    }
}
