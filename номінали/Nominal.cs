using System;
using System.Collections.Generic;
using System.Text;

namespace номінали
{
    class Nominal
    {
        private Money getMoney;
        private Coins getCoin;
        private SumOfMoney sumOfMoney;
        public Nominal(Money getMoney,Coins getCoin)
        {
            this.getMoney = getMoney;
            this.getCoin = getCoin;
            sumOfMoney.grn = getMoney.NominalMoney();
            sumOfMoney.sumOfCoins = getCoin.NominalCoins();
        }

        public SumOfMoney GetSumObject { get; }
        public double AllNominal()
        {
            return getMoney.NominalMoney() + getCoin.NominalCoins();
        }

        public double GetSum()
        {
            return sumOfMoney.grn + sumOfMoney.sumOfCoins;
        }

        public static bool operator ==(Nominal obj1, Nominal obj2)
        {
            return (obj1.GetSum() == obj2.GetSum());

        }

        public static bool operator !=(Nominal obj1, Nominal obj2)
        {
            return (obj1.GetSum() != obj2.GetSum());
        }

        public static SumOfMoney operator +(Nominal obj1, Nominal obj2)
        {
            SumOfMoney sumOfMoney = new SumOfMoney();
            sumOfMoney.grn = obj1.sumOfMoney.grn + obj2.sumOfMoney.grn;
            sumOfMoney.sumOfCoins = obj1.sumOfMoney.sumOfCoins + obj2.sumOfMoney.sumOfCoins;
            if (sumOfMoney.sumOfCoins>100)
            {
                sumOfMoney.grn++;
                double caseForCoins = -100;
                sumOfMoney.sumOfCoins =caseForCoins;
            }
            return sumOfMoney;
        }

        public static SumOfMoney operator -(Nominal obj1, Nominal obj2)
        {
            SumOfMoney sumOfMoney = new SumOfMoney();
          
            sumOfMoney.grn = obj1.sumOfMoney.grn - obj2.sumOfMoney.grn;
            sumOfMoney.sumOfCoins = obj1.sumOfMoney.sumOfCoins - obj2.sumOfMoney.sumOfCoins;
            if (sumOfMoney.sumOfCoins<0)
            {
                double v = -1;
                sumOfMoney.grn = v;
                double v1 = 100;
                sumOfMoney.sumOfCoins = v1;
            }
            return sumOfMoney;
        }

        public static double operator *(Nominal obj1, Nominal obj2)
        {
           double sumOfMoney = obj1.sumOfMoney.grn*100 + obj1.sumOfMoney.sumOfCoins;
           double sumOfMoney2 = obj2.sumOfMoney.grn*100 + obj2.sumOfMoney.sumOfCoins;
            return sumOfMoney*sumOfMoney2;
        }

        public static double operator /(Nominal obj1, Nominal obj2)
        {
            double getSumOfNominal = obj1.sumOfMoney.grn*100 + obj1.sumOfMoney.sumOfCoins;
            double getSumOfNominal2 = obj2.sumOfMoney.grn*100 + obj2.sumOfMoney.sumOfCoins;
            if (getSumOfNominal2 == 0)
                return 0;
            return getSumOfNominal / getSumOfNominal2;
        }
    }
}
