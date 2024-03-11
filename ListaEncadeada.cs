public class ListaEncadeada<T> : IListaEncadeada<T>
{
    private Nodo<T> cabeca;
    private int tamanho;

    public int Tamanho => tamanho;
    public bool EstaVazia => tamanho == 0;

    public void InserirNoInicio(T valor)
    {
        Nodo<T> novoNodo = new Nodo<T>(valor) { Proximo = cabeca };
        cabeca = novoNodo;
        tamanho++;
    }

    public void InserirNoFinal(T valor)
    {
        if (EstaVazia)
        {
            InserirNoInicio(valor);
            return;
        }

        Nodo<T> atual = cabeca;
        while (atual.Proximo != null)
        {
            atual = atual.Proximo;
        }
        atual.Proximo = new Nodo<T>(valor);
        tamanho++;
    }

    public bool Remover(T valor)
    {
        if (EstaVazia) return false;

        if (cabeca.Valor.Equals(valor))
        {
            cabeca = cabeca.Proximo;
            tamanho--;
            return true;
        }

        Nodo<T> atual = cabeca;
        while (atual.Proximo != null)
        {
            if (atual.Proximo.Valor.Equals(valor))
            {
                atual.Proximo = atual.Proximo.Proximo;
                tamanho--;
                return true;
            }
            atual = atual.Proximo;
        }
        return false;
    }

    public T RemoverDoInicio()
    {
        if (EstaVazia) throw new InvalidOperationException("A lista está vazia.");

        T valor = cabeca.Valor;
        cabeca = cabeca.Proximo;
        tamanho--;
        return valor;
    }

    public bool Contem(T valor)
    {
        Nodo<T> atual = cabeca;
        while (atual != null)
        {
            if (atual.Valor.Equals(valor)) return true;
            atual = atual.Proximo;
        }
        return false;
    }
}