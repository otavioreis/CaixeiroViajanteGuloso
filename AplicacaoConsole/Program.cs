using System;
using Algoritmos;

namespace AplicacaoConsole
{
    class Program
    {
        //Input data
        public static bool EntradaDeValoresRandomicos()
        {
            Console.WriteLine("informe o número de cidades:");
            var numeroCidades = Convert.ToInt32(Console.ReadLine());
            if (numeroCidades < 1)
            {
                Console.WriteLine("Informe um valor de dois ou mais!");
                return false;
            }
            Console.WriteLine("Entre a menor distância entre as cidades:");
            var inicio = Convert.ToInt32(Console.ReadLine());
            if (inicio < 0)
            {
                Console.WriteLine("O valor precisa ser positivo!");
                return false;
            }
            Console.WriteLine("Informe a maior distância entre as cidades:");
            var fim = Convert.ToInt32(Console.ReadLine());
            if (fim < 0 || fim < inicio)
            {
                Console.WriteLine("O valor precisa ser positivo e maior que a distância inicial.");
                return false;
            }

            ICaixeiroViajanteGuloso caixeiroViajanteGuloso = new CaixeiroViajanteGuloso(numeroCidades);

            caixeiroViajanteGuloso.PreencheDistanciaDasCidadesDoGrafo(inicio, fim);
            caixeiroViajanteGuloso.ImprimirDistanciaDasRotasDoGrafo();
            Console.WriteLine("\n");
            caixeiroViajanteGuloso.AlgoritmoGuloso();
            caixeiroViajanteGuloso.SomaDaMelhorRota();

            return false;
        }

        public static void ValoresFixos()
        {
            Console.WriteLine("Simulando o calculo da melhor rota utilizando valores fixos:" + Environment.NewLine);

            var caixeiroViajanteGuloso = new CaixeiroViajanteGuloso(5);

            caixeiroViajanteGuloso.ArrayDistancias[0, 0] = 0;   //A-A
            caixeiroViajanteGuloso.ArrayDistancias[0, 1] = 185; //A-B
            caixeiroViajanteGuloso.ArrayDistancias[0, 2] = 119; //A-C
            caixeiroViajanteGuloso.ArrayDistancias[0, 3] = 152; //A-D
            caixeiroViajanteGuloso.ArrayDistancias[0, 4] = 133; //A-E

            //Cidade B
            caixeiroViajanteGuloso.ArrayDistancias[1, 0] = 185; //B-A
            caixeiroViajanteGuloso.ArrayDistancias[1, 1] = 0;   //B-B
            caixeiroViajanteGuloso.ArrayDistancias[1, 2] = 121; //B-C
            caixeiroViajanteGuloso.ArrayDistancias[1, 3] = 150; //B-D
            caixeiroViajanteGuloso.ArrayDistancias[1, 4] = 200; //B-E

            //Cidade C
            caixeiroViajanteGuloso.ArrayDistancias[2, 0] = 119; //C-A
            caixeiroViajanteGuloso.ArrayDistancias[2, 1] = 121; //C-B
            caixeiroViajanteGuloso.ArrayDistancias[2, 2] = 0;   //C-C
            caixeiroViajanteGuloso.ArrayDistancias[2, 3] = 174; //C-D
            caixeiroViajanteGuloso.ArrayDistancias[2, 4] = 120; //C-E

            //Cidade D
            caixeiroViajanteGuloso.ArrayDistancias[3, 0] = 152; //D-A
            caixeiroViajanteGuloso.ArrayDistancias[3, 1] = 150; //D-B
            caixeiroViajanteGuloso.ArrayDistancias[3, 2] = 174; //D-C
            caixeiroViajanteGuloso.ArrayDistancias[3, 3] = 0;   //D-D
            caixeiroViajanteGuloso.ArrayDistancias[3, 4] = 199; //D-E

            //Cidade E
            caixeiroViajanteGuloso.ArrayDistancias[4, 0] = 133; //E-A
            caixeiroViajanteGuloso.ArrayDistancias[4, 1] = 200; //E-B
            caixeiroViajanteGuloso.ArrayDistancias[4, 2] = 120; //E-C
            caixeiroViajanteGuloso.ArrayDistancias[4, 3] = 199; //E-D
            caixeiroViajanteGuloso.ArrayDistancias[4, 4] = 0;   //E-E

            caixeiroViajanteGuloso.ImprimirDistanciaDasRotasDoGrafo();
            Console.WriteLine("\n");
            caixeiroViajanteGuloso.AlgoritmoGuloso();
            caixeiroViajanteGuloso.SomaDaMelhorRota();
        }

        static public void Run()
        {
            while (EntradaDeValoresRandomicos());
        }


        static void Main(string[] args)
        {
            try
            {
                //Descomentar uma das linhas para executar
                //EntradaDeValoresRandomicos();
                ValoresFixos();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:\n{0}", ex.Message);
            }

            Console.ReadLine();
        }
    }
}
