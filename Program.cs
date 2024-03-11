namespace Aula03_ListaEncadeada;

class Program
{
    static void Main(string[] args)
    {
        IListaEncadeada<int> lista = new ListaEncadeada<int>();
        lista.InserirNoInicio(1);
        lista.InserirNoFinal(2);
        lista.InserirNoFinal(3);

        Console.WriteLine($"Contém 2? {lista.Contem(2)}"); // True
        Console.WriteLine($"Tamanho: {lista.Tamanho}"); // 3

        lista.Remover(2);
        Console.WriteLine($"Contém 2 após remover? {lista.Contem(2)}"); // False
        Console.WriteLine($"Tamanho após remover: {lista.Tamanho}"); // 2

        while (!lista.EstaVazia)
        {
            Console.WriteLine($"Removido do início: {lista.RemoverDoInicio()}");
        }
    }
}

