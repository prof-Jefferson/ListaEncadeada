public interface IListaEncadeada<T>
{
    void InserirNoInicio(T valor);
    void InserirNoFinal(T valor);
    bool Remover(T valor);
    T RemoverDoInicio();
    bool Contem(T valor);
    int Tamanho { get; }
    bool EstaVazia { get; }
}
