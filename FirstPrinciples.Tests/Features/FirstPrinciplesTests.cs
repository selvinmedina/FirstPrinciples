using FirstPrinciples.Console.Features;
using FluentAssertions;
using FluentAssertions.Extensions;
using NSubstitute;
using static System.Console;

namespace FirstPrinciples.Tests.Features
{
    public class FirstPrinciplesTests
    {
        #region Fast
        [Fact]
        public void Fast()
        {
            // Arrange
            var procesadorDeDatos = new ProcesadorDeDatos();

            // Act
            var procesoLento = procesadorDeDatos.ProcesarTransaccion;

            // Assert
            procesoLento.ExecutionTime().Should().BeLessThanOrEqualTo(200.Milliseconds());

        }

        #endregion

        #region Isolated/Independent
        int a = 1;
        int b = 2;

        private int ultimoResultado = 0;

        readonly Calculadora calculadora = new Calculadora();

        [Fact]
        public void Sumar_Debe_Retornar_Suma()
        {
            // Arrange


            // Act
            ultimoResultado = calculadora.Sumar(a, b);

            // Assert
            ultimoResultado.Should().Be(3);
        }

        [Fact]
        public void Restar_Debe_Retornar_Resta()
        {
            // Arrange


            // Act
            ultimoResultado = calculadora.Restar(a, b);

            // Assert
            ultimoResultado.Should().Be(-1);
        }

        [Fact]
        public void Multiplicar_Debe_Retornar_Multiplicacion()
        {
            // Arrange


            // Act
            ultimoResultado = calculadora.Multiplicar(a, b);

            // Assert
            ultimoResultado.Should().Be(2);
        }

        [Fact]
        public void Dividir_Debe_Retornar_Division()
        {
            // Arrange  

            // Act
            ultimoResultado = calculadora.Dividir(a, b);

            // Assert
            ultimoResultado.Should().Be(0);
        }
        #endregion

        #region Repeatable

        [Fact]
        public void Convertir_Dolares_A_Lempiras()
        {
            // Arrange
            var conversorDeMoneda = Substitute.For<ConversorDeMoneda>();

            conversorDeMoneda.Convertir(100, "USD", "HNL").Returns(2500);

            // Act
            var resultado = conversorDeMoneda.Convertir(100, "USD", "HNL");

            // Assert
            resultado.Should().Be(2500);
        }

        #endregion

        #region Self-Checking
        // Prueba no autovalidable

        [Fact]
        public void Sumar_DebeRetornarSumaCorrecta()
        {
            var calculadoraa = new Calculadora();
            var resultado = calculadoraa.Sumar(2, 3);
            WriteLine("El resultado es: " + resultado); // Requiere inspección manual
        }

        [Fact]
        public void Self_Checking_Sumar_DebeRetornarSumaCorrecta()
        {
            var calculadoraa = new Calculadora();
            var resultado = calculadoraa.Sumar(2, 3);
            resultado.Should().Be(5); // La prueba ahora se valida automáticamente
        }

        // Prueba autovalidable
        #endregion

        #region Through/Timely
        [Fact]
        public void Dividir_DivisionPorCero_DebeLanzarExcepcion()
        {
            var calculadoraa = new Calculadora();
            var act = () => calculadoraa.Dividir(10, 0);
            act.Should().Throw<DivideByZeroException>();
        }
        #endregion

    }
}

