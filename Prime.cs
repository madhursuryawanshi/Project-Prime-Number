using System;
namespace HelloWorld
{
    public class Prime
    {
        public virtual bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
    public class NewPrime : Prime
    {
        public override bool IsPrime(int number)
        {
if (number <= 1)
return false;
if (number == 2)
return true; 
if (number % 2 == 0)
return false;
 for (int i = 3; i<= number; i ++)
{
 if (number % i == 0)
return false;
            }
            return true;
        }
    }
  // Main Program class
    public class Program
    {
        public static void Main(string[] args)
        {
            Prime prime = new Prime();
            NewPrime newPrime = new NewPrime();
int d = 12;
            bool isPrimeD = newPrime.IsPrime(d);
            Console.WriteLine("Is d a prime number? isPrimeD");
int m = 7;
bool isPrimeM = newPrime.IsPrime(m);
Console.WriteLine("Is m a prime number? isPrimeM");
        }
    }
}
