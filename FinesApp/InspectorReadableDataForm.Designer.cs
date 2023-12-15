namespace FinesApp
{
    partial class InspectorReadableDataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to_back_button = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.driverDGV = new System.Windows.Forms.DataGridView();
            this.vehicleDGV = new System.Windows.Forms.DataGridView();
            this.paymentStatusDGV = new System.Windows.Forms.DataGridView();
            this.license_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sts_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_manufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.paymentStatusDGV);
            this.panel2.Controls.Add(this.vehicleDGV);
            this.panel2.Controls.Add(this.driverDGV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 1047);
            this.panel2.TabIndex = 9;
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
            this.label1.TabIndex = 8;
            this.label1.Text = "Просмотр данных ГИБДД";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Транспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Водители";
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
            this.to_back_button.TabIndex = 15;
            this.to_back_button.Text = "<-";
            this.to_back_button.Click += new System.EventHandler(this.to_back_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(23, 639);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Статусы оплат";
            // 
            // driverDGV
            // 
            this.driverDGV.AllowUserToAddRows = false;
            this.driverDGV.AllowUserToDeleteRows = false;
            this.driverDGV.AllowUserToResizeColumns = false;
            this.driverDGV.AllowUserToResizeRows = false;
            this.driverDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driverDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.license_number,
            this.full_name,
            this.gender,
            this.birth_date,
            this.license_issue_date,
            this.license_validity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.driverDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.driverDGV.Location = new System.Drawing.Point(29, 68);
            this.driverDGV.Margin = new System.Windows.Forms.Padding(4);
            this.driverDGV.Name = "driverDGV";
            this.driverDGV.ReadOnly = true;
            this.driverDGV.RowHeadersWidth = 80;
            this.driverDGV.RowTemplate.Height = 33;
            this.driverDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driverDGV.Size = new System.Drawing.Size(1180, 240);
            this.driverDGV.TabIndex = 10;
            // 
            // vehicleDGV
            // 
            this.vehicleDGV.AllowUserToAddRows = false;
            this.vehicleDGV.AllowUserToDeleteRows = false;
            this.vehicleDGV.AllowUserToResizeColumns = false;
            this.vehicleDGV.AllowUserToResizeRows = false;
            this.vehicleDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehicleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sts_number,
            this.state_number,
            this.dataGridViewTextBoxColumn2,
            this.brand,
            this.model,
            this.year_of_manufacture});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vehicleDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.vehicleDGV.Location = new System.Drawing.Point(29, 370);
            this.vehicleDGV.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleDGV.Name = "vehicleDGV";
            this.vehicleDGV.ReadOnly = true;
            this.vehicleDGV.RowHeadersWidth = 80;
            this.vehicleDGV.RowTemplate.Height = 33;
            this.vehicleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleDGV.Size = new System.Drawing.Size(1180, 240);
            this.vehicleDGV.TabIndex = 11;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymentStatusDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.paymentStatusDGV.Location = new System.Drawing.Point(29, 677);
            this.paymentStatusDGV.Margin = new System.Windows.Forms.Padding(4);
            this.paymentStatusDGV.Name = "paymentStatusDGV";
            this.paymentStatusDGV.ReadOnly = true;
            this.paymentStatusDGV.RowHeadersWidth = 80;
            this.paymentStatusDGV.RowTemplate.Height = 33;
            this.paymentStatusDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentStatusDGV.Size = new System.Drawing.Size(1180, 240);
            this.paymentStatusDGV.TabIndex = 12;
            // 
            // license_number
            // 
            this.license_number.DataPropertyName = "license_number";
            this.license_number.HeaderText = "Номер в/у";
            this.license_number.MinimumWidth = 10;
            this.license_number.Name = "license_number";
            this.license_number.ReadOnly = true;
            this.license_number.Width = 140;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "ФИО";
            this.full_name.MinimumWidth = 10;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 200;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Пол";
            this.gender.MinimumWidth = 10;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // birth_date
            // 
            this.birth_date.DataPropertyName = "birth_date";
            this.birth_date.HeaderText = "Дата рождения";
            this.birth_date.MinimumWidth = 10;
            this.birth_date.Name = "birth_date";
            this.birth_date.ReadOnly = true;
            this.birth_date.Width = 140;
            // 
            // license_issue_date
            // 
            this.license_issue_date.DataPropertyName = "license_issue_date";
            this.license_issue_date.HeaderText = "Дата выдачи в/у";
            this.license_issue_date.MinimumWidth = 10;
            this.license_issue_date.Name = "license_issue_date";
            this.license_issue_date.ReadOnly = true;
            this.license_issue_date.Width = 140;
            // 
            // license_validity
            // 
            this.license_validity.DataPropertyName = "license_validity";
            this.license_validity.HeaderText = "Срок действия в/у";
            this.license_validity.MinimumWidth = 10;
            this.license_validity.Name = "license_validity";
            this.license_validity.ReadOnly = true;
            this.license_validity.Width = 140;
            // 
            // sts_number
            // 
            this.sts_number.DataPropertyName = "sts_number";
            this.sts_number.HeaderText = "Номер СТС";
            this.sts_number.MinimumWidth = 10;
            this.sts_number.Name = "sts_number";
            this.sts_number.ReadOnly = true;
            this.sts_number.Width = 140;
            // 
            // state_number
            // 
            this.state_number.DataPropertyName = "state_number";
            this.state_number.HeaderText = "Госномер";
            this.state_number.MinimumWidth = 10;
            this.state_number.Name = "state_number";
            this.state_number.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "license_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер в/у";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Марка";
            this.brand.MinimumWidth = 10;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 140;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Модель";
            this.model.MinimumWidth = 10;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 140;
            // 
            // year_of_manufacture
            // 
            this.year_of_manufacture.DataPropertyName = "year_of_manufacture";
            this.year_of_manufacture.HeaderText = "Год выпуска";
            this.year_of_manufacture.MinimumWidth = 10;
            this.year_of_manufacture.Name = "year_of_manufacture";
            this.year_of_manufacture.ReadOnly = true;
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
            this.status_name.Width = 340;
            // 
            // InspectorReadableDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 1029);
            this.Controls.Add(this.to_back_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1280, 1100);
            this.MinimumSize = new System.Drawing.Size(1280, 1100);
            this.Name = "InspectorReadableDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectorReadableDataForm";
            this.Load += new System.EventHandler(this.InspectorReadableDataForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label to_back_button;
        private System.Windows.Forms.DataGridView driverDGV;
        private System.Windows.Forms.DataGridView vehicleDGV;
        private System.Windows.Forms.DataGridView paymentStatusDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_manufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_name;
    }
}