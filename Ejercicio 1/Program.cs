//Durante una prueba se realiza ocho mediciones de corriente de un actuador eléctrico. Diseñe un programa que utilice
//un ciclo para introducir las ocho mediciones. Cada medición deberá clasificarse de la siguiente manera:
Console.WriteLine("Ejercicio 4");                                           //Numero de la practica
Console.WriteLine("Durante una prueba se realiza ocho mediciones de corriente de un actuador eléctrico. Diseñe un programa que utilice. un ciclo para introducir las ocho mediciones. Cada medición deberá clasificarse de la siguiente manera");           //Nombre del ejercicio
Console.WriteLine();

// Variables para contar los resultados
int normales = 0;
int sobrecorrientes = 0;
//aqui puse para cada uno dividido el if y else, para que al meter el valor muestre por divido
Console.Write("ingrese medición uno(A): ");
double medición = Convert.ToDouble(Console.ReadLine());
if (medición <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();

Console.Write("ingrese medición dos(A): ");
double medición2 = Convert.ToDouble(Console.ReadLine());
if (medición2 <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();

Console.Write("ingrese medición tres(A): ");
double medición3 = Convert.ToDouble(Console.ReadLine());
if (medición3 <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();

Console.Write("ingrese medición cuatro(A): ");
double medición4 = Convert.ToDouble(Console.ReadLine());
if (medición4 <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();

Console.Write("ingrese medición cinco(A): ");
double medición5 = Convert.ToDouble(Console.ReadLine());
if (medición5 <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();

Console.Write("ingrese medición seis(A): ");
double medición6 = Convert.ToDouble(Console.ReadLine());
if (medición6 <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();

Console.Write("ingrese medición siete(A): ");
double medición7 = Convert.ToDouble(Console.ReadLine());
if (medición7 <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();

Console.Write("ingrese medición ocho(A): ");
double medición8 = Convert.ToDouble(Console.ReadLine());
if (medición8 <= 5)
{
    Console.WriteLine("MEDICIÓN NORMAL");
    normales++;
}
else
{
    Console.WriteLine("SOBRECORRIENTE DETECTADA");
    sobrecorrientes++;
}
Console.WriteLine();
//aqui en esta parte defini la forma en al que iba a calcular el promedio total de las mediciones registradas
double Total = (medición + medición2 + medición3 + medición4 + medición5 + medición6 + medición7 + medición8) / 8;
//defino cuales son las interpretaciones de cada peticion
Console.WriteLine();
Console.WriteLine($"Cantidades de mediciones normales: {normales}");
Console.WriteLine($"Cantidad de sobrecorriente: {sobrecorrientes}");
Console.WriteLine($"Corriente promedio: {Total:F2}");

// Evaluacion general según el criterio solicitado
if (sobrecorrientes == 0)
{
    Console.WriteLine("Resultado general del actuador: Actuador aprobado");
}
else
{
    Console.WriteLine("Resultado general del actuador: Actuador requiere revision");
}