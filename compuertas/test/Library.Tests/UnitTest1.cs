namespace Library.Tests;

using NUnit.Framework;
using System.Collections.Generic;
using Library;

public class Tests1
{
    private List<int> inputsAND_OR;
    private List<int> inputNOT;
    private Compuerta cAND;
    private Compuerta cOR;
    private Compuerta cNOT;

    [SetUp]
    public void Setup()
    {
        // Se inicializan los campos de la clase, no variables locales
        this.inputsAND_OR = new List<int> { 1, 0 };
        this.inputNOT = new List<int> { 1 };

        // Se inicializan las compuertas con los campos
        this.cAND = new Compuerta(this.inputsAND_OR, Compuerta.tiposCompuerta.AND);
        this.cOR = new Compuerta(this.inputsAND_OR, Compuerta.tiposCompuerta.OR);
        
        // Se corrige la inicialización de la compuerta NOT
        this.cNOT = new Compuerta(this.inputNOT, Compuerta.tiposCompuerta.NOT);
    }

    [Test]
    public void TestOR()
    {
        int result = this.cOR.Resultado();
        Assert.AreEqual(1, result); // 1 OR 0 es igual a 1
    }

    [Test]
    public void TestAND()
    {
        int result = this.cAND.Resultado();
        Assert.AreEqual(0, result); // 1 AND 0 es igual a 0
    }
    
    // Se agrega el atributo [Test] para que NUnit ejecute la prueba
    [Test]
    public void TestNOT()
    {
        int result = this.cNOT.Resultado();
        Assert.AreEqual(0, result); // La negación de 1 es 0
    }
}
