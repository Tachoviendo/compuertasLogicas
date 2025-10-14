namespace Library.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using Library;

    public class CompuertaTests
    {
        
        [Test]
        public void And_MixedInputs_Returns0()
        {
            var inputs = new List<int> { 1, 0 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.AND);
            int result = c.Resultado();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void And_AllOnes_Returns1()
        {
            var inputs = new List<int> { 1, 1, 1 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.AND);
            int result = c.Resultado();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void And_AllZeros_Returns0()
        {
            var inputs = new List<int> { 0, 0 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.AND);
            int result = c.Resultado();
            Assert.AreEqual(0, result);
        }

        
        [Test]
        public void Or_MixedInputs_Returns1()
        {
            var inputs = new List<int> { 1, 0 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.OR);
            int result = c.Resultado();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Or_AllZeros_Returns0()
        {
            var inputs = new List<int> { 0, 0, 0 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.OR);
            int result = c.Resultado();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Or_AllOnes_Returns1()
        {
            var inputs = new List<int> { 1, 1 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.OR);
            int result = c.Resultado();
            Assert.AreEqual(1, result);
        }

        
        [Test]
        public void Not_InputOne_ReturnsZero()
        {
            var inputs = new List<int> { 1 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.NOT);
            int result = c.Resultado();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Not_InputZero_ReturnsOne()
        {
            var inputs = new List<int> { 0 };
            var c = new Compuerta(inputs, Compuerta.tiposCompuerta.NOT);
            int result = c.Resultado();
            Assert.AreEqual(1, result);
        }
    }
}