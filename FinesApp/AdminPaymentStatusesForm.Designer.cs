﻿namespace FinesApp
{
    partial class AdminPaymentStatusesForm
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
            this.insert_payment_status_box = new System.Windows.Forms.GroupBox();
            this.insert_cancel_box_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_box_button = new System.Windows.Forms.Button();
            this.insert_tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentStatusDGV = new System.Windows.Forms.DataGridView();
            this.status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to_back_button = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.update_payment_status_box = new System.Windows.Forms.GroupBox();
            this.update_cancel_box_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.update_box_button = new System.Windows.Forms.Button();
            this.update_tb1 = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.full_name_label = new System.Windows.Forms.Label();
            this.insert_payment_status_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.update_payment_status_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_payment_status_box
            // 
            this.insert_payment_status_box.BackColor = System.Drawing.Color.LightGray;
            this.insert_payment_status_box.Controls.Add(this.insert_cancel_box_button);
            this.insert_payment_status_box.Controls.Add(this.label1);
            this.insert_payment_status_box.Controls.Add(this.insert_box_button);
            this.insert_payment_status_box.Controls.Add(this.insert_tb1);
            this.insert_payment_status_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_payment_status_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_payment_status_box.Location = new System.Drawing.Point(32, 356);
            this.insert_payment_status_box.Name = "insert_payment_status_box";
            this.insert_payment_status_box.Size = new System.Drawing.Size(714, 264);
            this.insert_payment_status_box.TabIndex = 2;
            this.insert_payment_status_box.TabStop = false;
            this.insert_payment_status_box.Text = "Добавление";
            // 
            // insert_cancel_box_button
            // 
            this.insert_cancel_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.insert_cancel_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_cancel_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_cancel_box_button.Location = new System.Drawing.Point(18, 164);
            this.insert_cancel_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_cancel_box_button.Name = "insert_cancel_box_button";
            this.insert_cancel_box_button.Size = new System.Drawing.Size(327, 80);
            this.insert_cancel_box_button.TabIndex = 17;
            this.insert_cancel_box_button.Text = "Отмена";
            this.insert_cancel_box_button.UseVisualStyleBackColor = true;
            this.insert_cancel_box_button.Click += new System.EventHandler(this.insert_cancel_box_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Наименование статуса";
            // 
            // insert_box_button
            // 
            this.insert_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.insert_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_box_button.Location = new System.Drawing.Point(369, 164);
            this.insert_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_box_button.Name = "insert_box_button";
            this.insert_box_button.Size = new System.Drawing.Size(327, 80);
            this.insert_box_button.TabIndex = 13;
            this.insert_box_button.Text = "Добавить";
            this.insert_box_button.UseVisualStyleBackColor = true;
            this.insert_box_button.Click += new System.EventHandler(this.insert_box_button_Click);
            // 
            // insert_tb1
            // 
            this.insert_tb1.Location = new System.Drawing.Point(18, 86);
            this.insert_tb1.Name = "insert_tb1";
            this.insert_tb1.Size = new System.Drawing.Size(327, 40);
            this.insert_tb1.TabIndex = 0;
            this.insert_tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insert_tb1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Статусы оплат";
            // 
            // paymentStatusDGV
            // 
            this.paymentStatusDGV.AllowUserToAddRows = false;
            this.paymentStatusDGV.AllowUserToDeleteRows = false;
            this.paymentStatusDGV.AllowUserToResizeColumns = false;
            this.paymentStatusDGV.AllowUserToResizeRows = false;
            this.paymentStatusDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentStatusDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentStatusDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status_id,
            this.status_name});
            this.paymentStatusDGV.Location = new System.Drawing.Point(32, 58);
            this.paymentStatusDGV.Margin = new System.Windows.Forms.Padding(4);
            this.paymentStatusDGV.Name = "paymentStatusDGV";
            this.paymentStatusDGV.ReadOnly = true;
            this.paymentStatusDGV.RowHeadersWidth = 80;
            this.paymentStatusDGV.RowTemplate.Height = 33;
            this.paymentStatusDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentStatusDGV.Size = new System.Drawing.Size(1180, 280);
            this.paymentStatusDGV.TabIndex = 0;
            this.paymentStatusDGV.SelectionChanged += new System.EventHandler(this.paymentStatusDGV_SelectionChanged);
            // 
            // status_id
            // 
            this.status_id.DataPropertyName = "status_id";
            this.status_id.HeaderText = "ID Статуса";
            this.status_id.MinimumWidth = 10;
            this.status_id.Name = "status_id";
            this.status_id.ReadOnly = true;
            this.status_id.Width = 200;
            // 
            // status_name
            // 
            this.status_name.DataPropertyName = "status_name";
            this.status_name.HeaderText = "Наименование статуса";
            this.status_name.MinimumWidth = 10;
            this.status_name.Name = "status_name";
            this.status_name.ReadOnly = true;
            this.status_name.Width = 320;
            // 
            // to_back_button
            // 
            this.to_back_button.AutoSize = true;
            this.to_back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_back_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_back_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.to_back_button.Location = new System.Drawing.Point(25, 22);
            this.to_back_button.Name = "to_back_button";
            this.to_back_button.Size = new System.Drawing.Size(60, 41);
            this.to_back_button.TabIndex = 19;
            this.to_back_button.Text = "<- ";
            this.to_back_button.Click += new System.EventHandler(this.to_back_button_Click);
            // 
            // update_button
            // 
            this.update_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.update_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.update_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_button.Location = new System.Drawing.Point(844, 1);
            this.update_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(180, 80);
            this.update_button.TabIndex = 16;
            this.update_button.Text = "Изменить";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.ForeColor = System.Drawing.Color.Crimson;
            this.delete_button.Location = new System.Drawing.Point(1032, 1);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(180, 80);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.update_payment_status_box);
            this.panel2.Controls.Add(this.insert_payment_status_box);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.paymentStatusDGV);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 646);
            this.panel2.TabIndex = 18;
            // 
            // update_payment_status_box
            // 
            this.update_payment_status_box.BackColor = System.Drawing.Color.LightGray;
            this.update_payment_status_box.Controls.Add(this.update_cancel_box_button);
            this.update_payment_status_box.Controls.Add(this.label3);
            this.update_payment_status_box.Controls.Add(this.update_box_button);
            this.update_payment_status_box.Controls.Add(this.update_tb1);
            this.update_payment_status_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_payment_status_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_payment_status_box.Location = new System.Drawing.Point(32, 356);
            this.update_payment_status_box.Name = "update_payment_status_box";
            this.update_payment_status_box.Size = new System.Drawing.Size(714, 264);
            this.update_payment_status_box.TabIndex = 3;
            this.update_payment_status_box.TabStop = false;
            this.update_payment_status_box.Text = "Изменение";
            // 
            // update_cancel_box_button
            // 
            this.update_cancel_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.update_cancel_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_cancel_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_cancel_box_button.Location = new System.Drawing.Point(18, 164);
            this.update_cancel_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_cancel_box_button.Name = "update_cancel_box_button";
            this.update_cancel_box_button.Size = new System.Drawing.Size(327, 80);
            this.update_cancel_box_button.TabIndex = 17;
            this.update_cancel_box_button.Text = "Отмена";
            this.update_cancel_box_button.UseVisualStyleBackColor = true;
            this.update_cancel_box_button.Click += new System.EventHandler(this.update_cancel_box_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Наименование статуса";
            // 
            // update_box_button
            // 
            this.update_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.update_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_box_button.Location = new System.Drawing.Point(369, 164);
            this.update_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_box_button.Name = "update_box_button";
            this.update_box_button.Size = new System.Drawing.Size(327, 80);
            this.update_box_button.TabIndex = 13;
            this.update_box_button.Text = "Изменить";
            this.update_box_button.UseVisualStyleBackColor = true;
            this.update_box_button.Click += new System.EventHandler(this.update_box_button_Click);
            // 
            // update_tb1
            // 
            this.update_tb1.Location = new System.Drawing.Point(18, 86);
            this.update_tb1.Name = "update_tb1";
            this.update_tb1.Size = new System.Drawing.Size(327, 40);
            this.update_tb1.TabIndex = 0;
            this.update_tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.update_tb1_KeyPress);
            // 
            // insert_button
            // 
            this.insert_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.insert_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_button.Location = new System.Drawing.Point(656, 1);
            this.insert_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(180, 80);
            this.insert_button.TabIndex = 15;
            this.insert_button.Text = "Добавить";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.full_name_label.Location = new System.Drawing.Point(88, 17);
            this.full_name_label.Margin = new System.Windows.Forms.Padding(0);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(452, 47);
            this.full_name_label.TabIndex = 17;
            this.full_name_label.Text = "Таблица: Payment Status";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminPaymentStatusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 729);
            this.Controls.Add(this.to_back_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.full_name_label);
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "AdminPaymentStatusesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPaymentStatusesForm";
            this.Load += new System.EventHandler(this.AdminPaymentStatusesForm_Load);
            this.insert_payment_status_box.ResumeLayout(false);
            this.insert_payment_status_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.update_payment_status_box.ResumeLayout(false);
            this.update_payment_status_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox insert_payment_status_box;
        private System.Windows.Forms.Button insert_cancel_box_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_box_button;
        private System.Windows.Forms.TextBox insert_tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView paymentStatusDGV;
        private System.Windows.Forms.Label to_back_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.GroupBox update_payment_status_box;
        private System.Windows.Forms.Button update_cancel_box_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update_box_button;
        private System.Windows.Forms.TextBox update_tb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_name;
    }
}