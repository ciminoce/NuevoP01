namespace ConsoleApp06.Entidades
{
    public class Circunferencia
    {
        public Circunferencia(int radio, Punto centro)
        {
            if (radio>0)
            {
                Radio = radio;
                Centro = centro;

            }
            else
            {
                throw new ArgumentException("El radio tiene que ser mayor a 0");
            }
        }

        public int Radio { get; set; }
        public Punto Centro { get; set; } = null!;

        public double GetPerimetro()=>2*Math.PI*Radio;
        public double GetArea() => Math.PI * Math.Pow(Radio, 2);

        public bool EstaDentro(Punto otroPunto)
        {
            return Math.Sqrt(Math.Pow(Centro.CoordX-otroPunto.CoordX,2)
                +Math.Pow(Centro.CoordY-otroPunto.CoordY,2))<=Radio;
        }
        private double CalcularDistanciaEntreCentros(Circunferencia otraCircunferencia)
        {
            return Math.Sqrt(Math.Pow(Centro.CoordX - otraCircunferencia.Centro.CoordX, 2) 
                + Math.Pow(Centro.CoordY - otraCircunferencia.Centro.CoordY, 2));
        }

        public bool EstaContenida(Circunferencia otraCirc)
        {
            double distanciaEntreCentros = CalcularDistanciaEntreCentros(otraCirc);
            return distanciaEntreCentros + Radio <= otraCirc.Radio;
        }
        public string GetEcuacionGeneral()
        {
            var D = -2 * this.Centro.CoordX;
            var E = -2 * this.Centro.CoordY;
            var F = Math.Pow(this.Centro.CoordX, 2) +
                Math.Pow(this.Centro.CoordY, 2) -
                Math.Pow(this.Radio, 2);
            return $"x2 + y2 + Dx + Ey + F=0";
        }
    }
}
