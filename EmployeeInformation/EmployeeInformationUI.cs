namespace EmployeeInformation
{
    public partial class EmployeeInformationUI : Form
    {
        Employee anEmployee = new Employee();
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        private void EmployeeInformationUI_Load(object sender, EventArgs e)
        {

        }

        private void SaveAndClearButton_Click(object sender, EventArgs e)
        {
            anEmployee.id = idTextBox.Text;
            anEmployee.name = nameTextBox.Text;
            anEmployee.salaryAmount = Convert.ToDouble(salaryAmountTextBox.Text);

            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryAmountTextBox.Text = "";
        }

        private void ShowSavedDataButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = anEmployee.id;
            nameTextBox.Text = anEmployee.name;
            salaryAmountTextBox.Text = anEmployee.salaryAmount.ToString();
        }

        private void isPunctualButon_Click(object sender, EventArgs e)
        {
            string info = anEmployee.GetInfoAboutEmployee();
            MessageBox.Show(info);
        }
    }
}

