using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace GunShotGame
{
    public class LogicClass
    {
        int FireAway = 2;
        int Fire =4 ;
        int Bullet = 0;

        public void LoadGun()
        {
            int Bullet = 3;
        }
        public int SpinGun()

        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7);
            return Bullet;
        }
        public int FireGun()
        {
            if (Bullet == 1)
            {
                //user dead
                MessageBox.Show("user dead!!, play again");
                Application.Restart();
            }
            else
            {
                Fire--;
                Bullet--;
                //chances to fire
                if (Fire == 0)
                {
                    MessageBox.Show("you win", "Game Complete!");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            return Fire;
        }
        
        public int FireAwayGun()
        {
            if (Bullet == 1)
            {
                
                MessageBox.Show("You are still alive.. take a deep breath and continue...");
            }
            else
            {
                FireAway--;
                Bullet--;
                // chances tfor fire away
                if (FireAway == 0)
                {
                    MessageBox.Show("Game Over!!");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Last Chance");
                }
            }

            return FireAway;
        }
   
    }
}


