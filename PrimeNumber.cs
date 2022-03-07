using System;

namespace LogicalPrograms
{

     public class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a number :");



            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum++;
                }
            }


            if (sum == 0)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is not a Prime Number");
            }
        }

    }

}

        
           
    

