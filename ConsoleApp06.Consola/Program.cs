using ConsoleApp06.Entidades;

try
{
	Punto punto = new Punto(10, 5);
	Circunferencia circ = new Circunferencia(10, punto);
    Console.WriteLine($"Perímetro: {circ.GetPerimetro()}");
    Console.WriteLine($"Superficie:{circ.GetArea()}");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message); 
}