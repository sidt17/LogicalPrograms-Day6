using System;

namespace LogicalPrograms
{
    public class CoupanNumber
    {
     public static void Generatecoupanno()
        {
            Console.WriteLine("Enter the Number of Unique Coupons :");
            int n = Convert.ToInt32(Console.ReadLine());
       
            int totalRandomNo = 0;
            Random random = new Random();
            while (totalRandomNo < n)
            {
                int coupon = random.Next(1, 2000);
                Console.WriteLine(coupon);

                totalRandomNo++;
            }
            Console.WriteLine("The no of times random used in generating unique coupons is " + totalRandomNo);



        }

    }
         
    
}