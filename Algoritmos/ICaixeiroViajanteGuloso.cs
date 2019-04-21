namespace Algoritmos
{
    public interface ICaixeiroViajanteGuloso
    {
        void AlgoritmoGuloso();
        int BuscaMenorPeso(int i);
        bool ChecarVisitas();
        void ImprimirDistanciaDasRotasDoGrafo();
        void PreencheDistanciaDasCidadesDoGrafo(int inicio, int fim);
        void SomaDaMelhorRota();
    }
}