using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jagjit_Singh_Final
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //This will hide Splash form
            this.Hide();
            //This will stop timer of the splash form or it will continue and at every 3000 ms event is trigerred again and again
            timer1.Stop();
            // main form object is created 
            StartForm main = new StartForm();
            // GenerateNameForm show
            main.Show();


        }

        private void SplashScreen_Load_1(object sender, EventArgs e)
        {

        }
    }
}
