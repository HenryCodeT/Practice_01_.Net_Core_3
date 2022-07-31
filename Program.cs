using System;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
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
                if (count == 10)
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
                //Console.WriteLine($"Ejecucion {count}");
            } while (valor);

            //string name1 = "henry";
            //string name2 = "samuel";
            //string name3 = name1;
            //name1 += name2;
            //Console.WriteLine($" Name 1 {name1}");
            //Console.WriteLine($" Name 3 {name3}");

            var nombre = (nombre1: "Henry", nombre2: "samuel");
            //Console.WriteLine($"Nombre: {nombre.nombre1}");
            //Console.WriteLine($"Nombre: {nombre.nombre2}");
            //Formato compuesto
            //Console.WriteLine("Nombre {1} nombre 2 {0}", nombre.nombre1, nombre.nombre2);

            var curso = "curso de c# desde 0";
            //Console.WriteLine("cadena {0}", curso.Substring(9,10));
            var sub = curso.Replace("desde 0", ".Net core");
            //Console.WriteLine("cadena {0}", sub);
            var buscar = curso.IndexOf("desde");
            var array = curso.ToCharArray();
            //Console.WriteLine(array);

            //foreach (var item in curso)
            //{
            //    Console.WriteLine(item);
            //}

            var names = new StringBuilder("Alex pagoada");
            //names[0] = 'a';
            names.Append(" joel");
            //Console.WriteLine(names.ToString());

            //TIPOS DE METODOS EN C#
            var datas = new Program();
            //datas.metodoPrivado();
            // datas.metodoPublico();
            var palabra = datas.metodoPrivadoString();

            Console.WriteLine(palabra);
            Console.ReadLine();
        }
        private void metodoPrivado()
        {
            Console.WriteLine("Hola");
            Console.ReadLine();
        }
        public void metodoPublico()
        {
            Console.WriteLine("Alex");
            Console.ReadLine();
        }
        private string metodoPrivadoString()
        {
            return "Henry torres";
        }
    }
}
