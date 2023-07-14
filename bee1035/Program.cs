using System;
using System.Globalization;

namespace bee1035
{
    class Program
    {

        static void Main(string[] args)
        {
            int A, B, C, D, soma;

            string [] Vet = (Console.ReadLine().Split(' '));

            A = int.Parse(Vet[0]);
            B = int.Parse(Vet[1]);
            C = int.Parse(Vet[2]);
            D = int.Parse(Vet[3]);

           int somaCD = C + D ;
            int somaAB = A + B;

            int MOD = A % 2 ;

            Console.WriteLine(A.ToString ());

            if (B > C && D > A && somaCD > somaAB && C > 0 && D > 0 && A % 2 == 0) 
            {
                Console.WriteLine("Valores aceitos");
            }
            else
             {
                Console.WriteLine("Valores nao aceitos");

            }
        }
    }
}
