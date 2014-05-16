using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox myPictureBox;
        public Random Randomizer;

        public bool Run()
        {
            // generate a random amount of space to move forward between 1 & 4 pixels
            int moveForward = Randomizer.Next(1, 4);
            
            // get current position of picturebox and update the x coordinate
            Point temp = myPictureBox.Location;
            temp.X += moveForward;
            myPictureBox.Location = temp;
           
            // Check to see if the finish line has been crossed
            if (myPictureBox.Location.X >= RaceTrackLength)
            {
                return true;// finish line crossed
            }
            else
            {
                return false;// finish line not crossed
            }
        }

        // go back to the starting line
        public void ReturnToStart()
        {
            Point startingLine= myPictureBox.Location;
            startingLine.X = StartingPosition;//value of Dog1.Location.X at beginning of race.
            myPictureBox.Location = startingLine;// return to starting line
        }
    }
}
