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
