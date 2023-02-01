using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Tipos de datos

            int num1 = 214748364;
            uint valo1 = 0;
            int num2 = 5, num3 = 6;
            long largas = 21474836488888;
            ulong ularga = 2222;
            byte b = 100;
            sbyte s = 23;
            int? total = null;

            float flotante = 25.36f;
            double doble = 100.5d;
            decimal dec = 56.65m;

            bool boleana = new bool();

            // var & dynamic

            var variable = 20.03f;
            variable = 20;

            dynamic dinamico = "Hoy es un buen dia";
            dinamico = 20.699f;
            dinamico = true;

            
            var persona = new { NOMBRE = "Miguel", APELLIDO = "Rios", Edad = 30 };

            Console.WriteLine($"{persona.NOMBRE} {persona.APELLIDO} {persona.Edad}");

            string nombre1 = "Carolina";
            string nombre2 = "Luis Carlos";
            String apellido1 = "Rodriguez";
            String apellido2 = "Morera";
            char caracter = 'c';

            Console.WriteLine("Total: " + total + "Boleana: " + boleana);
            Console.WriteLine(nombre1 + " " + apellido1);
            Console.WriteLine(nombre2 + " " + apellido2);

            //Desplegar con parametros
            Console.WriteLine("La estudiante se llama {0} {1}", nombre1, apellido1);
            //Desplegar con interpolaion
            Console.WriteLine($"El estudiante se llama {nombre2} {apellido2}\r\n");
            

            Console.WriteLine("Digite un numero:");
            Console.ForegroundColor = ConsoleColor.White;
            num1 = (int)float.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            num2 = (int)float.Parse(Console.ReadLine());
            total = num1 + num2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"La sumatoria de {num1} + {num2} es {total} ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La resta de {num1} - {num2} es {num1 - num2} ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"La multiplicacion de {num1} * {num2} es {num1 * num2} ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"La division de {num1} / {num2} es {num1 / num2} \r\n");
            */

            // Datos
            int[] edad = new int[] {20, 22, 33};
            float[] salarios = new float[] {200, 300, 150};
            String[] musico = new String[3];
            musico[0] = "Anthony";
            musico[1] = "Helen";
            musico[2] = "Jose";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Salarios de los músicos:");
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Ciclo For
            for (int i = 0; i < musico.Length; i++)
            {
                float IVA = 0;
                IVA = (float)(salarios[i]*0.13);
                Console.WriteLine($"{musico[i]}, edad {edad[i]}, salario {salarios[i]}$. IVA: {IVA}, total de {salarios[i]-IVA}$.");
            }

            Console.ReadLine();

        }
    }
}
