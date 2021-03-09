using System;
using System.Collections.Generic;
using System.Text;

namespace номінали
{
    struct Coins
    {
        private double oneCent, twoCent, fiveCent, tenCent, twentyFiveCent, fiftyCent;
        public Coins(double oneCent, double twoCent, double fiveCent,
        double tenCent, double twentyFiveCent, double fiftyCent)
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
}
