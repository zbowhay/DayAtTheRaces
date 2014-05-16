using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Guy
    {
		public String name;
        public Bet myBet = new Bet();
        public int cash;
        public RadioButton myRadioButton;
        public Label myLabel;// will show the bet he has placed & which dog he selected
        public bool betPlaced = false;// used to make sure all players have placed a bet before the race begins

        //updates all labels and radioButtons associated with Guy objects
        public void updateLabel()
        {
            myBet.gambler = name;
            myRadioButton.Text = name + " has $" + cash;
            myLabel.Text = myBet.getDiscription();// sets label to show the bet placed
            
            // this is placed here so that if someone can't bet anymore they dont have to click the bet button everytime for the race to continue
            if (cash < 5)
            {
                betPlaced = true; // this way the game can continue even if someone cant bet anymore.
            }
        }

        // handles the placement of bets
        public bool placeBet(int bet, int DogsNumber)
        {
            if (bet <= cash)// makes sure you dont bet more than you own
            {
                myBet.gambler = name;
                myBet.amount = bet;
                myBet.numDog = DogsNumber;
                betPlaced = true;// lets program know that this guy has placed his bet so race can begin.
                return true;// can place bet and have
            }
            else
            {
                return false;// cant place bet
            }
        }

        //reset bet
        public void clearBet()
        {
            myBet.amount = 0;// resets bets
            betPlaced = false;// resets betPlaced
        }

        //collect money/ lose money
        public void Collect(int winningDogNum)
        {
            cash += myBet.payOut(winningDogNum);// adds payout to current amount of cash
        }
    }
}
