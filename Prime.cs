using System;
namespace HelloWorld
{
static class Programm
{
private static bool isprime(int k)
 {
        bool isprime = true;
        for (int i = 2; i < k; i++)
        {
            int Temp = k % i;
            // int Temp = k%i;
            if (Temp == 0)
            {
                isprime = false;
                break;
            }
        }
        return isprime;
    }
    public static void Main(string[] args)
    {
         int d=11;
         bool u = isprime(d);
 Console.WriteLine("Prime Numbers" +u );
   }
   }
}
public class Program
    {
        public static void Main(string[] args)
        {
            Prime prime = new Prime(); 
            Console.WriteLine("Prime numbers up to 30:");
            for (int i = 2; i <= 100; i++)
            {
                bool check = prime.IsPrime(i);
                if (check)
                {
                    Console.WriteLine(i); 
                }
            }
            int d = 12;
            bool u = prime.IsPrime(d);
            Console.WriteLine("prime Numner is " + u);           
        }
    }
