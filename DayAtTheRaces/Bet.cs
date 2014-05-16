using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Bet
    {
        public int amount;// amount being bet
        public int numDog;// dog being bet on
        public String gambler;// name of person placing bet

        //used to update the labels under "Bets"
        public String getDiscription()
        {
            if (amount == 0)// when bets not placed
            {
                return "" + gambler + " has not placed a bet";
            }
            else// when bet is placed
            {
                return gambler + " has bet $" + amount + " on dog " + numDog;
            }
        }

        // determines whether or not money should be payed back or kept
        public int payOut(int winningDogNumber)
        {
            if (numDog == winningDogNumber)// money payed
            {
                return amount;
            }
            else//money kept 
            {
                return -amount;
            }
        }
    }
}
