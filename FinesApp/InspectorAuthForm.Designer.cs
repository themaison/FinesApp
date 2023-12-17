namespace FinesApp
{
    partial class InspectorAuthForm
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
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.to_back_button = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.passTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.authButton);
            this.panel2.Controls.Add(this.loginTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 566);
            this.panel2.TabIndex = 5;
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(363, 256);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.passTextBox.MaximumSize = new System.Drawing.Size(517, 80);
            this.passTextBox.MinimumSize = new System.Drawing.Size(517, 80);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passTextBox.Size = new System.Drawing.Size(517, 80);
            this.passTextBox.TabIndex = 6;
            this.passTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(356, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль";
            // 
            // authButton
            // 
            this.authButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.authButton.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.authButton.Location = new System.Drawing.Point(362, 401);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(517, 80);
            this.authButton.TabIndex = 2;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(363, 105);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.loginTextBox.MaximumSize = new System.Drawing.Size(517, 80);
            this.loginTextBox.MinimumSize = new System.Drawing.Size(517, 80);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginTextBox.Size = new System.Drawing.Size(517, 80);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(356, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин";
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
            this.label1.TabIndex = 4;
            this.label1.Text = "Инспектор ГИБДД";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.to_back_button.TabIndex = 14;
            this.to_back_button.Text = "<-";
            this.to_back_button.Click += new System.EventHandler(this.to_back_button_Click);
            // 
            // InspectorAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.to_back_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "InspectorAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectorAuthForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label to_back_button;
    }
}