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

            ////////////////// The program for calculating the country's budget \\\\\\\\\\\\\\\\\\\\\\\\\\

            //long bud = 20000000000;
            //int Defenseperc = 20;
            //int ministrytechno = 10;

            //Console.WriteLine("Budget of government  :" + bud);
            //Console.WriteLine("\nMinistry of Defense :" + bud * Defenseperc / 100);
            //Console.WriteLine("\nMinistry of Techno  :" + bud * ministrytechno / 100);
            //Console.WriteLine("Remain : " + (bud - (bud * Defenseperc / 100) - (bud * ministrytechno / 100)));




            /////////////////////   Program for calculating cargo orders   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            string firstshoesname = "Adidas";
            int firstcount = 4;
            int firstshoesprice = 200;
            int firsttotal = firstcount * firstshoesprice;

            string secondshoesname = "Gucci";
            int secondcount = 2;
            int secondshoesprice = 1000;
            int secondtotal = secondcount * secondshoesprice;

            string thirdshoesname = "Nike";
            int thirdcount = 1;
            int thirdshoesprice = 150;
            int thirdtotal = thirdcount * thirdshoesprice;

            Console.WriteLine("Ayaqqabı adı :" +firstshoesname);
            Console.WriteLine("Sayı :"+firstcount);
            Console.WriteLine("Ayyaqabinin qiymeti :"+firstshoesprice);
            Console.WriteLine("Umumi qiymeti :"+firsttotal);

            Console.WriteLine("");

            Console.WriteLine("Ayaqqabı adı :" + secondshoesname);
            Console.WriteLine("Sayı :" + secondcount);
            Console.WriteLine("Ayyaqabinin qiymeti :" + secondshoesprice);
            Console.WriteLine("Umumi qiymeti :" + secondtotal);

            Console.WriteLine("");

            Console.WriteLine("Ayaqqabı adı :" + thirdshoesname);
            Console.WriteLine("Sayı :" + thirdcount);
            Console.WriteLine("Ayyaqabinin qiymeti :" +thirdshoesprice);
            Console.WriteLine("Umumi qiymeti :" + thirdtotal);




        }
    }
}