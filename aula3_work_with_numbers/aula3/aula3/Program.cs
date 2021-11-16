using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma");
            Console.WriteLine(5 + 8);
            Console.WriteLine("Subtração");
            Console.WriteLine(5 - 8);
            Console.WriteLine("Divisão");
            Console.WriteLine(8 / 4);
            Console.WriteLine("Multiplicação");
            Console.WriteLine(5 * 8);
            Console.WriteLine("Resto");
            Console.WriteLine(9 % 5);
            Console.WriteLine("Regras");
            Console.WriteLine(5 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine("Inteiros e Decimais");
            Console.WriteLine(5.0 + 2.5);
            Console.WriteLine(5 + 2.5);
            Console.WriteLine(5 / 2); //integer
            Console.WriteLine(5 / 2.0); //decimal
            Console.WriteLine("Variáveis");
            int num = 5;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
