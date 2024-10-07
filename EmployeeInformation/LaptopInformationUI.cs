using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class LaptopInformationUI : Form
    {
        Laptop anLaptop = new Laptop();
        public LaptopInformationUI()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveAndClearButton_Click(object sender, EventArgs e)
        {
            anLaptop.brandName = brandNameTextBox.Text;
            anLaptop.ram = Convert.ToInt32(ramTextBox.Text);
            anLaptop.processor = Convert.ToInt32(processorTextBox.Text);

            brandNameTextBox.Text = "";
            ramTextBox.Text = "";
            processorTextBox.Text = "";
            isAppropriateTextBox.Text = "";

        }

        private void ShowButtion_Click(object sender, EventArgs e)
        {
            brandNameTextBox.Text = anLaptop.brandName;
            ramTextBox.Text = anLaptop.ram.ToString();
            processorTextBox.Text = anLaptop.processor.ToString();
            isAppropriateTextBox.Text = anLaptop.isAppropriate(anLaptop.ram, anLaptop.processor);
        }

        private void LaptopInformationUI_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the world of Laptop");
        }
    }
}
