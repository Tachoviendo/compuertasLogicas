namespace Library;

public class Compuerta
{
    public enum tiposCompuerta
    {
        AND,
        OR,
        NOT
    }
  
    //propieties
    public List<int> entradas {get; set;}
    public tiposCompuerta tipo {get; set;}
    
    //constructor
    public Compuerta(List<int> entradas, tiposCompuerta tipo)
    {
        this.entradas = entradas;
        this.tipo = tipo;
    }

    public int Resultado()
    {
        
        if (this.tipo == tiposCompuerta.NOT) 
        {
            if (this.entradas[0] == 0){
                return 1;
            }
            else
            {
                return 0;
            }
        }

        else if (this.tipo == tiposCompuerta.OR) {
            return this.entradas[0] + this.entradas[1];
        }
        else if (this.tipo == tiposCompuerta.AND) {
            
            return this.entradas[0] * this.entradas[1];
        }
        else {
            Console.WriteLine("Mano, que hacer, ta todo mal.");
            return 0;
        }
    }

    public string getEntrada(){
        return string.Join(", ",this.entradas);

    }

}
