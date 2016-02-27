using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime2
{
    //Find the prime numbers less than or equal to a given integer n.
    class Program
    {
        static void Main(string[] args)
        {
            int n = 32;
            bool[] prime = new bool[n];
            //Assumed 0 and 1 are not prime
            for (int i = 2; i <= n-1; i++)
                
                prime[i] = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {

                    if (prime[i])

                    //Mark all numbers which are divisible by 2,3... false as they are not prime
                    {
                        for (int j = 2; i*j <= n-1; j++)
                        {
                            prime[i*j] = false;
                        }
                    }
                
                 }
           //Print prime numbers
            for(int i = 2; i<= n-1; i++)
            {
                if(prime[i])
                    Console.WriteLine(i);
            }
        }
    }
}
