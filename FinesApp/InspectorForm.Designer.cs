namespace FinesApp
{
    partial class InspectorForm
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
            this.protocols_button = new System.Windows.Forms.Button();
            this.violations_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.read_info_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // protocols_button
            // 
            this.protocols_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protocols_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.protocols_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocols_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.protocols_button.Location = new System.Drawing.Point(84, 117);
            this.protocols_button.Margin = new System.Windows.Forms.Padding(10);
            this.protocols_button.Name = "protocols_button";
            this.protocols_button.Padding = new System.Windows.Forms.Padding(10);
            this.protocols_button.Size = new System.Drawing.Size(294, 80);
            this.protocols_button.TabIndex = 8;
            this.protocols_button.Text = "Протоколы";
            this.protocols_button.UseVisualStyleBackColor = true;
            this.protocols_button.Click += new System.EventHandler(this.protocols_button_Click);
            // 
            // violations_button
            // 
            this.violations_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.violations_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.violations_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violations_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.violations_button.Location = new System.Drawing.Point(398, 117);
            this.violations_button.Margin = new System.Windows.Forms.Padding(10);
            this.violations_button.Name = "violations_button";
            this.violations_button.Padding = new System.Windows.Forms.Padding(10);
            this.violations_button.Size = new System.Drawing.Size(294, 80);
            this.violations_button.TabIndex = 9;
            this.violations_button.Text = "Нарушения";
            this.violations_button.UseVisualStyleBackColor = true;
            this.violations_button.Click += new System.EventHandler(this.volations_button_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.read_info_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.protocols_button);
            this.panel2.Controls.Add(this.violations_button);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 566);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Product Sans Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(1254, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "Панель Инспектора ГИБДД";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Crimson;
            this.exitButton.Location = new System.Drawing.Point(1125, 22);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 41);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Выйти";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(78, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Изменяемые данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(78, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дополнительная информация";
            // 
            // read_info_button
            // 
            this.read_info_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.read_info_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.read_info_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.read_info_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.read_info_button.Location = new System.Drawing.Point(84, 335);
            this.read_info_button.Margin = new System.Windows.Forms.Padding(10);
            this.read_info_button.Name = "read_info_button";
            this.read_info_button.Padding = new System.Windows.Forms.Padding(10);
            this.read_info_button.Size = new System.Drawing.Size(294, 80);
            this.read_info_button.TabIndex = 11;
            this.read_info_button.Text = "Посмотреть";
            this.read_info_button.UseVisualStyleBackColor = true;
            this.read_info_button.Click += new System.EventHandler(this.read_info_button_Click);
            // 
            // InspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "InspectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectorForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button protocols_button;
        private System.Windows.Forms.Button violations_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button read_info_button;
        private System.Windows.Forms.Label label2;
    }
}