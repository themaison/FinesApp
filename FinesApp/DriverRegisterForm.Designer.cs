namespace FinesApp
{
    partial class DriverRegisterForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.licenseValidityDatePicker = new System.Windows.Forms.DateTimePicker();
            this.licenseIssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.driverRegisterButton = new System.Windows.Forms.Button();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.licenseValidityDatePicker);
            this.panel2.Controls.Add(this.licenseIssueDatePicker);
            this.panel2.Controls.Add(this.birthDatePicker);
            this.panel2.Controls.Add(this.femaleRB);
            this.panel2.Controls.Add(this.maleRB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.fioTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.driverRegisterButton);
            this.panel2.Controls.Add(this.licenseNumberTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 606);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // licenseValidityDatePicker
            // 
            this.licenseValidityDatePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.licenseValidityDatePicker.Font = new System.Drawing.Font("Product Sans", 12.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licenseValidityDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.licenseValidityDatePicker.Location = new System.Drawing.Point(654, 370);
            this.licenseValidityDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.licenseValidityDatePicker.MinimumSize = new System.Drawing.Size(4, 40);
            this.licenseValidityDatePicker.Name = "licenseValidityDatePicker";
            this.licenseValidityDatePicker.Size = new System.Drawing.Size(360, 47);
            this.licenseValidityDatePicker.TabIndex = 17;
            this.licenseValidityDatePicker.ValueChanged += new System.EventHandler(this.licenseValidityDatePicker_ValueChanged);
            // 
            // licenseIssueDatePicker
            // 
            this.licenseIssueDatePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.licenseIssueDatePicker.Font = new System.Drawing.Font("Product Sans", 12.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licenseIssueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.licenseIssueDatePicker.Location = new System.Drawing.Point(260, 370);
            this.licenseIssueDatePicker.Margin = new System.Windows.Forms.Padding(10);
            this.licenseIssueDatePicker.MinimumSize = new System.Drawing.Size(4, 40);
            this.licenseIssueDatePicker.Name = "licenseIssueDatePicker";
            this.licenseIssueDatePicker.Size = new System.Drawing.Size(360, 47);
            this.licenseIssueDatePicker.TabIndex = 16;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.birthDatePicker.Font = new System.Drawing.Font("Product Sans", 12.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDatePicker.Location = new System.Drawing.Point(654, 218);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(10);
            this.birthDatePicker.MinimumSize = new System.Drawing.Size(4, 40);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(360, 47);
            this.birthDatePicker.TabIndex = 15;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Font = new System.Drawing.Font("Product Sans", 12.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleRB.Location = new System.Drawing.Point(260, 264);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(194, 46);
            this.femaleRB.TabIndex = 14;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "Женщина";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.Font = new System.Drawing.Font("Product Sans", 12.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleRB.Location = new System.Drawing.Point(261, 218);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(187, 46);
            this.maleRB.TabIndex = 13;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Мужчина";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(649, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "Срок действия в/у";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(255, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата выдачи в/у";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(649, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата рождения";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(254, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пол";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fioTextBox
            // 
            this.fioTextBox.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextBox.Location = new System.Drawing.Point(654, 83);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.fioTextBox.Multiline = true;
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fioTextBox.Size = new System.Drawing.Size(360, 80);
            this.fioTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(649, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // driverRegisterButton
            // 
            this.driverRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driverRegisterButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.driverRegisterButton.Font = new System.Drawing.Font("Product Sans", 12.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverRegisterButton.Location = new System.Drawing.Point(260, 494);
            this.driverRegisterButton.Name = "driverRegisterButton";
            this.driverRegisterButton.Size = new System.Drawing.Size(753, 80);
            this.driverRegisterButton.TabIndex = 2;
            this.driverRegisterButton.Text = "Зарегистрироваться";
            this.driverRegisterButton.UseVisualStyleBackColor = true;
            this.driverRegisterButton.Click += new System.EventHandler(this.driverRegisterButtonClick);
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licenseNumberTextBox.Location = new System.Drawing.Point(260, 83);
            this.licenseNumberTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.licenseNumberTextBox.Multiline = true;
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.licenseNumberTextBox.Size = new System.Drawing.Size(360, 80);
            this.licenseNumberTextBox.TabIndex = 1;
            this.licenseNumberTextBox.TextChanged += new System.EventHandler(this.licenseNumberTextBox_TextChanged);
            this.licenseNumberTextBox.Enter += new System.EventHandler(this.licenseNumberEnter);
            this.licenseNumberTextBox.Leave += new System.EventHandler(this.licenseNumberLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(255, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер в/у";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(1254, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Водитель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "DriverRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverRegisterForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button driverRegisterButton;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.DateTimePicker licenseValidityDatePicker;
        private System.Windows.Forms.DateTimePicker licenseIssueDatePicker;
    }
}