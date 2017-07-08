using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    class Greyhound
    {
        public int StartingPosition = 0;
        public int RacetrackLength = 400;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer = new Random();

        public bool Run()
        {
            //Move forward either 1, 2, 3, 4 spaces at random
            MyPictureBox.Left += Randomizer.Next(1, 5);


        }
    }
}
