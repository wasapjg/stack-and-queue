using static System.Runtime.InteropServices.JavaScript.JSType;

interface IColleccion
{
    bool estaVacia();
    object extraer();
    object primero();
    bool añadir(object obj);
}


public class Cola : IColleccion
{
    private List<object> cola = new List<object>();

    public bool estaVacia()
    {
        return cola.Count == 0;
    }

    public object extraer()
    {
        var first = cola.First();

        cola.RemoveAt(0);

        return first;
    }

    public object primero()
    {
        return cola.First();
    }

    public bool añadir(object obj)
    {
        cola.Add(obj);
        return true;
    }
}

class Pila : IColleccion
{
    private object[] pila;
    private int Tamaño = 0;
    private int contador = 0;

    public Pila(int tamaño)
    {
        Tamaño = tamaño;
        pila = new object[Tamaño];
    }
    public bool estaVacia()
    {
        return contador == 0;
    }

    public object extraer()
    {
        if(contador == 0)
        {
            return "No hay elementos en la pila";
        }
        else
        {
            object obj = pila[contador - 1];
            pila[contador - 1] = null;
            contador--;
            return obj;
        }
    }

    public object primero()
    {
        return pila[contador - 1];
    }

    public bool añadir(object obj)
    {
        if(contador == Tamaño)
        {
            return false;
        }
        else
        {
            pila[contador] = obj;
            contador++;
            return true;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Cola oCola = new Cola();
        Console.WriteLine(oCola.añadir(1));
        Console.WriteLine(oCola.añadir(2));
        Console.WriteLine(oCola.añadir(3));
        Console.WriteLine(oCola.estaVacia());
        Console.WriteLine(oCola.primero());
        Console.WriteLine(oCola.extraer());
        Console.WriteLine(oCola.primero());


        Pila oPila = new Pila(4);
        Console.WriteLine(oPila.añadir(1));
        Console.WriteLine(oPila.añadir(2));
        Console.WriteLine(oPila.añadir(3));
        Console.WriteLine(oPila.añadir(4));
        Console.WriteLine(oPila.añadir(5));
        Console.WriteLine(oPila.estaVacia());
        Console.WriteLine(oPila.primero());
        Console.WriteLine(oPila.extraer());
        Console.WriteLine(oPila.primero());

    }
}