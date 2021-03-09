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
            return sumOfMoney;
        }
        public static SumOfMoney operator -(Nominal obj1, Nominal obj2)
        {
            SumOfMoney sumOfMoney = new SumOfMoney();
            sumOfMoney.grn = obj1.sumOfMoney.grn - obj2.sumOfMoney.grn;
            sumOfMoney.sumOfCoins = obj1.sumOfMoney.sumOfCoins - obj2.sumOfMoney.sumOfCoins;
            return sumOfMoney;
        }
        public static SumOfMoney operator *(Nominal obj1, Nominal obj2)
        {
            SumOfMoney sumOfMoney = new SumOfMoney();
            sumOfMoney.grn = obj1.sumOfMoney.grn * obj2.sumOfMoney.grn;
            sumOfMoney.sumOfCoins = obj1.sumOfMoney.sumOfCoins * obj2.sumOfMoney.sumOfCoins;
            return sumOfMoney;
        }
        public static SumOfMoney operator /(Nominal obj1, Nominal obj2)
        {
            SumOfMoney sumOfMoney = new SumOfMoney();
            sumOfMoney.grn = obj1.sumOfMoney.grn / obj2.sumOfMoney.grn;
            sumOfMoney.sumOfCoins = obj1.sumOfMoney.sumOfCoins / obj2.sumOfMoney.sumOfCoins;
            return sumOfMoney;
        }
    }
        
    
}
