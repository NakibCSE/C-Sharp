namespace EmployeeInformation
{
    partial class EmployeeInformationUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            salaryAmountTextBox = new TextBox();
            SaveAndClearButton = new Button();
            ShowSavedDataButton = new Button();
            isPunctualButon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 80);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 118);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 167);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 2;
            label3.Text = "Salary Amount";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(248, 77);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(255, 31);
            idTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(248, 118);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(255, 31);
            nameTextBox.TabIndex = 4;
            // 
            // salaryAmountTextBox
            // 
            salaryAmountTextBox.Location = new Point(248, 167);
            salaryAmountTextBox.Name = "salaryAmountTextBox";
            salaryAmountTextBox.Size = new Size(255, 31);
            salaryAmountTextBox.TabIndex = 5;
            // 
            // SaveAndClearButton
            // 
            SaveAndClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveAndClearButton.Location = new Point(72, 225);
            SaveAndClearButton.Name = "SaveAndClearButton";
            SaveAndClearButton.Size = new Size(249, 54);
            SaveAndClearButton.TabIndex = 6;
            SaveAndClearButton.Text = "Save and Clear";
            SaveAndClearButton.UseVisualStyleBackColor = true;
            SaveAndClearButton.Click += SaveAndClearButton_Click;
            // 
            // ShowSavedDataButton
            // 
            ShowSavedDataButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowSavedDataButton.Location = new Point(360, 225);
            ShowSavedDataButton.Name = "ShowSavedDataButton";
            ShowSavedDataButton.Size = new Size(249, 54);
            ShowSavedDataButton.TabIndex = 7;
            ShowSavedDataButton.Text = "Show Saved Data";
            ShowSavedDataButton.UseVisualStyleBackColor = true;
            ShowSavedDataButton.Click += ShowSavedDataButton_Click;
            // 
            // isPunctualButon
            // 
            isPunctualButon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isPunctualButon.Location = new Point(230, 309);
            isPunctualButon.Name = "isPunctualButon";
            isPunctualButon.Size = new Size(249, 54);
            isPunctualButon.TabIndex = 8;
            isPunctualButon.Text = "is Punctual ?";
            isPunctualButon.UseVisualStyleBackColor = true;
            isPunctualButon.Click += isPunctualButon_Click;
            // 
            // EmployeeInformationUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 392);
            Controls.Add(isPunctualButon);
            Controls.Add(ShowSavedDataButton);
            Controls.Add(SaveAndClearButton);
            Controls.Add(salaryAmountTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeInformationUI";
            Text = "EmployeeInformationUI";
            Load += EmployeeInformationUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox salaryAmountTextBox;
        private Button SaveAndClearButton;
        private Button ShowSavedDataButton;
        private Button isPunctualButon;
    }
}
