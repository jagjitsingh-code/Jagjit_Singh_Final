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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet1.products);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.


            if (dataGridView1.SelectedRows.Count != 0)
            {
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            var manufacturer = row.Cells[2].Value;
            var model = row.Cells[3].Value;
            var cost = row.Cells[1].Value;

                var ff = manufacturer.ToString() + " " + model.ToString() + " " + cost.ToString();

                ManufacturerTextBox.Text = ff;
                Program.selectedProduct = new Model.product();
                Program.selectedProduct.productID = short.Parse((row.Cells[0].Value).ToString());
                Program.selectedProduct.cost = decimal.Parse((row.Cells[1].Value).ToString());
                Program.selectedProduct.manufacturer = (row.Cells[2].Value).ToString();
                Program.selectedProduct.model = (row.Cells[3].Value).ToString();
                Program.selectedProduct.condition = (row.Cells[14].Value).ToString();
                Program.selectedProduct.platform = (row.Cells[16].Value).ToString(); 
                Program.selectedProduct.OS = (row.Cells[15].Value).ToString();
                Program.selectedProduct.RAM_size = (row.Cells[5].Value).ToString();
                Program.selectedProduct.CPU_brand = (row.Cells[10].Value).ToString();
                Program.selectedProduct.CPU_type = (row.Cells[11].Value).ToString();
                Program.selectedProduct.screensize = (row.Cells[7].Value).ToString();
                Program.selectedProduct.CPU_number = (row.Cells[13].Value).ToString();
                Program.selectedProduct.CPU_speed = (row.Cells[12].Value).ToString();
                Program.selectedProduct.HDD_size = (row.Cells[17].Value).ToString();
                Program.selectedProduct.webcam = (row.Cells[30].Value).ToString();
                Program.selectedProduct.GPU_Type = (row.Cells[19].Value).ToString();

                nextButton.Enabled = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm main = new ProductInfoForm();
            main.Show();
        }
    }
}
