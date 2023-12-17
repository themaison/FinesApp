namespace FinesApp
{
    partial class DriverPaymentForm
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
            this.fine_cost_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.violation_place_label = new System.Windows.Forms.Label();
            this.violation_time_label = new System.Windows.Forms.Label();
            this.violation_date_label = new System.Windows.Forms.Label();
            this.sts_number_label = new System.Windows.Forms.Label();
            this.violation_name_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.violation_id_label = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.fine_cost_label);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.status_label);
            this.panel2.Controls.Add(this.payButton);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.violation_place_label);
            this.panel2.Controls.Add(this.violation_time_label);
            this.panel2.Controls.Add(this.violation_date_label);
            this.panel2.Controls.Add(this.sts_number_label);
            this.panel2.Controls.Add(this.violation_name_label);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 566);
            this.panel2.TabIndex = 7;
            // 
            // fine_cost_label
            // 
            this.fine_cost_label.AutoSize = true;
            this.fine_cost_label.Font = new System.Drawing.Font("Product Sans Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fine_cost_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fine_cost_label.Location = new System.Drawing.Point(316, 430);
            this.fine_cost_label.Name = "fine_cost_label";
            this.fine_cost_label.Size = new System.Drawing.Size(174, 61);
            this.fine_cost_label.TabIndex = 14;
            this.fine_cost_label.Text = "1000₽";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(76, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 34);
            this.label14.TabIndex = 13;
            this.label14.Text = "Сумма штрафа";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status_label.Location = new System.Drawing.Point(321, 313);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(85, 34);
            this.status_label.TabIndex = 12;
            this.status_label.Text = "Текст";
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payButton.Location = new System.Drawing.Point(902, 422);
            this.payButton.Margin = new System.Windows.Forms.Padding(10);
            this.payButton.Name = "payButton";
            this.payButton.Padding = new System.Windows.Forms.Padding(10);
            this.payButton.Size = new System.Drawing.Size(280, 80);
            this.payButton.TabIndex = 11;
            this.payButton.Text = "Оплатить";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(76, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 34);
            this.label12.TabIndex = 10;
            this.label12.Text = "Статус";
            // 
            // violation_place_label
            // 
            this.violation_place_label.AutoSize = true;
            this.violation_place_label.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violation_place_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.violation_place_label.Location = new System.Drawing.Point(321, 265);
            this.violation_place_label.Name = "violation_place_label";
            this.violation_place_label.Size = new System.Drawing.Size(85, 34);
            this.violation_place_label.TabIndex = 9;
            this.violation_place_label.Text = "Текст";
            // 
            // violation_time_label
            // 
            this.violation_time_label.AutoSize = true;
            this.violation_time_label.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violation_time_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.violation_time_label.Location = new System.Drawing.Point(322, 210);
            this.violation_time_label.Name = "violation_time_label";
            this.violation_time_label.Size = new System.Drawing.Size(85, 34);
            this.violation_time_label.TabIndex = 8;
            this.violation_time_label.Text = "Текст";
            // 
            // violation_date_label
            // 
            this.violation_date_label.AutoSize = true;
            this.violation_date_label.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violation_date_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.violation_date_label.Location = new System.Drawing.Point(321, 158);
            this.violation_date_label.Name = "violation_date_label";
            this.violation_date_label.Size = new System.Drawing.Size(85, 34);
            this.violation_date_label.TabIndex = 7;
            this.violation_date_label.Text = "Текст";
            // 
            // sts_number_label
            // 
            this.sts_number_label.AutoSize = true;
            this.sts_number_label.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sts_number_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sts_number_label.Location = new System.Drawing.Point(321, 100);
            this.sts_number_label.Name = "sts_number_label";
            this.sts_number_label.Size = new System.Drawing.Size(85, 34);
            this.sts_number_label.TabIndex = 6;
            this.sts_number_label.Text = "Текст";
            // 
            // violation_name_label
            // 
            this.violation_name_label.AutoSize = true;
            this.violation_name_label.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violation_name_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.violation_name_label.Location = new System.Drawing.Point(321, 43);
            this.violation_name_label.Name = "violation_name_label";
            this.violation_name_label.Size = new System.Drawing.Size(85, 34);
            this.violation_name_label.TabIndex = 5;
            this.violation_name_label.Text = "Текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(76, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Место";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(77, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(76, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(76, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Номер СТС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(76, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Нарушение";
            // 
            // violation_id_label
            // 
            this.violation_id_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.violation_id_label.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violation_id_label.Location = new System.Drawing.Point(0, 0);
            this.violation_id_label.Margin = new System.Windows.Forms.Padding(0);
            this.violation_id_label.Name = "violation_id_label";
            this.violation_id_label.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.violation_id_label.Size = new System.Drawing.Size(1254, 80);
            this.violation_id_label.TabIndex = 6;
            this.violation_id_label.Text = "ID Нарушения";
            this.violation_id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // to_back_button
            // 
            this.to_back_button.AutoSize = true;
            this.to_back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_back_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_back_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.to_back_button.Location = new System.Drawing.Point(25, 22);
            this.to_back_button.Name = "to_back_button";
            this.to_back_button.Size = new System.Drawing.Size(53, 41);
            this.to_back_button.TabIndex = 12;
            this.to_back_button.Text = "<-";
            this.to_back_button.Click += new System.EventHandler(this.to_back_button_Click);
            // 
            // DriverPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.to_back_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.violation_id_label);
            this.Name = "DriverPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverPaymentForm";
            this.Load += new System.EventHandler(this.DriverPaymentForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label violation_id_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label violation_place_label;
        private System.Windows.Forms.Label violation_time_label;
        private System.Windows.Forms.Label violation_date_label;
        private System.Windows.Forms.Label sts_number_label;
        private System.Windows.Forms.Label violation_name_label;
        private System.Windows.Forms.Label fine_cost_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label to_back_button;
    }
}