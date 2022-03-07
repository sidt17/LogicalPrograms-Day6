using System;

namespace LogicalPrograms
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Unique Coupons you want to generate-");
            int n = Convert.ToInt32(Console.ReadLine());
        
            int totalRandomNo = 0;
            Random random = new Random();
            while (totalRandomNo < n)
            {
                int coupon = random.Next(1, 1000);
                Console.WriteLine(coupon);
                totalRandomNo++;
            }
            Console.WriteLine("The no of times random used in generating unique coupons is :" + totalRandomNo);











        }

    }


    


}
