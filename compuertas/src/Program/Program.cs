namespace Program;
using Library;
class Program
{
    static void Main(string[] args)
    {
        List<int> entradasAND = new List<int> { 1, 0 };
        Compuerta cAND = new Compuerta(entradasAND, Compuerta.tiposCompuerta.AND);
        int res1 = cAND.Resultado();
        
        List<int> entradasOR = new List<int> { 1, 0 };
        Compuerta cOR = new Compuerta(entradasOR, Compuerta.tiposCompuerta.OR);
        int res2 = cOR.Resultado();

        List<int> entradaNOT = new List <int> {1};
        Compuerta cNOT = new Compuerta(entradaNOT, Compuerta.tiposCompuerta.NOT);
        int res3 = cNOT.Resultado();

        Console.WriteLine($"Entradas: [{cAND.getEntrada()}] Resultado de AND: {res1} \nEntradas : [{cOR.getEntrada()}] Resultado de OR: {res2} \nEntradas : [{cNOT.getEntrada()}] Resultado de NOT: {res3}");

        

    }
    
}
