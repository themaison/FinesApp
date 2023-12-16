namespace FinesApp
{
    partial class InspectorViolationsForm
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
            this.to_back_button = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.update_violation_box = new System.Windows.Forms.GroupBox();
            this.update_cancel_box_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.update_box_button = new System.Windows.Forms.Button();
            this.update_tb2 = new System.Windows.Forms.TextBox();
            this.update_tb1 = new System.Windows.Forms.TextBox();
            this.insert_violation_box = new System.Windows.Forms.GroupBox();
            this.insert_cancel_box_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_box_button = new System.Windows.Forms.Button();
            this.insert_tb2 = new System.Windows.Forms.TextBox();
            this.insert_tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.violationDGV = new System.Windows.Forms.DataGridView();
            this.insert_button = new System.Windows.Forms.Button();
            this.full_name_label = new System.Windows.Forms.Label();
            this.violation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.update_violation_box.SuspendLayout();
            this.insert_violation_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.violationDGV)).BeginInit();
            this.SuspendLayout();
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
            this.to_back_button.TabIndex = 25;
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
            this.update_button.TabIndex = 22;
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
            this.delete_button.TabIndex = 20;
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
            this.panel2.Controls.Add(this.update_violation_box);
            this.panel2.Controls.Add(this.insert_violation_box);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.violationDGV);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 646);
            this.panel2.TabIndex = 24;
            // 
            // update_violation_box
            // 
            this.update_violation_box.BackColor = System.Drawing.Color.LightGray;
            this.update_violation_box.Controls.Add(this.update_cancel_box_button);
            this.update_violation_box.Controls.Add(this.label4);
            this.update_violation_box.Controls.Add(this.label5);
            this.update_violation_box.Controls.Add(this.update_box_button);
            this.update_violation_box.Controls.Add(this.update_tb2);
            this.update_violation_box.Controls.Add(this.update_tb1);
            this.update_violation_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_violation_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_violation_box.Location = new System.Drawing.Point(32, 356);
            this.update_violation_box.Name = "update_violation_box";
            this.update_violation_box.Size = new System.Drawing.Size(714, 254);
            this.update_violation_box.TabIndex = 18;
            this.update_violation_box.TabStop = false;
            this.update_violation_box.Text = "Изменение";
            // 
            // update_cancel_box_button
            // 
            this.update_cancel_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.update_cancel_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_cancel_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_cancel_box_button.Location = new System.Drawing.Point(18, 152);
            this.update_cancel_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_cancel_box_button.Name = "update_cancel_box_button";
            this.update_cancel_box_button.Size = new System.Drawing.Size(327, 80);
            this.update_cancel_box_button.TabIndex = 17;
            this.update_cancel_box_button.Text = "Отмена";
            this.update_cancel_box_button.UseVisualStyleBackColor = true;
            this.update_cancel_box_button.Click += new System.EventHandler(this.update_cancel_box_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(363, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Сумма штрафа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "Наименование";
            // 
            // update_box_button
            // 
            this.update_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.update_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_box_button.Location = new System.Drawing.Point(369, 152);
            this.update_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_box_button.Name = "update_box_button";
            this.update_box_button.Size = new System.Drawing.Size(327, 80);
            this.update_box_button.TabIndex = 13;
            this.update_box_button.Text = "Изменить";
            this.update_box_button.UseVisualStyleBackColor = true;
            this.update_box_button.Click += new System.EventHandler(this.update_box_button_Click);
            // 
            // update_tb2
            // 
            this.update_tb2.Location = new System.Drawing.Point(369, 86);
            this.update_tb2.Name = "update_tb2";
            this.update_tb2.Size = new System.Drawing.Size(327, 40);
            this.update_tb2.TabIndex = 1;
            // 
            // update_tb1
            // 
            this.update_tb1.Location = new System.Drawing.Point(18, 86);
            this.update_tb1.Name = "update_tb1";
            this.update_tb1.Size = new System.Drawing.Size(327, 40);
            this.update_tb1.TabIndex = 0;
            // 
            // insert_violation_box
            // 
            this.insert_violation_box.BackColor = System.Drawing.Color.LightGray;
            this.insert_violation_box.Controls.Add(this.insert_cancel_box_button);
            this.insert_violation_box.Controls.Add(this.label3);
            this.insert_violation_box.Controls.Add(this.label1);
            this.insert_violation_box.Controls.Add(this.insert_box_button);
            this.insert_violation_box.Controls.Add(this.insert_tb2);
            this.insert_violation_box.Controls.Add(this.insert_tb1);
            this.insert_violation_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_violation_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_violation_box.Location = new System.Drawing.Point(32, 356);
            this.insert_violation_box.Name = "insert_violation_box";
            this.insert_violation_box.Size = new System.Drawing.Size(714, 254);
            this.insert_violation_box.TabIndex = 2;
            this.insert_violation_box.TabStop = false;
            this.insert_violation_box.Text = "Добавление";
            // 
            // insert_cancel_box_button
            // 
            this.insert_cancel_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.insert_cancel_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_cancel_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_cancel_box_button.Location = new System.Drawing.Point(18, 152);
            this.insert_cancel_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_cancel_box_button.Name = "insert_cancel_box_button";
            this.insert_cancel_box_button.Size = new System.Drawing.Size(327, 80);
            this.insert_cancel_box_button.TabIndex = 17;
            this.insert_cancel_box_button.Text = "Отмена";
            this.insert_cancel_box_button.UseVisualStyleBackColor = true;
            this.insert_cancel_box_button.Click += new System.EventHandler(this.insert_cancel_box_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(363, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сумма штрафа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Наименование";
            // 
            // insert_box_button
            // 
            this.insert_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.insert_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_box_button.Location = new System.Drawing.Point(369, 152);
            this.insert_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_box_button.Name = "insert_box_button";
            this.insert_box_button.Size = new System.Drawing.Size(327, 80);
            this.insert_box_button.TabIndex = 13;
            this.insert_box_button.Text = "Добавить";
            this.insert_box_button.UseVisualStyleBackColor = true;
            this.insert_box_button.Click += new System.EventHandler(this.insert_box_button_Click);
            // 
            // insert_tb2
            // 
            this.insert_tb2.Location = new System.Drawing.Point(369, 86);
            this.insert_tb2.Name = "insert_tb2";
            this.insert_tb2.Size = new System.Drawing.Size(327, 40);
            this.insert_tb2.TabIndex = 1;
            // 
            // insert_tb1
            // 
            this.insert_tb1.Location = new System.Drawing.Point(18, 86);
            this.insert_tb1.Name = "insert_tb1";
            this.insert_tb1.Size = new System.Drawing.Size(327, 40);
            this.insert_tb1.TabIndex = 0;
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
            this.violationDGV.ReadOnly = true;
            this.violationDGV.RowHeadersWidth = 80;
            this.violationDGV.RowTemplate.Height = 33;
            this.violationDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.violationDGV.Size = new System.Drawing.Size(1180, 280);
            this.violationDGV.TabIndex = 0;
            this.violationDGV.SelectionChanged += new System.EventHandler(this.violationDGV_SelectionChanged);
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
            this.insert_button.TabIndex = 21;
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
            this.full_name_label.Size = new System.Drawing.Size(337, 47);
            this.full_name_label.TabIndex = 23;
            this.full_name_label.Text = "Таблица: Violation\r\n";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // violation_id
            // 
            this.violation_id.DataPropertyName = "violation_id";
            this.violation_id.HeaderText = "ID Нарушения";
            this.violation_id.MinimumWidth = 10;
            this.violation_id.Name = "violation_id";
            this.violation_id.ReadOnly = true;
            this.violation_id.Width = 140;
            // 
            // violation_name
            // 
            this.violation_name.DataPropertyName = "violation_name";
            this.violation_name.HeaderText = "Наименование нарушения";
            this.violation_name.MinimumWidth = 10;
            this.violation_name.Name = "violation_name";
            this.violation_name.ReadOnly = true;
            this.violation_name.Width = 340;
            // 
            // fine_amount
            // 
            this.fine_amount.DataPropertyName = "fine_amount";
            this.fine_amount.HeaderText = "Сумма штрафа";
            this.fine_amount.MinimumWidth = 10;
            this.fine_amount.Name = "fine_amount";
            this.fine_amount.ReadOnly = true;
            this.fine_amount.Width = 140;
            // 
            // InspectorViolationsForm
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
            this.Name = "InspectorViolationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectorViolationsForm";
            this.Load += new System.EventHandler(this.InspectorViolationsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.update_violation_box.ResumeLayout(false);
            this.update_violation_box.PerformLayout();
            this.insert_violation_box.ResumeLayout(false);
            this.insert_violation_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.violationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label to_back_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox update_violation_box;
        private System.Windows.Forms.Button update_cancel_box_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_box_button;
        private System.Windows.Forms.TextBox update_tb2;
        private System.Windows.Forms.TextBox update_tb1;
        private System.Windows.Forms.GroupBox insert_violation_box;
        private System.Windows.Forms.Button insert_cancel_box_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_box_button;
        private System.Windows.Forms.TextBox insert_tb2;
        private System.Windows.Forms.TextBox insert_tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView violationDGV;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine_amount;
    }
}