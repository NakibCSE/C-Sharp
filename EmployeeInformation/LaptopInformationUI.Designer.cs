namespace EmployeeInformation
{
    partial class LaptopInformationUI
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
            brandNameTextBox = new TextBox();
            ramTextBox = new TextBox();
            processorTextBox = new TextBox();
            SaveAndClearButton = new Button();
            ShowButtion = new Button();
            isAppropriateTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 81);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "Brand Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 132);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "RAM (GB) ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 172);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 2;
            label3.Text = "Processor: Core i";
            label3.Click += label3_Click;
            // 
            // brandNameTextBox
            // 
            brandNameTextBox.Location = new Point(217, 81);
            brandNameTextBox.Name = "brandNameTextBox";
            brandNameTextBox.Size = new Size(277, 31);
            brandNameTextBox.TabIndex = 3;
            // 
            // ramTextBox
            // 
            ramTextBox.Location = new Point(217, 126);
            ramTextBox.Name = "ramTextBox";
            ramTextBox.Size = new Size(277, 31);
            ramTextBox.TabIndex = 4;
            // 
            // processorTextBox
            // 
            processorTextBox.Location = new Point(217, 172);
            processorTextBox.Name = "processorTextBox";
            processorTextBox.Size = new Size(277, 31);
            processorTextBox.TabIndex = 5;
            // 
            // SaveAndClearButton
            // 
            SaveAndClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveAndClearButton.Location = new Point(140, 257);
            SaveAndClearButton.Name = "SaveAndClearButton";
            SaveAndClearButton.Size = new Size(186, 47);
            SaveAndClearButton.TabIndex = 6;
            SaveAndClearButton.Text = "Save and Clear";
            SaveAndClearButton.UseVisualStyleBackColor = true;
            SaveAndClearButton.Click += SaveAndClearButton_Click;
            // 
            // ShowButtion
            // 
            ShowButtion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowButtion.Location = new Point(359, 257);
            ShowButtion.Name = "ShowButtion";
            ShowButtion.Size = new Size(186, 47);
            ShowButtion.TabIndex = 7;
            ShowButtion.Text = "Show";
            ShowButtion.UseVisualStyleBackColor = true;
            ShowButtion.Click += ShowButtion_Click;
            // 
            // isAppropriateTextBox
            // 
            isAppropriateTextBox.Location = new Point(92, 214);
            isAppropriateTextBox.Name = "isAppropriateTextBox";
            isAppropriateTextBox.Size = new Size(464, 31);
            isAppropriateTextBox.TabIndex = 8;
            // 
            // LaptopInformationUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 358);
            Controls.Add(isAppropriateTextBox);
            Controls.Add(ShowButtion);
            Controls.Add(SaveAndClearButton);
            Controls.Add(processorTextBox);
            Controls.Add(ramTextBox);
            Controls.Add(brandNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LaptopInformationUI";
            Text = "LaptopInformationUI";
            Load += LaptopInformationUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox brandNameTextBox;
        private TextBox ramTextBox;
        private TextBox processorTextBox;
        private Button SaveAndClearButton;
        private Button ShowButtion;
        private TextBox isAppropriateTextBox;
    }
}