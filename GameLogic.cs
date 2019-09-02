using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace RUSSIANROULETTE_GAME
{
    public class GameLogic
    {
        public int RNDNumber { get; set; }
        public string win { get; set; }
        public string lose { get; set; }
        public int Shoot_button { get; set; }
        public int ShootAway_button { get; set; } = 2;
        public int winscore { get; set; } = 0;
        public int losescore { get; set; } = 0;
        public string Messageboxgame { get; set; }



        public int RNDNumbergenerate()
        {
            Random myrandom = new Random();

            return myrandom.Next(1, 7);
        }
        public string Wingame()
        {
            win = "you won";
            return win;

        }

        public string Losegame()
        {
            lose = "you lose";
            return lose;


        }
        public string Messagebox()
        {
            MessageBox.Show("you won");

            return Messageboxgame;

        }
        public int Shoot()
        {
            Shoot_button++;
            if (Shoot_button > 6)
            {
                MessageBox.Show("you lose");
                
                
                Shoot_button = 0;
            }

            return Shoot_button;


        }

        public int Shootaway(int shootaway)
        {
            ShootAway_button = shootaway;
            ShootAway_button--;
            if (ShootAway_button <= 0)
            {
                MessageBox.Show("you won");
                ShootAway_button = 2;
            }
            return ShootAway_button;
        }

        public int Wins()
        {
            {
                
                MessageBox.Show("you won");
            }
            return winscore;
        }

        public int Loses()
        {
            { 
            MessageBox.Show("you lose");
        }  return losescore;
        }
    }
}
