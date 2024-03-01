
//ejercicio 1
using System;

class Program
{
    static void Main(string[] args)
    {              //ejercicio 1
        int numero;

        do
        {
            Console.WriteLine("Ingrese un número" + " ( 0 para salir ):");
            string input = Console.ReadLine();


            if (!int.TryParse(input, out numero))
            {
                Console.WriteLine("ingrese un número entero positivo.");
                continue;
            }

            if (numero == 0)
            {
                Console.WriteLine("precione cualquier tecla para salir");
                break;
            }

            if (numero < 0)
            {
                Console.WriteLine("El número debe ser positivo.");
                continue;
            }


            Console.WriteLine("Menú:");
            Console.WriteLine("1. Calcular el factorial del número.");
            Console.WriteLine("2. Calcular la raíz cuadrada del número.");
            Console.WriteLine("3. Salir del programa.");


            Console.WriteLine("Seleccione una opción:");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    long factorial = CalcularFactorial(numero);
                    Console.WriteLine($"El factorial de {numero} es: {factorial}");
                    break;
                case "2":
                    double raizCuadrada = Math.Sqrt(numero);
                    Console.WriteLine($"La raíz de {numero} es: {raizCuadrada}");
                    break;
                case "3":
                    Console.WriteLine("Precione cualquier tecla para salir");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
        } while (true);
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0)
            return 1;

        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

}

//--------------------------------------------------------------------------------------------------------------------------------


//Ejercicio 2

using System;

class Program
{
    static void Main(string[] args)
    {
        // ejercicio 2
        int numero1, numero2;
        char operador;
        double resultado = 0;

        Console.WriteLine("Ingrese el primer número entero:");
        string inputNumero1 = Console.ReadLine();


        while (!int.TryParse(inputNumero1, out numero1))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero:");
            inputNumero1 = Console.ReadLine();
        }


        Console.WriteLine("Ingrese el segundo número entero:");
        string inputNumero2 = Console.ReadLine();


        while (!int.TryParse(inputNumero2, out numero2))
        {
            Console.WriteLine("Error 117: ingrese un número entero:");
            inputNumero2 = Console.ReadLine();
        }


        Console.WriteLine("Ingrese el operador:   + , - , * , / ):");
        string inputOperador = Console.ReadLine();


        while (!char.TryParse(inputOperador, out operador) || !EsOperadorValido(operador))
        {
            Console.WriteLine("Error 001,  ingrese los signos del operador deseado (+, -, *, /):");
            inputOperador = Console.ReadLine();
        }


        switch (operador)
        {
            case '+':
                resultado = numero1 + numero2;
                break;
            case '-':
                resultado = numero1 - numero2;
                break;
            case '*':
                resultado = numero1 * numero2;
                break;
            case '/':
                if (numero2 != 0)
                {
                    resultado = (double)numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("syntaxis error.");
                    return;
                }
                break;
        }


        Console.WriteLine($" {numero1} {operador} {numero2} es: {resultado}");
    }

    static bool EsOperadorValido(char operador)
    {
        return operador == '+' || operador == '-' || operador == '*' || operador == '/';
    }
}


//---------------------------------------------------------------------------------------------------------------------------


//Ejercicio 3


using System;

class Program
{
    //ejercicio 3
    static void Main(string[] args)
    {

        Console.WriteLine("  ¿Del 1 al 10 que tablas le gustaria repasar?:");
        string inputNumero = Console.ReadLine();


        int numero;
        while (!int.TryParse(inputNumero, out numero))
        {
            Console.WriteLine("Error ingrese un numero del 1 al 10:");
            inputNumero = Console.ReadLine();
        }


        Console.WriteLine($"Tabla es {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

//-------------------------------------------------------------------------------------------------


//Ejercicio 4
using System;

class Program
{
    //ejercicio 4 y mi favorito
    static void Main(string[] args)
    {

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        Console.WriteLine("Adivina el Número secreto entre 1 y 100 ");

        int intentos = 0;
        int intentoUsuario;

        do
        {
            Console.WriteLine("Intentalo! ¿Cual es el Número?");
            string input = Console.ReadLine();


            while (!int.TryParse(input, out intentoUsuario) || intentoUsuario < 1 || intentoUsuario > 100)
            {
                Console.WriteLine("ingrese un número entre 1 y 100:");
                input = Console.ReadLine();
            }


            intentos++;


            if (intentoUsuario < numeroSecreto)
            {
                Console.WriteLine("Fallaste! es mayor.");
            }
            else if (intentoUsuario > numeroSecreto)
            {
                Console.WriteLine("Fallaste! es menor.");
            }
            else
            {
                Console.WriteLine($"¡Felicidades! Has adivinado  {numeroSecreto} en {intentos} intentos.");
                break;
            }

        } while (true);
    }
}
