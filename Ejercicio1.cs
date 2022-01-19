using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    internal class Ejercicio1 : IEjercicio
    {
        public void Main()
        {

            Console.WriteLine("Ingrese una secuencia de caracteres terminada en punto");
            string text = Console.ReadLine() ?? throw new Exception("PEREJIL");
            var result = TienePa(text);

            Console.WriteLine($"el resultado es = {result}");
            
        }

        public bool TienePa(string text)
        {
            int index = 0;
            char current = text[index];
            var previous = 'a';
            string cadena = "";

            while (current != '.')
            {
            string ultimosDos = previous.ToString() + current.ToString();
                cadena += current;
                previous = text[index];
                index++;
                current = text[index];
              
                if (ultimosDos.ToString().Equals("pa", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }


    }//.ToString().Equals(" ", StringComparison.OrdinalIgnoreCase)
}
