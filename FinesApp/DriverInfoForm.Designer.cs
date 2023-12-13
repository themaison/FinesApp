namespace FinesApp
{
    partial class DriverInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.to_back_button = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paymentStatusDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.violationDGV = new System.Windows.Forms.DataGridView();
            this.status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Product Sans Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(1254, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация ГИБДД";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // to_back_button
            // 
            this.to_back_button.AutoSize = true;
            this.to_back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_back_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_back_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.to_back_button.Location = new System.Drawing.Point(31, 31);
            this.to_back_button.Name = "to_back_button";
            this.to_back_button.Size = new System.Drawing.Size(149, 41);
            this.to_back_button.TabIndex = 12;
            this.to_back_button.Text = "<- Назад";
            this.to_back_button.Click += new System.EventHandler(this.to_back_button_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.paymentStatusDGV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.violationDGV);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 676);
            this.panel2.TabIndex = 13;
            // 
            // paymentStatusDGV
            // 
            this.paymentStatusDGV.AllowUserToAddRows = false;
            this.paymentStatusDGV.AllowUserToDeleteRows = false;
            this.paymentStatusDGV.AllowUserToResizeColumns = false;
            this.paymentStatusDGV.AllowUserToResizeRows = false;
            this.paymentStatusDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentStatusDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status_id,
            this.status_name});
            this.paymentStatusDGV.Location = new System.Drawing.Point(32, 448);
            this.paymentStatusDGV.Margin = new System.Windows.Forms.Padding(4);
            this.paymentStatusDGV.Name = "paymentStatusDGV";
            this.paymentStatusDGV.RowHeadersWidth = 82;
            this.paymentStatusDGV.RowTemplate.Height = 33;
            this.paymentStatusDGV.Size = new System.Drawing.Size(1180, 200);
            this.paymentStatusDGV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(26, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статусы оплаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нарушения";
            // 
            // violationDGV
            // 
            this.violationDGV.AllowUserToAddRows = false;
            this.violationDGV.AllowUserToDeleteRows = false;
            this.violationDGV.AllowUserToResizeColumns = false;
            this.violationDGV.AllowUserToResizeRows = false;
            this.violationDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.violationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.violationDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.violation_id,
            this.violation_name,
            this.fine_amount});
            this.violationDGV.Location = new System.Drawing.Point(32, 58);
            this.violationDGV.Margin = new System.Windows.Forms.Padding(4);
            this.violationDGV.Name = "violationDGV";
            this.violationDGV.RowHeadersWidth = 80;
            this.violationDGV.RowTemplate.Height = 33;
            this.violationDGV.Size = new System.Drawing.Size(1180, 320);
            this.violationDGV.TabIndex = 0;
            // 
            // status_id
            // 
            this.status_id.DataPropertyName = "status_id";
            this.status_id.HeaderText = "ID Статуса";
            this.status_id.MinimumWidth = 10;
            this.status_id.Name = "status_id";
            this.status_id.Width = 200;
            // 
            // status_name
            // 
            this.status_name.DataPropertyName = "status_name";
            this.status_name.HeaderText = "Наименование";
            this.status_name.MinimumWidth = 10;
            this.status_name.Name = "status_name";
            this.status_name.Width = 340;
            // 
            // violation_id
            // 
            this.violation_id.DataPropertyName = "violation_id";
            this.violation_id.HeaderText = "ID Нарушения";
            this.violation_id.MinimumWidth = 10;
            this.violation_id.Name = "violation_id";
            this.violation_id.Width = 80;
            // 
            // violation_name
            // 
            this.violation_name.DataPropertyName = "violation_name";
            this.violation_name.HeaderText = "Наименование";
            this.violation_name.MinimumWidth = 10;
            this.violation_name.Name = "violation_name";
            this.violation_name.Width = 340;
            // 
            // fine_amount
            // 
            this.fine_amount.DataPropertyName = "fine_amount";
            this.fine_amount.HeaderText = "Сумма штрафа";
            this.fine_amount.MinimumWidth = 10;
            this.fine_amount.Name = "fine_amount";
            // 
            // DriverInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 769);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.to_back_button);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1280, 840);
            this.MinimumSize = new System.Drawing.Size(1280, 840);
            this.Name = "DriverInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverInfoForm";
            this.Load += new System.EventHandler(this.DriverInfoForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label to_back_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView paymentStatusDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView violationDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine_amount;
    }
}