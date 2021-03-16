using System;
using номінали;

namespace Номінали_гривні
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть скiльки купюр 1 гривнi");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 2 гривнi");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 5 гривнi");
            int five = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 10 гривнi");
            int ten = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 20 гривнi");
            int twenty = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 50 гривнi");
            int fifty = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 100 гривнi");
            int oneHundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 200 гривнi");
            int twoHundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 500 гривнi");
            int fiveHundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.01");
            int oneCent = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.02");
            int twoCent = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.05");
            int fiveCent = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.10");
            int tenCent = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.25");
            int twentyFiveCent = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.50");
            int fiftyCent = int.Parse(Console.ReadLine());
            Money money = new Money(one, two, five, ten, twenty, fifty, oneHundreds, twoHundreds,
            fiveHundreds);
            Coins coins = new Coins(oneCent, twoCent, fiveCent, tenCent, twentyFiveCent, fiftyCent);
            Console.WriteLine("Гривнi: " + money.NominalMoney());
            Console.WriteLine("Копiйки:"+ Math.Round(coins.NominalCoins(),2));
            Console.WriteLine("Номiнал: " +Math.Round(money.NominalMoney()+ coins.NominalCoins(),2));
            Nominal nominal = new Nominal(money,coins);
            Console.WriteLine("Введiть скiльки купюр 1 гривнi");
            int one1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 2 гривнi");
            int two1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 5 гривнi");
            int five1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 10 гривнi");
            int ten1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 20 гривнi");
            int twenty1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 50 гривнi");
            int fifty1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 100 гривнi");
            int oneHundreds1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 200 гривнi");
            int twoHundreds1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки купюр 500 гривнi");
            int fiveHundreds1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.01");
            int oneCent1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.02");
            int twoCent1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.05");
            int fiveCent1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.10");
            int tenCent1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.25");
            int twentyFiveCent1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.50");
            int fiftyCent1 = int.Parse(Console.ReadLine());
            Money money1 = new Money(one1, two1, five1, ten1, twenty1, fifty1, oneHundreds1, twoHundreds1, fiveHundreds1);
            Coins coins1 = new Coins(oneCent1, twoCent1, fiveCent1, tenCent1, twentyFiveCent1, fiftyCent1);
            Nominal nominal1 = new Nominal(money1, coins1);
            SumOfMoney sumOfMoney1 = nominal + nominal1;
            SumOfMoney sumOfMoney2 = nominal - nominal1;
            double sumOfMoney3 = nominal / nominal1;
            double sumOfMoney4 = nominal * nominal1;
            bool sumOfMoney5 = nominal == nominal1;
            bool sumOfMoney6 = nominal != nominal1;
            Console.Write("Додавання: ");
            Console.WriteLine(sumOfMoney1);
            Console.Write("Вiднiмання: ");
            Console.WriteLine(sumOfMoney2);
            Console.Write("Дiлення: ");
            Console.WriteLine(sumOfMoney3);
            Console.Write("Множення: ");
            Console.WriteLine(sumOfMoney4);
            Console.Write("Операцiя ==: ");
            Console.WriteLine(sumOfMoney5);
            Console.Write("Операцiя !=: "); 
            Console.WriteLine(sumOfMoney6);
        }
    }
}
