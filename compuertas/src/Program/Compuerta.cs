
public class Compuerta
{
    public enum tiposCompuerta
    {
        AND,
        OR,
        NOT
    }
    private List<int> entradas { get; set; }
    private tiposCompuerta tipo { get; set; }


    public Compuerta(List<int> entradas, tiposCompuerta tipo)
    {
        this.entradas = entradas;
        this.tipo = tipo;
    }
    public int Resultado()
    {

        if this.tipo == AND {

            return this.entradas[0] * this.entradas[1];

        }

        else if this.tipo == OR {

            return this.entradas[0] + this.entradas[1];

        }

        else if this.tipo == NOT {

            if this.entradas[0] == 0{
                return 1
            }
            else
            {
                return 0
            }


        }
    }
}
