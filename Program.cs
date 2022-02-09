using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPolinomio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Número Para Derivação");
            int numDerivacao = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Informe o Número Para Soma");
            int numSoma = int.Parse(Console.ReadLine().ToString());
            int resultado = resultadoderivada(numDerivacao, numSoma);
            Console.WriteLine($"O Resultado da Derivação: {resultado}");
            Console.ReadLine();
        }
        private static int resultadoderivada(int n, int k)
        {
            List<int> valorcalculado = new List<int>();
            List<int> valorcalculadosomar = new List<int>();
            int maiorExpoente = n - 1;
            int maiorExpoenteCalcular = maiorExpoente;
            int numeroCalcular = 0;
            while (maiorExpoente >= 2)
            {
                maiorExpoenteCalcular = maiorExpoente;
                numeroCalcular = n;
                while (maiorExpoenteCalcular >= 2)
                {
                    valorcalculado.Add(numeroCalcular * maiorExpoenteCalcular);
                    numeroCalcular = valorcalculado[valorcalculado.Count - 1];
                    maiorExpoenteCalcular--;
                }
                valorcalculadosomar.Add(valorcalculado[valorcalculado.Count - 1]);
                valorcalculado.Clear();
                n--;
                maiorExpoente--;
            }
            return valorcalculadosomar.Sum() + 2 + 1 + k; 
        }
    }
}