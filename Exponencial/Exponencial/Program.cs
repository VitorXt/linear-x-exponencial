using System;
using System.Numerics;

class Program
{
    static void Main()
    {

        int[] A = new int[100000];
        Random daran = new Random();

        for (int j = 0; j < A.Length; j++)
        {
            A[j] = daran.Next(1, 100000);
        }

        BigInteger soma = 1;
        int i = A.Length - 1;  // Começa do último índice do array

        // Repetir enquanto i for maior ou igual a 1
        while (i >= 1)
        {
            soma = soma * A[i];  // Multiplica o número atual (A[i]) à soma
            i--;  // Decrementa i

        } // Continua até que i seja igual a 1

        // Exibe o resultado final da soma
        Console.WriteLine($"Soma final: {soma}");
        Console.ReadLine();  // Para manter o console aberto
    }
}