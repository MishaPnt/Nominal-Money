using System;
using System.Collections.Generic;
using System.Text;

namespace номінали
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

}
