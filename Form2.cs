using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSSIANROULETTE_GAME
{
    public partial class Form2 : Form
    {
        Form myform = new RUSSIANROULETTE_GAME();
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myform.Show();
            //new Form().Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
