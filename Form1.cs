using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Media;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace RUSSIANROULETTE_GAME
{
    public partial class RUSSIANROULETTE_GAME : Form
    {
        GameLogic GAME = new GameLogic();// Defining the object (GAME) of the GameLogic Class
        public int shootaway = 2;

        public object PicBox_Main { get; private set; }
        public static object Properties { get; private set; }

        public RUSSIANROULETTE_GAME()
        {
            InitializeComponent();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Spin_button.Enabled = false;
            Shoot_button.Enabled = false;
            Shootaway_button.Enabled = false;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RUSSIANROULETTE_GAME.Resources.man.png");
            Bitmap bmp = new Bitmap(myStream);
            man.Image = bmp;

        }


        private void Load_button_Click(object sender, EventArgs e)
        {
            // GAME.Load(); //Calling Load function from GameLogic Class
            Load_button.Enabled = false; // Disabling Load button
            Spin_button.Enabled = true;
            Shoot_button.Enabled = false;

            Shootaway_button.Enabled = false;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RUSSIANROULETTE_GAME.Resources.man.png");
            Bitmap bmp = new Bitmap(myStream);
            //Bitmap bmp = new Bitmap(@"C:\Users\Gagandeep Singh\Documents\GAGAN\RUSSIANROULETTE_GAME\man.png");
            //Bitmap bmp = new Bitmap(@"C:\RUSSIANROULETTE_GAME.Properties.Resources.man1.png");
            gun.Image = bmp;

        }

        private void Spin_button_Click(object sender, EventArgs e)
        {
            // GAME.Spin(); //Calling Spin function from GameLogic Class
            Load_button.Enabled = false;
            Spin_button.Enabled = false;
            Shoot_button.Enabled = true;
            Shootaway_button.Enabled = true;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RUSSIANROULETTE_GAME.Resources.gun01.jpg");
            Bitmap bmp = new Bitmap(myStream);

            gun.Image = bmp;
            SoundPlayer player = new SoundPlayer(Resource1.spinnn);
            player.Play();
            GAME.RNDNumber = GAME.RNDNumbergenerate();
        }

        private void Shoot_button_Click(object sender, EventArgs e)
        {
           // GAME.Shoot(); //Calling Shoot function from GameLogic Class
            Load_button.Enabled = false;
            Spin_button.Enabled = false;
            Shoot_button.Enabled = true;
            Shootaway_button.Enabled = true;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RUSSIANROULETTE_GAME.Resources.gun011.jpg");
            Bitmap bmp = new Bitmap(myStream);
            gun.Image = bmp;
            SoundPlayer player = new SoundPlayer(Resource1.gun);
            player.Play();
            GAME.Shoot_button = GAME.Shoot();
            //Shoot_button.Enabled = false;
             lblShots.Text = GAME.Shoot_button.ToString();




            

        }

        private void Shootaway_button_Click(object sender, EventArgs e)
        {
            //GAME.ShootAway_button(); //Calling Shoot Away function from GameLogic Class
            Load_button.Enabled = false;
            Spin_button.Enabled = false;
            Shoot_button.Enabled = true;
            Shootaway_button.Enabled = true;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RUSSIANROULETTE_GAME.Resources.man.png");
            Bitmap bmp = new Bitmap(myStream);
            man.Image = bmp;

            SoundPlayer player = new SoundPlayer(Resource1.gun);
            player.Play();
            GAME.ShootAway_button = GAME.Shootaway(shootaway);
            lbllives.Text = GAME.ShootAway_button.ToString();
            

        }

        private void Playagain_button_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Load_button.Enabled = true;
            Spin_button.Enabled = false;
            Shoot_button.Enabled = false;
            Shootaway_button.Enabled = false;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RUSSIANROULETTE_GAME.Resources.man.png");
            Bitmap bmp = new Bitmap(myStream);
            man.Image = bmp;


        }
        public void endgame_Check()
        {
            if (lblShots.Text == GAME.RNDNumber.ToString())

            {
                GAME.lose = GAME.Losegame();
                lblloses.Text = GAME.lose;
                Shoot_button.Enabled = false;
                Load_button.Enabled = false;
                Spin_button.Enabled = false;
                Playagain_button.Enabled = false;
                GAME.losescore--;
                lblloses.Text = GAME.losescore.ToString();
            }
            else
            {
                GAME.win = GAME.Wingame();
                lblwins.Text = GAME.win;
                Shoot_button.Enabled = false;
                Load_button.Enabled = false;
                Spin_button.Enabled = false;
                Playagain_button.Enabled = false;
                GAME.winscore++;
                lblwins.Text = GAME.winscore.ToString();
            }




        }
        public void loses()
        {
            if (lblShots.Text == GAME.RNDNumber.ToString())
            {
                

                GAME.Messageboxgame = GAME.Messagebox();
                GAME.losescore = GAME.Loses();
                lblloses.Text = GAME.losescore.ToString();
                endgame_Check();
                MessageBox.Show("you lose");
            }
        }

        public void wins()
        {

            GAME.Messageboxgame = GAME.Messagebox();
            GAME.winscore = GAME.Wins();
            lblwin.Text = GAME.winscore.ToString();
            MessageBox.Show("you won");
            endgame_Check();
            


        }

     
        }
    }



