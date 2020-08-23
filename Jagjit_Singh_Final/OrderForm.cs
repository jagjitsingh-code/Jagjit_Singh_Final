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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox2 aboutWindow = new AboutBox2();
            aboutWindow.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            ProductInfoForm main = new ProductInfoForm();
            main.Show();

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // productidtextBox.Text = Convert.ToString(Program.selectedProduct.productID);
              Condition_textBox.Text = Convert.ToString(Program.FinalProduct.condition);
              Price_textBox.Text = Convert.ToString(Program.selectedProduct.cost);

              Double price = Double.Parse(Convert.ToString(Program.selectedProduct.cost));
              Sales_textBox.Text = Convert.ToString(price * 0.13);
              Textbox_Total.Text = Convert.ToString((price * 0.13)+ price);

              Platform_textBox.Text = Convert.ToString(Program.FinalProduct.platform);
            //OStextBox.Text = Convert.ToString(Program.selectedProduct.OS);
             Manufacture_textBox.Text = Convert.ToString(Program.FinalProduct.manufacturer);
             Model_textBox.Text = Convert.ToString(Program.FinalProduct.model);

              memory_textBox.Text = Convert.ToString(Program.FinalProduct.RAM_size);
              LCD_textBox.Text = Convert.ToString(Program.FinalProduct.screensize);
            //HDDtextBox.Text = Convert.ToString(Program.selectedProduct.HDD_size);

             CpuBrand_textBox.Text = Convert.ToString(Program.FinalProduct.CPU_brand);
             Cpunumber_textBox.Text = Convert.ToString(Program.FinalProduct.CPU_number);
            //GputextBox.Text = Convert.ToString(Program.selectedProduct.GPU_Type);


            //CpuspeedtextBox.Text = Convert.ToString(Program.selectedProduct.CPU_speed);
            CpuType_textBox.Text = Convert.ToString(Program.FinalProduct.CPU_type);
            Webcam_textBox.Text = Convert.ToString(Program.FinalProduct.webcam);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Your Selection is printed", "Print");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            ProductInfoForm main = new ProductInfoForm();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string message = "Thanks for doing Business with us and order will be processed in 7 - 10 business days";
            string title = "Finish";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
         
           



            
        }

        private void Webcam_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
