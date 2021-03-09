using System;

namespace Номінали_гривні
{
    struct Money
    {
        private int one, two, five, ten, twenty, fifty, oneHundred, twoHundred, fiveHundreds;
        public Money(int one, int two, int five, int ten, int twenty, int fifty,
            int oneHundred, int twoHundred, int fiveHundreds)
        {
            this.one = one;
            this.two = two;
            this.five = five;
            this.ten = ten;
            this.twenty = twenty;
            this.fifty = fifty;
            this.oneHundred = oneHundred;
            this.twoHundred = twoHundred;
            this.fiveHundreds = fiveHundreds;

        }
        public int NominalMoney()
        {
            return 1 * one + 2 * two + 5 * five + 10 * ten + 20 * twenty + 50 * fifty + 100 * oneHundred + 200 * twoHundred + 500 * fiveHundreds;
        }
    }
        struct Coins
        {
            private double oneCent, twoCent, fiveCent, tenCent, twentyFiveCent, fiftyCent;
            public Coins( double oneCent,double twoCent,double fiveCent,
            double tenCent,double twentyFiveCent,double fiftyCent)
            {
                this.oneCent = oneCent;
                this.twoCent = twoCent;
                this.fiveCent = fiveCent;
                this.tenCent = tenCent;
                this.twentyFiveCent = twentyFiveCent;
                this.fiftyCent = fiftyCent;
            }
            public double NominalCoins()
            {
            return 0.01 * oneCent + 0.02 * twoCent + 0.05 * fiveCent + 0.10 * tenCent + 0.25 * twentyFiveCent + 0.50 * fiftyCent;
            }
        }

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
            int  twentyFiveCent = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть скiльки копiйок 0.50");
            int fiftyCent = int.Parse(Console.ReadLine());
            Money money = new Money(one, two, five, ten, twenty, fifty, oneHundreds, twoHundreds,
            fiveHundreds);
            Coins coins = new Coins(oneCent, twoCent, fiveCent, tenCent, twentyFiveCent,fiftyCent);
            Console.WriteLine("Гривнi: " + money.NominalMoney());
            Console.WriteLine("Копiйки:");
            Console.WriteLine("Номiнал: " + money.NominalMoney());
        }   
    }   
}
