﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class PaymentMethod
    {
        public static void Cash(double price)
        {
            double payment = 0;
            do
            {
                Console.WriteLine("Enter your payment amount:");
                try
                {

                    payment = double.Parse(Console.ReadLine());
                    if (payment > price)
                    {

                        Console.WriteLine($"Here is your change of {payment - price:c}");
                        return;

                    }
                    else if(payment == price)
                    {

                        Console.WriteLine("Thank you for your patronage");
                        return;

                    }
                    else
                    {

                        Console.WriteLine($"Your payment was not enough, you're short {price - payment:c}");

                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine($"Error: {e.Message}");

                }


            } while (true);


        }

        public static void Credit()
        {
            Console.WriteLine("Input your credit card number:");
            string cvv = "";
            int  cvvLength = 0;



            bool whileBreak = false;
            do
            {
                try
                {
                    string cardNum = Console.ReadLine();
                    if (Regex.IsMatch(cardNum, @"^4[0-9]{12}(?:[0-9]{3})?$"))
                    {

                        Console.WriteLine("You have entered a Visa Card");
                        cvvLength = 3;
                        whileBreak = true;

                    }
                    else if (Regex.IsMatch(cardNum, @"^3[47][0-9]{13}$"))
                    {

                        Console.WriteLine("You have entered an AMerican Express");
                        cvvLength = 4;
                        whileBreak = true;

                    }
                    else if (Regex.IsMatch(cardNum, @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$"))
                    {

                        Console.WriteLine("You have entered a Diners Club Card");
                        cvvLength = 3;
                        whileBreak = true;

                    }
                    else if (Regex.IsMatch(cardNum, @"^6(?:011|5[0-9]{2})[0-9]{12}$"))
                    {

                        Console.WriteLine("You have entered a Discover Card");
                        cvvLength = 3;
                        whileBreak = true;

                    }
                    else if (Regex.IsMatch(cardNum, @"^(?:2131|1800|35\d{3})\d{11}$"))
                    {

                        Console.WriteLine("You have entered a JBC card");
                        cvvLength = 3;
                        whileBreak = true;

                    }


                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            while (!whileBreak);

            do
            {


                try
                {
                    if (!Regex.IsMatch(cvv, @"^(\d{4})|(\d{3})$"))
                    {
                         
                    }


                }
                catch
                {


                }


}
            while (true);




        }

        public static void Check()
        { }



    }

}