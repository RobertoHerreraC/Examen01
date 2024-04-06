

string ValidarNumero()
{
    Console.Write("Ingrese un número: ");
    string resultado = "";
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero > 0)
    {
        resultado = "El número es positivo.";
    }
    else if (numero < 0)
    {
        resultado = "El número es negativo.";
    }
    else
    {
        resultado = "El número es cero.";
    }

    return resultado;
}


void ProcesarDiaSemana()
{
    Console.Write("Ingrese un día de la semana: ");
    int dia = Convert.ToInt32(Console.ReadLine());
    string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
    if (dia >= 1 && dia <= 7)
    { 
        Console.WriteLine("El día seleccionado es: " +dias[dia - 1]);
    }
    else
    {
        Console.WriteLine("Número de día no válido.");
    }
}


int SumarPrimerosNumeros()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++)
    {
        suma += i;
    }
    return suma;
}


void ImprimirNumeros()
{
    Console.Write("Imprimir hasta: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}

double CalcularAreaCirculo()
    {
    Console.Write("Ingrese el radio del círculo: ");
    double radio = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}

void MostrarArreglo()
{
    int[] arreglo = { 100, 451, 710, 400, 459 };
    Console.WriteLine("Datos del arreglo:");
    for (int i = 0; i<  arreglo.Length; i++)
    {
        Console.WriteLine(arreglo[i]);
    }
}


void MostrarNombres()
{
    List<string> nombres = new List<string> { "Marcos", "Jose", "Juan", "Gianela" };
    Console.WriteLine("Nombres de personas:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }
}




bool salir = false;
while (!salir)
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1.Determinar si un número es positivo, negativo o cero.");
    Console.WriteLine("2.Mensaje según el día de la semana.");
    Console.WriteLine("3.Suma de los primeros 100 números naturales.");
    Console.WriteLine("4.Imprimir números desde 1 hasta n.");
    Console.WriteLine("5.Calcular el área de un círculo.");
    Console.WriteLine("6.Mostrar elementos de un arreglo.");
    Console.WriteLine("7.Mostrar nombres de personas.");
    Console.WriteLine("8. Salir.");
    Console.Write("Seleccione una opción: ");

    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine(ValidarNumero());
            break;
        case 2:
            ProcesarDiaSemana();
            break;
        case 3:
            Console.WriteLine("La suma de los primeros 100 números naturales es: "+ SumarPrimerosNumeros());
            break;
        case 4:
            ImprimirNumeros();
            break;
        case 5:
            Console.WriteLine("El área del círculo es: "+ CalcularAreaCirculo());
            break;
        case 6:
            MostrarArreglo();
            break;
        case 7:
            MostrarNombres();
            break;
        case 8:
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
    Console.WriteLine();
}