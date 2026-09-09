// --------------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA

// Muestra en la consola el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_3");

// Muestra el título que describe lo que realiza el programa.
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");

// Deja una línea en blanco para separar visualmente el encabezado.
Console.WriteLine();

// --------------------------------------------------------------------
// ENTRADAS DE DATOS

Console.Write("Ingrese la primera calificación: ");

double calificacion1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la segunda calificación: ");

double calificacion2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tercera calificación: ");

double calificacion3 = Convert.ToDouble(Console.ReadLine());

// --------------------------------------------------------------------
// OPERACIONES

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;

// --------------------------------------------------------------------
// SALIDAS DE DATOS

Console.WriteLine();

Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");

if (promedio >= 90 && promedio <= 100)
{
    Console.WriteLine("Excelente");
}
else if (promedio >= 80 && promedio <= 89)
{
    Console.WriteLine("Alumno Bueno");
}
else if (promedio >= 70 && promedio <= 79)
{
    Console.WriteLine("Alumno Regular");
}
else if (promedio >= 60 && promedio <= 69)
{
    Console.WriteLine("Requiere Apoyo");
}
else if (promedio >= 10 && promedio <= 59)
{
    Console.WriteLine("Alumno Deficiente");
}
else if (promedio >= 0 && promedio <= 9)
{
    Console.WriteLine("Baja Definitiva");
}