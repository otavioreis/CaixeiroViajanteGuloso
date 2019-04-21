using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritmos
{
    public class CaixeiroViajanteGuloso : ICaixeiroViajanteGuloso
    {
        public int[,] ArrayDistancias;//i, j - um caminho de cidades, valor = distância
        public int[] Passos; //Armazena o menor peso de uma cidade a outra

        private readonly int _numeroDeCidades;
        private int _contadorParaPassos;//
        private readonly bool[] _visitas; //Para verificar se a cidade já foi visitada ou não
        private int _contadorParaChecar;

        //ctor
        public CaixeiroViajanteGuloso(int numeroDeCidades)
        {
            ArrayDistancias = new int[numeroDeCidades, numeroDeCidades];
            Passos = new int[numeroDeCidades];

            _numeroDeCidades = numeroDeCidades;
            _visitas = new bool[numeroDeCidades];
            _contadorParaPassos = 0;
            _contadorParaChecar = 0;
        }

        //Caso queira utilizar números randômicos, este método preenche as distâncias das cidades
        public void PreencheDistanciaDasCidadesDoGrafo(int inicio, int fim)
        {
            Random rnd = new Random();

            for (int i = 0; i < _numeroDeCidades; i++)
            {
                for (int j = 0; j < _numeroDeCidades; j++)
                {
                    if (i != j)
                    {
                        ArrayDistancias[i, j] = rnd.Next(inicio, fim + 1);
                    }
                    else
                        ArrayDistancias[i, j] = 0;
                    if (ArrayDistancias[i, j] != ArrayDistancias[j, i]) ArrayDistancias[j, i] = ArrayDistancias[i, j];
                }
            }
            
        }

        //Imprime as distancias entre as cidades
        public void ImprimirDistanciaDasRotasDoGrafo()
        {
            for (int i = 0; i < _numeroDeCidades; i++)
            {
                for (int j = 0; j < _numeroDeCidades; j++)
                {
                    Console.WriteLine("{0} - {1} = {2}", i + 1, j + 1, ArrayDistancias[i, j]);
                }

                Console.WriteLine("-----------------------");
            }
        }

        //Checa sempre que um vertice foi visitado
        public bool ChecarVisitas()
        {
            for (_contadorParaChecar = 0; _contadorParaChecar < _numeroDeCidades; _contadorParaChecar++)
                if (!_visitas[_contadorParaChecar])
                    return false;
            return true;
        }

        //Search of the minimum weight for this top (parameter i)
        public int BuscaMenorPeso(int i)
        {
            int valor = 0;
            int temp = Int32.MaxValue;

            if (i == _contadorParaChecar && !ChecarVisitas())
            {
                _visitas[i] = true;

                if (ChecarVisitas())
                {
                    Passos[_contadorParaPassos] = ArrayDistancias[i, 0];
                    _visitas[i] = true;
                    return valor = _numeroDeCidades - 1;
                }
                else
                    _visitas[i] = false;
            }

            for (int j = 1; j < _numeroDeCidades; j++)
            {
                if (ArrayDistancias[i, j] < temp && i != j && !_visitas[j])//?
                {
                    temp = ArrayDistancias[i, j];
                    Passos[_contadorParaPassos] = ArrayDistancias[i, j];
                    valor = j;
                }
                else if (i == j && i != _numeroDeCidades - 1)
                {
                    if (i != 0 && i != _numeroDeCidades - 1 && j != _numeroDeCidades - 1)
                        continue;
                }
                else if (i == j && i == _numeroDeCidades - 1 && j == _numeroDeCidades - 1)
                {
                    if (ChecarVisitas())
                    {
                        Passos[_contadorParaPassos] = ArrayDistancias[j, 0];
                        _visitas[i] = true;
                        return valor = _numeroDeCidades - 1;
                    }
                    else
                    {
                        _visitas[i] = true;
                        ++_contadorParaPassos;
                        return _contadorParaPassos;
                    }
                }
                else if (i == j && i == _numeroDeCidades - 1 && j != _numeroDeCidades - 1 && !_visitas[j])
                {
                    continue;
                }
            }

            _visitas[i] = true;
            ++_contadorParaPassos;
            return valor;
        }

        //Algoritmo guloso de caixeiro viajante
        public void AlgoritmoGuloso()
        {
            for (int v = 0; v < _numeroDeCidades; v++) _visitas[v] = false;

            for (int i = 0; i < _numeroDeCidades;)
            {
                if (!_visitas[i])
                {
                    i = BuscaMenorPeso(i);
                }
                else if (_visitas[i] && i != _numeroDeCidades)
                {
                    if(ChecarVisitas())
                        ++i;
                    else
                    {
                        var j = 0;
                        foreach (bool value in _visitas)
                        {
                            if(!value)
                                i = j;

                            j++;
                        }
                    }
                }
            }
        }

        //Imprime a soma da melhor rota.
        public void SomaDaMelhorRota()
        {
            int soma = 0;
            int ultimoPasso = Passos.Length - 1;
            for (int i = 0; i < ultimoPasso; i++)
            {
                Console.Write("{0} + ", Passos[i]);
                soma += Passos[i];
            }
            Console.WriteLine("{0} = {1}", Passos[ultimoPasso], soma + Passos[ultimoPasso]);
        }
    }
}
