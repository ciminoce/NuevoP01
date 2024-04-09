namespace Practico01.Shared
{
    public static class ConsoleExtension
    {
        public static double GetDouble(string mensaje)
        {
            double doubleVar = 0;
            bool seguir = true;
            do
            {
                Console.Write(mensaje);
                var stringVar= Console.ReadLine();
                if (!double.TryParse(stringVar, out doubleVar))
                {
                    Console.WriteLine("Número mal ingresado!!!");
                }
                else
                {
                    seguir = false;
                }

            } while (seguir);
            return doubleVar;
        }

    }
}
