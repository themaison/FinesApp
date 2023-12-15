namespace FinesApp
{
    partial class DriverAuthForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.to_back_button = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.driverLoginButton = new System.Windows.Forms.Button();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.to_back_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // to_back_button
            // 
            this.to_back_button.AutoSize = true;
            this.to_back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_back_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_back_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.to_back_button.Location = new System.Drawing.Point(22, 22);
            this.to_back_button.Name = "to_back_button";
            this.to_back_button.Size = new System.Drawing.Size(53, 41);
            this.to_back_button.TabIndex = 13;
            this.to_back_button.Text = "<-";
            this.to_back_button.Click += new System.EventHandler(this.to_back_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Product Sans Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(1254, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Водитель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.registerLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.driverLoginButton);
            this.panel2.Controls.Add(this.licenseNumberTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 566);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Product Sans", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerLabel.Location = new System.Drawing.Point(645, 372);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(206, 26);
            this.registerLabel.TabIndex = 4;
            this.registerLabel.Text = "Зарегистрироваться";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(366, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Еще не зарегистрированы? ";
            // 
            // driverLoginButton
            // 
            this.driverLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driverLoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.driverLoginButton.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverLoginButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.driverLoginButton.Location = new System.Drawing.Point(362, 272);
            this.driverLoginButton.Name = "driverLoginButton";
            this.driverLoginButton.Size = new System.Drawing.Size(517, 80);
            this.driverLoginButton.TabIndex = 2;
            this.driverLoginButton.Text = "Войти";
            this.driverLoginButton.UseVisualStyleBackColor = true;
            this.driverLoginButton.Click += new System.EventHandler(this.driverLoginButton_Click);
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Font = new System.Drawing.Font("Product Sans Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licenseNumberTextBox.Location = new System.Drawing.Point(362, 165);
            this.licenseNumberTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.licenseNumberTextBox.MinimumSize = new System.Drawing.Size(4, 80);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.licenseNumberTextBox.Size = new System.Drawing.Size(517, 85);
            this.licenseNumberTextBox.TabIndex = 1;
            this.licenseNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseNumberTextBox.TextChanged += new System.EventHandler(this.licenseNumberTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(355, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер в/у";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DriverAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DriverAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverAuthForm";
            this.Load += new System.EventHandler(this.DriverAuthForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button driverLoginButton;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label to_back_button;
    }
}