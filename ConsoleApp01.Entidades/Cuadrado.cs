using System.Text;

namespace ConsoleApp01.Entidades
{
    public class Cuadrado
    {
        private double lado;

        public Cuadrado(double medidaLado)
        {
            lado = medidaLado;
        }

        public double Lado { get => lado; set => lado = value; }
        public double GetPerimetro() => Lado * 4;
        public double GetSuperficie() => Math.Pow(Lado, 2);

        public string ImprimirInformacion()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Cuadrado con lado de " + lado);
            sb.AppendLine("Perímetro: " + GetPerimetro());
            sb.AppendLine("Área: " + GetSuperficie());
            return sb.ToString();
        }

        public bool Validar()=>Lado> 0;

        public string CambiarTamanio(double nuevoTamanio)
        {
            if (nuevoTamanio>0 && nuevoTamanio!=Lado)
            {
                if (nuevoTamanio<Lado)
                {
                    var diferencia = Lado - nuevoTamanio;
                    Lado = nuevoTamanio;
                    return $"Se achicó en {diferencia}";
                }
                else
                {
                    var diferencia = nuevoTamanio - Lado;
                    Lado = nuevoTamanio;
                    return $"Se aumentó en {diferencia}";
                }
            }
            else
            {
                return "Valor de aumento no válido!!!";
            }
        }
    }
}
