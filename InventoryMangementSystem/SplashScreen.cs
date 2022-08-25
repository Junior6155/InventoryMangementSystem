using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangementSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            barProgress.Value = startPoint;
            if (barProgress.Value == 100)
            {
                barProgress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
