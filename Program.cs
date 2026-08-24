using System;

bool continuar = true;

while (continuar)
{
    double primeraEntrada = LeerNumero("Ingresa el primer numero: ");
    double segundaEntrada = LeerNumero("Ingresa el segundo numero: ");

    Console.WriteLine("\nSelecciona una opcion");
    Console.WriteLine("1. Sumar | 2. Restar | 3. Multiplicar | 4. Dividir | 5. Salir");

    char opcion = Console.ReadKey(true).KeyChar;
    try
    {
        switch (opcion)
        {
            case '1':
                Console.WriteLine("La Suma es: " + Sumar(primeraEntrada, segundaEntrada));
                break;
            case '2':
                Console.WriteLine("La Resta es: " + Restar(primeraEntrada, segundaEntrada));
                break;
            case '3':
                Console.WriteLine("La Multiplicacion es: " + Multiplicar(primeraEntrada, segundaEntrada));
                break;
            case '4':
                Console.WriteLine("La division es: " + Dividir(primeraEntrada, segundaEntrada));
                break;
            case '5':
                Console.WriteLine("Hasta pronto!");
                continuar = false;
                break;
            default:
                Console.WriteLine("Opcion no válida");
                break;

        }
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("No se puede dividir por cero");
    }
}




//Funciones
static double LeerNumero(string mensaje)
{
    double numero;
    Console.Write(mensaje);
    string entrada = Console.ReadLine();
    while (!double.TryParse(entrada, out numero))
    {
        Console.WriteLine("Debe ingresar un número");
        Console.Write(mensaje);
        entrada = Console.ReadLine();
    }

    return numero;
}

static double Sumar(double a, double b)
{
    return a + b;
}

static double Multiplicar(double a, double b)
{
    return a * b;
}

static double Restar(double a, double b)
{
    return a - b;
}

static double Dividir(double a, double b)
{

    if (b == 0)
    {
        throw new DivideByZeroException("No se puede dividir entre 0");
    }

    return a / b;

}