using ConsoleApp04.Entidades;

namespace ConsoleApp04.Testing
{
    [TestClass]
    public class TemperaturaTesting
    {
        [TestMethod]
        public void CrearTemperatura_TodoOK()
        {
            //arrange
            double valor = 25.4;

            //act
            Temperatura t=new Temperatura(valor);
            //assert
            Assert.AreEqual(valor,t.Celsius);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CrearTemperatura_DebeArrojarExcepcion()
        {
            //arrange
            double valor =-81;

            //act
            Temperatura t = new Temperatura(valor);

        }
    }
}