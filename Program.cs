using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SWITCH

            //var data = 1;
            //var result = data switch
            //{
            //    1 => "henry",
            //    2 => "torres"
            //};
            //Console.WriteLine($"Hola {result}");

            //var (a, b, opcion) = (2, 6, "*");
            //var result = opcion switch
            //{
            //    "+" => a + b,
            //    "-" => a - b,
            //    "*" => a * b
            //};
            //Console.WriteLine($"Resultado {result}");

            //WHILE

            var valor = true;
            var count = 1;

            while (valor) 
            { 
                if(count == 10)
                {
                    valor = false;
                }
                count++;
                //Console.WriteLine($"Ejecucion {count}");
            }
            valor = true;
            count = 1;
            do
            {
                if (count == 10)
                {
                    valor = false;
                }
                count++;
                Console.WriteLine($"Ejecucion {count}");
            } while (valor);

            Console.ReadLine();
        }
    }
}
