using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        float[] A = new float[1000000];
        for (int j = 0; j < A.Length; j++)
        {
            A[j] = j + 1;
        }

        float soma = 0;
        for (int i = 0; i < A.Length; i++)
        {
            soma += A[i];
            Console.WriteLine($"Soma parcial após adicionar A[{i}]: {soma}");
        }

        stopwatch.Stop();
        Console.WriteLine($"Soma final: {soma}");
        Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
        Console.ReadLine();
    }
}
