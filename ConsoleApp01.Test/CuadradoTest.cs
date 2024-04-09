using ConsoleApp01.Entidades;

namespace ConsoleApp01.Test
{
    [TestClass]
    public class CuadradoTest
    {
        [TestMethod]
        public void GetPerimetro_DeberiaCalcularCorrectamente()
        {
            //arrange
            double medidaLado = 5;
            Cuadrado c=new Cuadrado(medidaLado);

            //act
            double perimetro=c.GetPerimetro();

            //assert
            Assert.AreEqual(20, perimetro);
        }
        [TestMethod]
        public void GetSuperficie_DeberiaCalcularCorrectamente()
        {
            //arrange
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            double superficie = c.GetSuperficie();

            //assert
            Assert.AreEqual(25, superficie);

        }
        [TestMethod]
        public void InfoCuadrado_DeberiaMostrarInformacionCorrectamente()
        {
            //arrange
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            string info=c.ImprimirInformacion();

            //assert
            StringAssert.Contains(info, "Cuadrado con lado de 5");
            StringAssert.Contains(info, "Perímetro: 20");
            StringAssert.Contains(info, "Área: 25");

        }
        [TestMethod]
        public void SetLado_DeberiaAsignarCorrectamente()
        {
            //arrange
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            c.Lado=10;

            //assert
            Assert.AreEqual(10,c.Lado);

        }
        [TestMethod]
        public void Validar_DeberiaRetornarVerdadero()
        {
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            c.Lado = 10;

            //assert
            Assert.IsTrue(c.Validar());

        }

        [TestMethod]
        public void Validar_DeberiaRetornarFalso()
        {
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            c.Lado = -10;

            //assert
            Assert.IsFalse(c.Validar());

        }
        [TestMethod]
        public void CambiarTamanio_DeberiaRetornar1()
        {
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            double nuevoTamanio=6;
            //assert
            StringAssert.Contains("Se aumentó en 1", c.CambiarTamanio(nuevoTamanio));

        }
        [TestMethod]
        public void CambiarTamanio_DeberiaRetornarAchico1()
        {
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            double nuevoTamanio = 4;
            //assert
            StringAssert.Contains("Se achicó en 1", c.CambiarTamanio(nuevoTamanio));

        }
        [TestMethod]
        public void CambiarTamanio_DeberiaRetornarMensajeError()
        {
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            double nuevoTamanio =0;
            //assert
            StringAssert.Contains("Valor de aumento no válido!!!", c.CambiarTamanio(nuevoTamanio));

        }

    }
}