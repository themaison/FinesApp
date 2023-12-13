namespace FinesApp
{
    partial class DriverForm
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
            this.info_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.protocol_more_button = new System.Windows.Forms.Button();
            this.protocolDGV = new System.Windows.Forms.DataGridView();
            this.protocol_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sts_number2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleDGV = new System.Windows.Forms.DataGridView();
            this.sts_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_manufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile_button = new System.Windows.Forms.Button();
            this.full_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protocolDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.info_button);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.protocol_more_button);
            this.panel2.Controls.Add(this.protocolDGV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.vehicleDGV);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 736);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // info_button
            // 
            this.info_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.info_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.info_button.Location = new System.Drawing.Point(32, 633);
            this.info_button.Margin = new System.Windows.Forms.Padding(4);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(232, 81);
            this.info_button.TabIndex = 8;
            this.info_button.Text = "Информация";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(544, 658);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "*Выберите протокол из списка";
            // 
            // protocol_more_button
            // 
            this.protocol_more_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protocol_more_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.protocol_more_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocol_more_button.ForeColor = System.Drawing.SystemColors.InfoText;
            this.protocol_more_button.Location = new System.Drawing.Point(974, 633);
            this.protocol_more_button.Margin = new System.Windows.Forms.Padding(4);
            this.protocol_more_button.Name = "protocol_more_button";
            this.protocol_more_button.Size = new System.Drawing.Size(238, 81);
            this.protocol_more_button.TabIndex = 6;
            this.protocol_more_button.Text = "Посмотреть";
            this.protocol_more_button.UseVisualStyleBackColor = true;
            this.protocol_more_button.Click += new System.EventHandler(this.protocol_more_button_Click);
            // 
            // protocolDGV
            // 
            this.protocolDGV.AllowUserToAddRows = false;
            this.protocolDGV.AllowUserToDeleteRows = false;
            this.protocolDGV.AllowUserToResizeColumns = false;
            this.protocolDGV.AllowUserToResizeRows = false;
            this.protocolDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.protocolDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.protocol_id,
            this.violation_name,
            this.sts_number2,
            this.violation_date,
            this.violation_time,
            this.violation_place,
            this.status_name});
            this.protocolDGV.Location = new System.Drawing.Point(32, 362);
            this.protocolDGV.Margin = new System.Windows.Forms.Padding(4);
            this.protocolDGV.Name = "protocolDGV";
            this.protocolDGV.ReadOnly = true;
            this.protocolDGV.RowHeadersWidth = 82;
            this.protocolDGV.RowTemplate.Height = 33;
            this.protocolDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.protocolDGV.Size = new System.Drawing.Size(1180, 240);
            this.protocolDGV.TabIndex = 3;
            // 
            // protocol_id
            // 
            this.protocol_id.DataPropertyName = "protocol_id";
            this.protocol_id.HeaderText = "ID Протокола";
            this.protocol_id.MinimumWidth = 10;
            this.protocol_id.Name = "protocol_id";
            this.protocol_id.ReadOnly = true;
            this.protocol_id.Visible = false;
            this.protocol_id.Width = 200;
            // 
            // violation_name
            // 
            this.violation_name.DataPropertyName = "violation_name";
            this.violation_name.HeaderText = "Нарушение";
            this.violation_name.MinimumWidth = 10;
            this.violation_name.Name = "violation_name";
            this.violation_name.ReadOnly = true;
            this.violation_name.Width = 200;
            // 
            // sts_number2
            // 
            this.sts_number2.DataPropertyName = "sts_number";
            this.sts_number2.HeaderText = "Номер СТС";
            this.sts_number2.MinimumWidth = 10;
            this.sts_number2.Name = "sts_number2";
            this.sts_number2.ReadOnly = true;
            this.sts_number2.Width = 140;
            // 
            // violation_date
            // 
            this.violation_date.DataPropertyName = "violation_date";
            this.violation_date.HeaderText = "Дата";
            this.violation_date.MinimumWidth = 10;
            this.violation_date.Name = "violation_date";
            this.violation_date.ReadOnly = true;
            this.violation_date.Width = 200;
            // 
            // violation_time
            // 
            this.violation_time.DataPropertyName = "violation_time";
            this.violation_time.HeaderText = "Время";
            this.violation_time.MinimumWidth = 10;
            this.violation_time.Name = "violation_time";
            this.violation_time.ReadOnly = true;
            this.violation_time.Width = 200;
            // 
            // violation_place
            // 
            this.violation_place.DataPropertyName = "violation_place";
            this.violation_place.HeaderText = "Место";
            this.violation_place.MinimumWidth = 10;
            this.violation_place.Name = "violation_place";
            this.violation_place.ReadOnly = true;
            this.violation_place.Width = 200;
            // 
            // status_name
            // 
            this.status_name.DataPropertyName = "status_name";
            this.status_name.HeaderText = "Статус оплаты";
            this.status_name.MinimumWidth = 10;
            this.status_name.Name = "status_name";
            this.status_name.ReadOnly = true;
            this.status_name.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(26, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Протоколы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Транспорт";
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
            this.license_number,
            this.brand,
            this.model,
            this.year_of_manufacture});
            this.vehicleDGV.Location = new System.Drawing.Point(32, 58);
            this.vehicleDGV.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleDGV.Name = "vehicleDGV";
            this.vehicleDGV.ReadOnly = true;
            this.vehicleDGV.RowHeadersWidth = 80;
            this.vehicleDGV.RowTemplate.Height = 33;
            this.vehicleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleDGV.Size = new System.Drawing.Size(1180, 240);
            this.vehicleDGV.TabIndex = 0;
            this.vehicleDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.state_number.Width = 140;
            // 
            // license_number
            // 
            this.license_number.DataPropertyName = "license_number";
            this.license_number.HeaderText = "Номер в/у";
            this.license_number.MinimumWidth = 10;
            this.license_number.Name = "license_number";
            this.license_number.ReadOnly = true;
            this.license_number.Visible = false;
            this.license_number.Width = 200;
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
            this.year_of_manufacture.Width = 140;
            // 
            // profile_button
            // 
            this.profile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.profile_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profile_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profile_button.Location = new System.Drawing.Point(1032, 2);
            this.profile_button.Margin = new System.Windows.Forms.Padding(4);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(180, 81);
            this.profile_button.TabIndex = 9;
            this.profile_button.Text = "Профиль";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.full_name_label.Location = new System.Drawing.Point(24, 17);
            this.full_name_label.Margin = new System.Windows.Forms.Padding(0);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(432, 47);
            this.full_name_label.TabIndex = 4;
            this.full_name_label.Text = "Имя Фамилия Отчество\r\n";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.full_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(900, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выйти";
            this.label1.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 819);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.full_name_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1280, 890);
            this.MinimumSize = new System.Drawing.Size(1280, 890);
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverForm";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protocolDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.DataGridView vehicleDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView protocolDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button protocol_more_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_manufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_number2;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_name;
    }
}