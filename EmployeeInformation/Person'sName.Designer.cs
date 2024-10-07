namespace EmployeeInformation
{
    partial class Person_sName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            firstNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            showButton = new Button();
            label4 = new Label();
            fullNameTextBox = new TextBox();
            label5 = new Label();
            reverseNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 78);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Middle Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 129);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(234, 24);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(222, 31);
            firstNameTextBox.TabIndex = 3;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(234, 72);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(222, 31);
            middleNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(234, 129);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(222, 31);
            lastNameTextBox.TabIndex = 5;
            // 
            // showButton
            // 
            showButton.BackColor = SystemColors.ActiveBorder;
            showButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showButton.Location = new Point(493, 120);
            showButton.Name = "showButton";
            showButton.Size = new Size(112, 47);
            showButton.TabIndex = 6;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 199);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 7;
            label4.Text = "Full Name";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(234, 193);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(512, 31);
            fullNameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 246);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 9;
            label5.Text = "Reverse Name";
            // 
            // reverseNameTextBox
            // 
            reverseNameTextBox.Location = new Point(234, 245);
            reverseNameTextBox.Name = "reverseNameTextBox";
            reverseNameTextBox.Size = new Size(512, 31);
            reverseNameTextBox.TabIndex = 10;
            // 
            // Person_sName
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 323);
            Controls.Add(reverseNameTextBox);
            Controls.Add(label5);
            Controls.Add(fullNameTextBox);
            Controls.Add(label4);
            Controls.Add(showButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(middleNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Person_sName";
            Text = "Person_s Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox lastNameTextBox;
        private Button showButton;
        private Label label4;
        private TextBox fullNameTextBox;
        private Label label5;
        private TextBox reverseNameTextBox;
    }
}