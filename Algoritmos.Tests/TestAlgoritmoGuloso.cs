using System;
using Xunit;

namespace Algoritmos.Tests
{
    public class TestAlgoritmoGuloso
    {
        [Fact]
        public void TestExercicioMarco()
        {
            var caixeiroViajanteGuloso = new CaixeiroViajanteGuloso(5);

            //Iniciando valores entre as cidades

            //Cidade A
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

            caixeiroViajanteGuloso.AlgoritmoGuloso();

            Assert.True(caixeiroViajanteGuloso.Passos[0] == 119, "O valor esperado é 119 - A-C");
            Assert.True(caixeiroViajanteGuloso.Passos[1] == 120, "O valor esperado é 120 - C-E");
            Assert.True(caixeiroViajanteGuloso.Passos[2] == 199, "O valor esperado é 199 - E-D");
            Assert.True(caixeiroViajanteGuloso.Passos[3] == 150, "O valor esperado é 150 - D-B");
            Assert.True(caixeiroViajanteGuloso.Passos[4] == 185, "O valor esperado é 185 - B-A");

        }

        [Fact]
        public void Cenario01()
        {
            var caixeiroViajanteGuloso = new CaixeiroViajanteGuloso(5);

            //Iniciando valores entre as cidades

            //Cidade A
            caixeiroViajanteGuloso.ArrayDistancias[0, 0] = 0;   //A-A
            caixeiroViajanteGuloso.ArrayDistancias[0, 1] = 101; //A-B
            caixeiroViajanteGuloso.ArrayDistancias[0, 2] = 132; //A-C
            caixeiroViajanteGuloso.ArrayDistancias[0, 3] = 116; //A-D
            caixeiroViajanteGuloso.ArrayDistancias[0, 4] = 182; //A-E

            //Cidade B
            caixeiroViajanteGuloso.ArrayDistancias[1, 0] = 101; //B-A
            caixeiroViajanteGuloso.ArrayDistancias[1, 1] = 0;   //B-B
            caixeiroViajanteGuloso.ArrayDistancias[1, 2] = 184; //B-C
            caixeiroViajanteGuloso.ArrayDistancias[1, 3] = 137; //B-D
            caixeiroViajanteGuloso.ArrayDistancias[1, 4] = 157; //B-E

            //Cidade C
            caixeiroViajanteGuloso.ArrayDistancias[2, 0] = 132; //C-A
            caixeiroViajanteGuloso.ArrayDistancias[2, 1] = 184; //C-B
            caixeiroViajanteGuloso.ArrayDistancias[2, 2] = 0;   //C-C
            caixeiroViajanteGuloso.ArrayDistancias[2, 3] = 168; //C-D
            caixeiroViajanteGuloso.ArrayDistancias[2, 4] = 195; //C-E

            //Cidade D
            caixeiroViajanteGuloso.ArrayDistancias[3, 0] = 116; //D-A
            caixeiroViajanteGuloso.ArrayDistancias[3, 1] = 137; //D-B
            caixeiroViajanteGuloso.ArrayDistancias[3, 2] = 168; //D-C
            caixeiroViajanteGuloso.ArrayDistancias[3, 3] = 0;   //D-D
            caixeiroViajanteGuloso.ArrayDistancias[3, 4] = 135; //D-E

            //Cidade E
            caixeiroViajanteGuloso.ArrayDistancias[4, 0] = 182; //E-A
            caixeiroViajanteGuloso.ArrayDistancias[4, 1] = 157; //E-B
            caixeiroViajanteGuloso.ArrayDistancias[4, 2] = 195; //E-C
            caixeiroViajanteGuloso.ArrayDistancias[4, 3] = 135; //E-D
            caixeiroViajanteGuloso.ArrayDistancias[4, 4] = 0;   //E-E

            caixeiroViajanteGuloso.AlgoritmoGuloso();
            
            Assert.True(caixeiroViajanteGuloso.Passos[0] == 101, "O valor esperado é 101 - A-B");
            Assert.True(caixeiroViajanteGuloso.Passos[1] == 137, "O valor esperado é 137 - B-D");
            Assert.True(caixeiroViajanteGuloso.Passos[2] == 135, "O valor esperado é 135 - D-E");
            Assert.True(caixeiroViajanteGuloso.Passos[3] == 195, "O valor esperado é 195 - E-C");
            Assert.True(caixeiroViajanteGuloso.Passos[4] == 132, "O valor esperado é 132 - C-A");

        }

        [Fact]
        public void Cenario02()
        {
            var caixeiroViajanteGuloso = new CaixeiroViajanteGuloso(5);

            //Iniciando valores entre as cidades

            //Cidade A
            caixeiroViajanteGuloso.ArrayDistancias[0, 0] = 0;   //A-A
            caixeiroViajanteGuloso.ArrayDistancias[0, 1] = 161; //A-B
            caixeiroViajanteGuloso.ArrayDistancias[0, 2] = 140; //A-C
            caixeiroViajanteGuloso.ArrayDistancias[0, 3] = 142; //A-D
            caixeiroViajanteGuloso.ArrayDistancias[0, 4] = 154; //A-E

            //Cidade B
            caixeiroViajanteGuloso.ArrayDistancias[1, 0] = 161; //B-A
            caixeiroViajanteGuloso.ArrayDistancias[1, 1] = 0;   //B-B
            caixeiroViajanteGuloso.ArrayDistancias[1, 2] = 197; //B-C
            caixeiroViajanteGuloso.ArrayDistancias[1, 3] = 123; //B-D
            caixeiroViajanteGuloso.ArrayDistancias[1, 4] = 137; //B-E

            //Cidade C
            caixeiroViajanteGuloso.ArrayDistancias[2, 0] = 140; //C-A
            caixeiroViajanteGuloso.ArrayDistancias[2, 1] = 197; //C-B
            caixeiroViajanteGuloso.ArrayDistancias[2, 2] = 0;   //C-C
            caixeiroViajanteGuloso.ArrayDistancias[2, 3] = 139; //C-D
            caixeiroViajanteGuloso.ArrayDistancias[2, 4] = 126; //C-E

            //Cidade D
            caixeiroViajanteGuloso.ArrayDistancias[3, 0] = 142; //D-A
            caixeiroViajanteGuloso.ArrayDistancias[3, 1] = 123; //D-B
            caixeiroViajanteGuloso.ArrayDistancias[3, 2] = 139; //D-C
            caixeiroViajanteGuloso.ArrayDistancias[3, 3] = 0;   //D-D
            caixeiroViajanteGuloso.ArrayDistancias[3, 4] = 103; //D-E

            //Cidade E
            caixeiroViajanteGuloso.ArrayDistancias[4, 0] = 157; //E-A
            caixeiroViajanteGuloso.ArrayDistancias[4, 1] = 137; //E-B
            caixeiroViajanteGuloso.ArrayDistancias[4, 2] = 126; //E-C
            caixeiroViajanteGuloso.ArrayDistancias[4, 3] = 103; //E-D
            caixeiroViajanteGuloso.ArrayDistancias[4, 4] = 0;   //E-E

            caixeiroViajanteGuloso.AlgoritmoGuloso();

            Assert.True(caixeiroViajanteGuloso.Passos[0] == 140, "O valor esperado é 140 - A-C");
            Assert.True(caixeiroViajanteGuloso.Passos[1] == 126, "O valor esperado é 126 - C-E");
            Assert.True(caixeiroViajanteGuloso.Passos[2] == 103, "O valor esperado é 103 - E-D");
            Assert.True(caixeiroViajanteGuloso.Passos[3] == 123, "O valor esperado é 123 - D-B");
            Assert.True(caixeiroViajanteGuloso.Passos[4] == 161, "O valor esperado é 161 - B-A");

        }
    }
}
