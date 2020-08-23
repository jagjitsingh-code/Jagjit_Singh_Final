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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var disp = new SelectForm();
            disp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var disp = new ProductInfoForm();
            disp.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //    b.Add a button control that gives the user an option to load a saved order.The button will hide StartForm, 
        // show ProductInfoForm and display an OpenFileDialog box that allows the user to load a previously saved file.The OpenFileDialog Method will be contained in the



    }
}
