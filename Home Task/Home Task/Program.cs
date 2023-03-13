using System.Diagnostics.Metrics;
using System;
using System.Reflection.Emit;
using System.Security.Principal;

namespace Home_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////// Məzənnə hesablama proqrami \\\\\\\\\\\\\\\\\\\\\\\\\\\


            //// Currency 


            //float usd = 1.7f;
            //float euro = 1.8036f;
            //float rub = 0.0225f;


            //Console.Write("enter the amount (AZN): ");
            //float Aznsum = float.Parse(Console.ReadLine());

            //Console.WriteLine("\nTotal (AZN): " + Aznsum);
            //Console.WriteLine("\nusd " + usd * Aznsum);
            //Console.WriteLine("\neuro: " + euro * Aznsum);
            //Console.WriteLine("\nrub: " + rub * Aznsum);

            //////////////// The program for calculating the country's budget \\\\\\\\\\\\\\\\\\\\\\\\\\

            //long bud = 20000000000;
            //int Defenseperc = 20;
            //int ministrytechno = 10;

            //Console.WriteLine("Budget of government  :" + bud);
            //Console.WriteLine("\nMinistry of Defense :" + bud * Defenseperc / 100);
            //Console.WriteLine("\nMinistry of Techno  :" + bud * ministrytechno / 100);
            //Console.WriteLine("Remain : " + (bud - (bud * Defenseperc / 100) - (bud * ministrytechno / 100)));




            /////////////////////   Program for calculating cargo orders   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //string firstshoesname = "Adidas";
            //int firstcount = 4;
            //int firstshoesprice = 200;
            //int firsttotal = firstcount * firstshoesprice;

            //string secondshoesname = "Gucci";
            //int secondcount = 2;
            //int secondshoesprice = 1000;
            //int secondtotal = secondcount * secondshoesprice;

            //string thirdshoesname = "Nike";
            //int thirdcount = 1;
            //int thirdshoesprice = 150;
            //int thirdtotal = thirdcount * thirdshoesprice;

            //Console.WriteLine("Ayaqqabı adı :" +firstshoesname);
            //Console.WriteLine("Sayı :"+firstcount);
            //Console.WriteLine("Ayyaqabinin qiymeti :"+firstshoesprice);
            //Console.WriteLine("Umumi qiymeti :"+firsttotal);

            //Console.WriteLine("");

            //Console.WriteLine("Ayaqqabı adı :" + secondshoesname);
            //Console.WriteLine("Sayı :" + secondcount);
            //Console.WriteLine("Ayyaqabinin qiymeti :" + secondshoesprice);
            //Console.WriteLine("Umumi qiymeti :" + secondtotal);

            //Console.WriteLine("");

            //Console.WriteLine("Ayaqqabı adı :" + thirdshoesname);
            //Console.WriteLine("Sayı :" + thirdcount);
            //Console.WriteLine("Ayyaqabinin qiymeti :" +thirdshoesprice);
            //Console.WriteLine("Umumi qiymeti :" + thirdtotal);


            //////////////////////// New Lesson \\\\\\\\\\\\\\\\\\\\\\\\

            //string newname = "Fariz";
            //int age = 12;
            //Console.WriteLine(newname);
            //Console.WriteLine(age);

            ////////////////  PASHAPAY 123 \\\\\\\\\\\\\\\\\\\\

            //Console.WriteLine("Salam, Xos Gelmisiniz!");

            //string Companyname = " Pay123 :";
            //int personnumber = 25;
            //int onepersonsalary = 1000;
            //int total = personnumber * onepersonsalary;

            //Console.Write("");
            //Console.Write("Sirketin Adi  :");
            //Console.WriteLine(Companyname);

            //Console.Write("");
            //Console.Write("Sirket iscilerinin sayi :");
            //Console.WriteLine(personnumber);

            //Console.Write("");
            //Console.Write("1 sexsin ayliq maasi :");
            //Console.WriteLine(onepersonsalary);

            //Console.Write("");
            //Console.Write("Umumi Hesabat :");
            //Console.WriteLine(total);

            //Console.WriteLine(total / personnumber * onepersonsalary);


            //////////////  LABs-st TASKS \\\\\\\\\\\\\\\\\\\ 03/10/2023


            //int namesCount = int.Parse(Console.ReadLine());

            //int[] names = new int[namesCount];
            //int fillIndex = 0;

            //while (fillIndex < namesCount)
            //{
            //    int input = int.Parse(Console.ReadLine());

            //    if (input % 2 == 0) //cut calculate 
            //    {
            //        names[fillIndex] = 0;
            //        Console.WriteLine(Console.ReadLine());
            //    }
            //    else
            //    {
            //        names[fillIndex] = -1;
            //        Console.WriteLine(Console.ReadLine());
            //    }

            //    fillIndex++;
            //}

            //int index = 0;
            //while (index < names.Length)
            //{


            //    Console.Write(names[index]);
            //    index++;



            //}

            //////////////  2-nd TASKS \\\\\\\\\\\\\\\\\\\

            //int namesCount = int.Parse(Console.ReadLine());

            //int[] names = new int[namesCount];
            //int fillIndex = 0;


            //if (fillIndex < names.)
            //{
            //    names[fillIndex] = int.Parse(Console.ReadLine());

            //    fillIndex++;
            //}


            ///////////// Home Task - 03/12/2023   \\\\\\\\\\\\\\
            ///// /// string interpolation \\\\\\\\


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine($"{cars[2]} ve ya {cars[3]}");

            ///////   Ev tapsirigi \\\\\\\\

            string[] names = new string[] { "USD", "RUB", "TRY" };
            double[] currencyprices = new double[] { 1.70, 0.0224, 0.0898 };
            int count = 0;
            bool search = false;
            string tags = "";

            do
            {
                Console.WriteLine(
                        "What do you wish want? \n" +
                        "1- show-recent-currency-rates \n" +
                        "2- find-currency-rate-by-code \n" +
                        "3- calculate-amount-by-currency \n" +
                        "4- Exit");
                tags = Console.ReadLine();

                if (tags == "show-recent-currency-rates" || tags == "1")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($" Price is {names[i]}  Rate is: {currencyprices[i]} AZN");


                    }
                }
                else if (tags == "find-currency-rate-by-code" || tags == "2")
                {
                    Console.WriteLine("Please enter the code!");
                    string code = Console.ReadLine();


                    while (count < names.Length)
                    {

                        if (names[count] == code)
                        {

                            Console.WriteLine($"Your code is {code} ,Currency is {currencyprices[count]} AZN ");

                            count = 0;
                            search = true;
                            break;
                        }
                        count++;
                    }

                    if (search is false)
                    {
                        Console.WriteLine("Enter correct code");
                        count = 0;
                        
                        
                    }


                }
                else if (tags == "calculate-amount-by-currency" || tags == "3")
                {
                    Console.WriteLine("Please enter the code!");
                    string code = Console.ReadLine();

                    Console.WriteLine("Please enter the amount :");
                    double amount = double.Parse(Console.ReadLine());


                    while (count < names.Length)
                    {

                        if (names[count] == code)
                        {

                            Console.WriteLine($"Your code is {code} ,Vahidin qiymeti : {currencyprices[count]} AZN " +
                                $" ");
                            Console.WriteLine("Cemi :" + currencyprices[count] * amount + " AZN");

                            count = 0;
                            search = true;
                            break;
                        }
                        count++;
                    }

                    if (search is false)
                    {
                        Console.WriteLine("Enter correct code");
                        count = 0;


                    }


                }

            } while (tags != "exit" && tags != "4");




















        }
    }
}