using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GunShotGame
{
    public partial class Form1 : Form
    {
        LogicClass GunLogic = new LogicClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(GunShotGame.Resource1.lload);
            sp.Play();
            pictureBox1.Image = GunShotGame.Resource1.load;
            GunLogic.LoadGun();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(GunShotGame.Resource1.sspin);
            sp.Play();
            pictureBox1.Image = GunShotGame.Resource1.spin;
            GunLogic.SpinGun();
        }

      

        private void Fire_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(GunShotGame.Resource1.fire);
            sp.Play();
            pictureBox1.Image = GunShotGame.Resource1.shoot;
            GunLogic.FireGun();
        }

        private void FireAway_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(GunShotGame.Resource1.fire);
            sp.Play();
            pictureBox1.Image = GunShotGame.Resource1.shoot2;
            GunLogic.FireAwayGun();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
