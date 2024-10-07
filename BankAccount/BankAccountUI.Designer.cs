namespace BankAccount
{
    partial class BankAccountUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            createButton = new Button();
            accountHolderNameTextBox = new TextBox();
            accountNumberTextBox = new TextBox();
            accountHolderName = new Label();
            accountNumber = new Label();
            groupBox2 = new GroupBox();
            withdrawButton = new Button();
            depositButton = new Button();
            amountLbl = new Label();
            reportButton = new Button();
            amountTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createButton);
            groupBox1.Controls.Add(accountHolderNameTextBox);
            groupBox1.Controls.Add(accountNumberTextBox);
            groupBox1.Controls.Add(accountHolderName);
            groupBox1.Controls.Add(accountNumber);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(43, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Creation";
            // 
            // createButton
            // 
            createButton.BackColor = SystemColors.ActiveBorder;
            createButton.Location = new Point(388, 150);
            createButton.Name = "createButton";
            createButton.Size = new Size(92, 38);
            createButton.TabIndex = 4;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            // 
            // accountHolderNameTextBox
            // 
            accountHolderNameTextBox.Location = new Point(216, 93);
            accountHolderNameTextBox.Name = "accountHolderNameTextBox";
            accountHolderNameTextBox.Size = new Size(266, 31);
            accountHolderNameTextBox.TabIndex = 3;
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Location = new Point(216, 46);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(266, 31);
            accountNumberTextBox.TabIndex = 2;
            // 
            // accountHolderName
            // 
            accountHolderName.AutoSize = true;
            accountHolderName.Location = new Point(20, 99);
            accountHolderName.Name = "accountHolderName";
            accountHolderName.Size = new Size(125, 25);
            accountHolderName.TabIndex = 1;
            accountHolderName.Text = "Holder Name";
            // 
            // accountNumber
            // 
            accountNumber.AutoSize = true;
            accountNumber.Location = new Point(20, 51);
            accountNumber.Name = "accountNumber";
            accountNumber.Size = new Size(157, 25);
            accountNumber.TabIndex = 0;
            accountNumber.Text = "Account Number";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(amountTextBox);
            groupBox2.Controls.Add(withdrawButton);
            groupBox2.Controls.Add(depositButton);
            groupBox2.Controls.Add(amountLbl);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(43, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(527, 169);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transaction";
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = SystemColors.ActiveBorder;
            withdrawButton.Location = new Point(351, 105);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(129, 38);
            withdrawButton.TabIndex = 5;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = false;
            // 
            // depositButton
            // 
            depositButton.BackColor = SystemColors.ActiveBorder;
            depositButton.Location = new Point(216, 105);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(129, 38);
            depositButton.TabIndex = 4;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = false;
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Location = new Point(106, 52);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(81, 25);
            amountLbl.TabIndex = 0;
            amountLbl.Text = "Amount";
            // 
            // reportButton
            // 
            reportButton.BackColor = SystemColors.ActiveBorder;
            reportButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportButton.Location = new Point(168, 443);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(288, 38);
            reportButton.TabIndex = 6;
            reportButton.Text = "Report";
            reportButton.UseVisualStyleBackColor = false;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(224, 46);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(256, 31);
            amountTextBox.TabIndex = 6;
            // 
            // BankAccountUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 530);
            Controls.Add(reportButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "BankAccountUI";
            Text = "Bank Account";
            Load += BankAccountUI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox accountHolderNameTextBox;
        private TextBox accountNumberTextBox;
        private Label accountHolderName;
        private Label accountNumber;
        private Button createButton;
        private GroupBox groupBox2;
        private Button depositButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label amountLbl;
        private Button withdrawButton;
        private Button reportButton;
        private TextBox amountTextBox;
    }
}
