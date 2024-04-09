using ConsoleApp01.Entidades;
using Practico01.Shared;

var lado = ConsoleExtension.GetDouble("Ingrese el valor del lado del cuadrado:");
Cuadrado cuadrado = new Cuadrado(lado);
if (cuadrado.Validar())
{
	Console.WriteLine(cuadrado.ImprimirInformacion());

    var nuevoLado = ConsoleExtension.GetDouble("Ingrese el valor del nuevo lado:");
    Console.WriteLine(cuadrado.CambiarTamanio(nuevoLado));
}
else
{
    Console.WriteLine("Cuadrado no válido!!!");
}