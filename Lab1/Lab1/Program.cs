using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int change, paidAmount, price;
            string changeBack;
            Console.Write("Pris: ");
            price = int.Parse(Console.ReadLine());

            Console.Write("Betalat: ");
            paidAmount = int.Parse(Console.ReadLine());

            change = price - paidAmount;

            if (price > paidAmount)
            {
                Console.WriteLine("Pengarna räcker dessvärre inte.");

            }
            else
            {
                changeBack = "Växel tillbaka: " + change * -1 + " kr";
                Console.WriteLine(changeBack.ToString());
                Console.WriteLine(new string('-', changeBack.Length));
            }

            int thousandBill = (change * -1) / 1000;
            int fiveHundredBill = ((change * -1) % 1000) / 500;
            int oneHundredBill = ((change * -1) % 500) / 100;
            int twentyBill = ((change * -1) % 100) / 20;
            int tenCoin = ((change * -1) % 20) / 10;
            int fiveCoin = ((change * -1) % 10) / 5;
            int oneCoin = (change * -1) % 5;

            if (thousandBill > 0)
                Console.WriteLine(thousandBill + " tusenlapp" + (thousandBill > 1 ? "ar" : ""));

            if (fiveHundredBill > 0)
                Console.WriteLine(fiveHundredBill + " femhundralapp" + (fiveHundredBill > 1 ? "ar" : ""));

            if (oneHundredBill > 0)
                Console.WriteLine(oneHundredBill + " hundralapp" + (oneHundredBill > 1 ? "ar" : ""));

            if (twentyBill > 0)
                Console.WriteLine(twentyBill + " tjug" + (twentyBill > 1 ? "or" : "a"));

            if (tenCoin > 0)
                Console.WriteLine(tenCoin + " ti" + (tenCoin > 1 ? "or" : "a"));

            if (fiveCoin > 0)
                Console.WriteLine(fiveCoin + " femm" + (fiveCoin > 1 ? "or" : "a"));

            if (oneCoin > 0)
                Console.WriteLine(oneCoin + " kron" + (oneCoin > 1 ? "or" : "a"));
            Console.ReadKey();
        }
    }
}
