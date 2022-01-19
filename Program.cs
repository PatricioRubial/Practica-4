namespace E1

{
    public class Program
    {
        private const int CountOfExcersises = 1;

        static void Main()
        {
            Console.WriteLine("BIENVENIDO!");

            Console.WriteLine("( 'En los siguientes ejercicios, en los casos que se" +
                              " debe escribir un módulo, decida si es más adecuado un procedimiento o una función.')");

            Console.WriteLine("Nota: Tenga en cuenta que cuando se deben resolver ejercicios para evaluar si una secuencia cumple con un determinado patrón," +
                                      " NO debe continuar el procesamiento cuando se verifique que el patrón ya no se cumple.");

            Console.WriteLine($"INGRESE UN numero de ejercicio entre 1 y {CountOfExcersises}");
            string text = Console.ReadLine() ?? throw new Exception("INGRESE UN numero de ejercicio POR FAVOR");

            var isAnInt = int.TryParse(text, out var result);

            while (isAnInt == false || result < 1 || result > CountOfExcersises)
            {
                Console.WriteLine("Numero invalido");
                Console.WriteLine($"INGRESE UN numero de ejercicio entre 1 y {CountOfExcersises}");
                text = Console.ReadLine() ?? throw new Exception("INGRESE UN numero de ejercicio POR FAVOR");
                isAnInt = int.TryParse(text, out result);
            }

            IEjercicio ejercicio;
            switch (result)
            {
                case 1:
                    ejercicio = new Ejercicio1();
                    break;
                default: throw new Exception("Numero de ejercicio Invalido");
            }

            ejercicio.Main();

      //     Escriba un módulo que lea una secuencia de caracteres terminada en punto, y retorne verdadero si en la secuencia aparece al menos una vez la 'p'
      //       seguida de la ‘a’, o que retorne falso en caso contrario.Nota: en caso de encontrar la subsecuencia ‘pa’ se debe dejar de procesar.


        }
    }
}