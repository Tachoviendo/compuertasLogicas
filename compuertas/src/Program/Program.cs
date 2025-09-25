namespace Program
{
    using System.Collections.Generic; 
    using Library;

    class Program
    {
        public class GarageGate
        {
            public List<int> input;
            int a = 0;
            int b = 0;
            int c = 0;

            Compuerta andIzq;
            Compuerta andDer;
            Compuerta andFIN;
            Compuerta or;
            Compuerta notIzq;
            Compuerta notDer;

            public GarageGate(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void setInputs(int c, int b, int a){
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public string Calcular()
            {
                this.input = new List<int> { a, b };
                this.andIzq = new Compuerta(input, Compuerta.tiposCompuerta.AND);

                this.input = new List<int> { a };
                this.notIzq = new Compuerta(input, Compuerta.tiposCompuerta.NOT);

                this.input = new List<int> { b };
                this.notDer = new Compuerta(input, Compuerta.tiposCompuerta.NOT);

                this.input = new List<int> { notIzq.Resultado(), notDer.Resultado() };
                this.andDer = new Compuerta(input, Compuerta.tiposCompuerta.AND);

                this.input = new List<int> { andIzq.Resultado(), andDer.Resultado() };
                this.or = new Compuerta(input, Compuerta.tiposCompuerta.OR);

                this.input = new List<int> { or.Resultado(), c };
                this.andFIN = new Compuerta(input, Compuerta.tiposCompuerta.AND);

                return ($"Inputs: c({this.c}), b({this.b}), a({this.a}), Resultado = {andFIN.Resultado()}");
            }
        }


        static void Main(string[] args){
                

            
            GarageGate garage = new GarageGate(0, 0, 0);
            Console.WriteLine(garage.Calcular());
            garage.setInputs(0,0,1);
            Console.WriteLine(garage.Calcular());

            garage.setInputs(0,1,0);
            Console.WriteLine(garage.Calcular());
            
            garage.setInputs(0,1,1);
            Console.WriteLine(garage.Calcular());
        
            garage.setInputs(1,0,0);
            Console.WriteLine(garage.Calcular());

            garage.setInputs(1,0,1);
            Console.WriteLine(garage.Calcular());
            
            garage.setInputs(1,1,0);
            Console.WriteLine(garage.Calcular());

            garage.setInputs(1,1,1);
            Console.WriteLine(garage.Calcular());

        }
    }
}
