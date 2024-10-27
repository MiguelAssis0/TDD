using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scr.Controllers;
using Xunit;

namespace tests.Tests
{
    public class Calculadora
    {
        
        CalculadoraController calc = new CalculadoraController();
        [Theory]
        [InlineData(1, 2, 3)]
        public void SomarDoisNumeros(int n1,int n2, int value)
        {
            int result = calc.Somar(n1,n2);
            Assert.Equal(value, result);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void SubtrairDoisNumeros(int n1,int n2, int value)
        {
            int result = calc.Subtrair(n1,n2);
            Assert.Equal(value, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        public void MultiplicarDoisNumeros(int n1,int n2, int value)
        {
            int result = calc.Multiplicar(n1,n2);
            Assert.Equal(value, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        public void DividirDoisNumeros(int n1,int n2, int value)
        {
            int result = calc.Dividir(n1,n2);
            Assert.Equal(value, result);
        }

        [Fact]
        public void TestarDivisaoPor0()
        {
            Assert.Throws<DivideByZeroException>(
                ()=> calc.Dividir(3,0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {

            calc.Somar(1,2);

            var lista = calc.Historico(); 

            Assert.InRange(lista.Count, 0,3);
        }
    }
    //Como fazer métodos assincronos xUnit
}