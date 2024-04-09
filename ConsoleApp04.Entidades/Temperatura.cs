namespace ConsoleApp04.Entidades
{
    public class Temperatura
    {

        private double celsius;

        public double Celsius
        {
            get { return celsius; }
            set { celsius = value; }
        }
        public Temperatura(double valorTemperatura)
        {
            if (valorTemperatura<-80 || valorTemperatura>80)
            {
                throw new ArgumentOutOfRangeException(@"El valor de la
                        temperatura ingresada 
                        no es válido [-80,80]");
            }
            celsius=valorTemperatura;
        }

        

        public double GetFahrenheit()
        {
            return 1.8 * Celsius + 32;
        }

        public double GetKelvin()
        {
            return Celsius + 273.44;
        }
    }
}
