public class Nodo<T>
{
    public T Valor { get; set; }
    public Nodo<T> Proximo { get; set; }

    public Nodo(T valor)
    {
        Valor = valor;
    }
}