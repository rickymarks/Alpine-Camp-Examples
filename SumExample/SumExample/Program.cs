using System;

namespace SumExample
{
    class Program
    {
        public const int MAXIMUM_NUMBERS = 15;
        static void Main(string[] args)
        {
            bool tryAgain = false;

            do
            {
                int selectedOption = WriteMenu();

                switch (selectedOption)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                }

                Console.WriteLine("Desea intentar otra opción? Y/N");
                string option = Console.ReadLine();

                if(option == "Y")
                {
                    tryAgain = true;
                }
                else
                {
                    tryAgain = false;
                }


            } while (tryAgain);

        }

        public static int WriteMenu()
        {

            int selectedOption = 0;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Favor seleccione cualquiera de las siguientes opciones: ");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("---------------------------------------------------------");

            selectedOption = Convert.ToInt32(Console.ReadLine());


            return selectedOption;
        }
        public static void Sumar()
        {
            Console.WriteLine("-------------------MODULO SUMA---------------------------");

            int numberAmounts = 0;

            int[] numbers = new int[MAXIMUM_NUMBERS];

            int sum = 0;

            Console.WriteLine($"Cuantos números desean sumar (máximo {MAXIMUM_NUMBERS}): ");
            numberAmounts = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < numberAmounts; i++)
            {
                Console.WriteLine($"Entre el numero #{i}:");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"El valor total es: {sum}");
            Console.WriteLine("---------------------------------------------------------");

        }
        public static void Restar()
        {
            Console.WriteLine("-------------------MODULO RESTA--------------------------");
            int numberAmounts = 0;

            int[] numbers = new int[MAXIMUM_NUMBERS];

            int sum = 0;

            Console.WriteLine($"Cuantos números desean restar (máximo {MAXIMUM_NUMBERS}): ");
            numberAmounts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberAmounts; i++)
            {
                Console.WriteLine($"Entre el numero #{i}:");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                sum -= numbers[i];
            }

            Console.WriteLine($"El valor total es: {sum}");
            Console.WriteLine("---------------------------------------------------------");
        }
        public static void Multiplicar()
        {
            Console.WriteLine("-------------------MODULO MULTIPLICACION-----------------");
            int a = 0, b = 0, c = 0;

            Console.WriteLine("Entre el primer número: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Entre el segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a * b;

            Console.WriteLine($"El resultado de la multiplicación es: {c}");
            Console.WriteLine("---------------------------------------------------------");
        }
        public static void Dividir()
        {
            Console.WriteLine("-------------------MODULO DIVISION-----------------------");
            int a = 0, b = 0, c = 0;

            Console.WriteLine("Entre el primer número: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Entre el segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a / b;

            Console.WriteLine($"El resultado de la división es: {c}");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
