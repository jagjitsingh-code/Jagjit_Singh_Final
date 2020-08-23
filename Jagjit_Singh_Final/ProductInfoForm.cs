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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            productidtextBox.Text = Convert.ToString(Program.selectedProduct.productID);
            ConditiontextBox.Text = Convert.ToString(Program.selectedProduct.condition);
            CosttextBox.Text = Convert.ToString(Program.selectedProduct.cost);

            PlatformTextbox.Text = Convert.ToString(Program.selectedProduct.platform);
            OStextBox.Text = Convert.ToString(Program.selectedProduct.OS);
            MnufacturetextBox.Text = Convert.ToString(Program.selectedProduct.manufacturer);
            modeltextBox.Text = Convert.ToString(Program.selectedProduct.model);

            MemorytextBox.Text = Convert.ToString(Program.selectedProduct.RAM_size);
            lcdtextBox.Text = Convert.ToString(Program.selectedProduct.screensize);
            HDDtextBox.Text = Convert.ToString(Program.selectedProduct.HDD_size);

            CpuBrandtextBox.Text = Convert.ToString(Program.selectedProduct.CPU_brand);
            cpunumbertextBox.Text = Convert.ToString(Program.selectedProduct.CPU_number);
            GputextBox.Text = Convert.ToString(Program.selectedProduct.GPU_Type);


            CpuspeedtextBox.Text = Convert.ToString(Program.selectedProduct.CPU_speed);
            CpuTypetextBox.Text = Convert.ToString(Program.selectedProduct.CPU_type);
            WebcamtextBox.Text = Convert.ToString(Program.selectedProduct.webcam);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm main = new OrderForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Program.FinalProduct = new Model.product();

            Program.FinalProduct.productID = short.Parse(productidtextBox.Text);
            Program.FinalProduct.condition = Convert.ToString(ConditiontextBox.Text);
            Program.FinalProduct.cost = Decimal.Parse(CosttextBox.Text);
            Program.FinalProduct.platform = Convert.ToString(PlatformTextbox.Text);
            Program.FinalProduct.OS = Convert.ToString(OStextBox.Text);
            Program.FinalProduct.manufacturer = Convert.ToString(MnufacturetextBox.Text);
            Program.FinalProduct.model = Convert.ToString(modeltextBox.Text);
            Program.FinalProduct.RAM_size = Convert.ToString(MemorytextBox.Text);
            Program.FinalProduct.screensize = Convert.ToString(lcdtextBox.Text);
            Program.FinalProduct.HDD_size = Convert.ToString(HDDtextBox.Text);
            Program.FinalProduct.CPU_brand = Convert.ToString(CpuBrandtextBox.Text);
            Program.FinalProduct.CPU_number = Convert.ToString(cpunumbertextBox.Text);
            Program.FinalProduct.GPU_Type = Convert.ToString(GputextBox.Text);
            Program.FinalProduct.CPU_speed = Convert.ToString(CpuspeedtextBox.Text);
            Program.FinalProduct.GPU_Type = Convert.ToString(GputextBox.Text);
            Program.FinalProduct.CPU_speed = Convert.ToString(CpuspeedtextBox.Text);
            Program.FinalProduct.CPU_type = Convert.ToString(CpuTypetextBox.Text);
            Program.FinalProduct.webcam = Convert.ToString(WebcamtextBox.Text);




            nextButton.Enabled = true;



        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var disp = new SelectForm();
            disp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var disp = new SelectForm();
            disp.Show();
        }
    }
}
