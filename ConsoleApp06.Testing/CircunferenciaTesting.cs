using ConsoleApp06.Entidades;

namespace ConsoleApp06.Testing
{
    [TestClass]
    public class CircunferenciaTesting
    {
        [TestMethod]
        public void Crear_CircunferenciaOK()
        {
            //arrange
            Punto punto = new Punto(0, 1);
            int radio = 10;

            //act
            Circunferencia circ = new Circunferencia(radio, punto);
            //assert
            Assert.AreEqual(radio,circ.Radio);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Crear_CircunferenciaExcepcion()
        {
            //arrange
            Punto punto = new Punto(0, 1);
            int radio = -10;

            //act
            Circunferencia circ = new Circunferencia(radio, punto);
            
        }
        [TestMethod]
        public void GetPerimetroOK()
        {
            //arrange
            Punto punto = new Punto(0, 1);
            int radio = 10;

            //act
            Circunferencia circ = new Circunferencia(radio, punto);
            var perimetro = 2 * Math.PI * circ.Radio;
            //Assert
            Assert.AreEqual(perimetro, circ.GetPerimetro());
        }

        [TestMethod]
        public void GetAreaOK()
        {
            //arrange
            Punto punto = new Punto(0, 1);
            int radio = 10;

            //act
            Circunferencia circ = new Circunferencia(radio, punto);
            var area = Math.PI * Math.Pow(circ.Radio, 2);
            //Assert
            Assert.AreEqual(area, circ.GetArea());
        }
        [TestMethod]
        public void EstaDentroVerdadero()
        {
            //arrange
            Punto punto = new Punto(0, 1);
            int radio = 10;

            //act
            Circunferencia circ = new Circunferencia(radio, punto);
            Punto otroPunto = new Punto(-5, -4);
            //Assert
            Assert.IsTrue(circ.EstaDentro(otroPunto));
        }
        [TestMethod]
        public void EstaDentroFalso()
        {
            //arrange
            Punto punto = new Punto(0, 1);
            int radio = 10;

            //act
            Circunferencia circ = new Circunferencia(radio, punto);
            Punto otroPunto = new Punto(-40,-20);
            //Assert
            Assert.IsFalse(circ.EstaDentro(otroPunto));
        }

        [TestMethod]
        public void EstaContenidaVerdaderoMismoCentroRadioMenor()
        {
            //arrange
            var coordX1 = 0;
            var coordY1 = 0;
            var radio1 = 10;

            var radio2 = 5;
            var coordX2 = 0;
            var coordY2 = 0;

            //Act
            var circ1 = new Circunferencia(radio1, new Punto(coordX1, coordY1));
            var circ2 = new Circunferencia(radio2, new Punto(coordX2, coordY2));
            //Assert
            Assert.IsTrue(circ2.EstaContenida(circ1));
        }
        [TestMethod]
        public void EstaContenidaVerdaderoDistintoCentroRadioMenor()
        {
            //arrange
            var coordX1 = 0;
            var coordY1 = 0;
            var radio1 = 10;

            var radio2 = 5;
            var coordX2 = 1;
            var coordY2 = 1;

            //Act
            var circ1 = new Circunferencia(radio1, new Punto(coordX1, coordY1));
            var circ2 = new Circunferencia(radio2, new Punto(coordX2, coordY2));
            //Assert
            Assert.IsTrue(circ2.EstaContenida(circ1));
        }

        [TestMethod]
        public void EstaContenidaFalsoMismoCentroRadioMayor()
        {
            //arrange
            var coordX1 = 0;
            var coordY1 = 0;
            var radio1 = 10;

            var radio2 = 15;
            var coordX2 = 0;
            var coordY2 = 0;

            //Act
            var circ1 = new Circunferencia(radio1, new Punto(coordX1, coordY1));
            var circ2 = new Circunferencia(radio2, new Punto(coordX2, coordY2));
            //Assert
            Assert.IsFalse(circ2.EstaContenida(circ1));
        }
        [TestMethod]
        public void EstaContenidaFalsoDistintoCentroRadioMayor()
        {
            //arrange
            var coordX1 = 0;
            var coordY1 = 0;
            var radio1 = 10;

            var radio2 = 15;
            var coordX2 = 1;
            var coordY2 = 1;

            //Act
            var circ1 = new Circunferencia(radio1, new Punto(coordX1, coordY1));
            var circ2 = new Circunferencia(radio2, new Punto(coordX2, coordY2));
            //Assert
            Assert.IsTrue(circ2.EstaContenida(circ1));
        }

    }
}