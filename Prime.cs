class NewPrime : Prime
{
    public bool isprime(int number)  //override
    {
        if (number <= 1)         //
        {
             false;
        }
        // if (number == 2)  //true
        //     {
       }   return true
 if (number % 2 == 0)   // even number not find 
   {
        return false   
                }  // false              // odd number not find      
                        if (number % i==0 )
                {
        for (int i=2;i<=num;i++)
      // factor show to the outp
    } 
 return true;
Console.WriteLine(i);
}

// public bool isprime(int number)  // Same method name override
//     {
//         return isPrime()
//     }
public class Program
{
    public static void Main(string[] args)
    {
        Prime prim = new Prime();
        NewPrime P = new NewPrime();
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
        bool ad = NewPrime.Isprime(m);
        Console.WriteLine("prime number is" + ad);
    }
}
