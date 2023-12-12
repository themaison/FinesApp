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
            this.profile_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.protocol_more_button = new System.Windows.Forms.Button();
            this.protocolDGV = new System.Windows.Forms.DataGridView();
            this.protocol_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sts_number2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.violationDGV = new System.Windows.Forms.DataGridView();
            this.sts_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_manufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protocolDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.profile_button);
            this.panel2.Controls.Add(this.info_button);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.protocol_more_button);
            this.panel2.Controls.Add(this.protocolDGV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.violationDGV);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 746);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // profile_button
            // 
            this.profile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.profile_button.Font = new System.Drawing.Font("Product Sans", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profile_button.ForeColor = System.Drawing.SystemColors.GrayText;
            this.profile_button.Location = new System.Drawing.Point(218, 637);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(180, 80);
            this.profile_button.TabIndex = 9;
            this.profile_button.Text = "Профиль";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // info_button
            // 
            this.info_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.info_button.Font = new System.Drawing.Font("Product Sans", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_button.ForeColor = System.Drawing.SystemColors.GrayText;
            this.info_button.Location = new System.Drawing.Point(32, 637);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(180, 80);
            this.info_button.TabIndex = 8;
            this.info_button.Text = "Доп. инфа";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(505, 662);
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
            this.protocol_more_button.Location = new System.Drawing.Point(912, 637);
            this.protocol_more_button.Name = "protocol_more_button";
            this.protocol_more_button.Size = new System.Drawing.Size(300, 80);
            this.protocol_more_button.TabIndex = 6;
            this.protocol_more_button.Text = "Изучить протокол";
            this.protocol_more_button.UseVisualStyleBackColor = true;
            this.protocol_more_button.Click += new System.EventHandler(this.protocol_more_button_Click);
            // 
            // protocolDGV
            // 
            this.protocolDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.protocolDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.protocol_id,
            this.violation_id,
            this.sts_number2,
            this.violation_date,
            this.violation_time,
            this.violation_place,
            this.status_id});
            this.protocolDGV.Location = new System.Drawing.Point(32, 351);
            this.protocolDGV.Name = "protocolDGV";
            this.protocolDGV.RowHeadersWidth = 82;
            this.protocolDGV.RowTemplate.Height = 33;
            this.protocolDGV.Size = new System.Drawing.Size(1180, 280);
            this.protocolDGV.TabIndex = 3;
            // 
            // protocol_id
            // 
            this.protocol_id.DataPropertyName = "protocol_id";
            this.protocol_id.HeaderText = "protocol_id";
            this.protocol_id.MinimumWidth = 10;
            this.protocol_id.Name = "protocol_id";
            this.protocol_id.Visible = false;
            this.protocol_id.Width = 200;
            // 
            // violation_id
            // 
            this.violation_id.DataPropertyName = "violation_id";
            this.violation_id.HeaderText = "Нарушение";
            this.violation_id.MinimumWidth = 10;
            this.violation_id.Name = "violation_id";
            this.violation_id.Width = 200;
            // 
            // sts_number2
            // 
            this.sts_number2.DataPropertyName = "sts_number";
            this.sts_number2.HeaderText = "Номер СТС";
            this.sts_number2.MinimumWidth = 10;
            this.sts_number2.Name = "sts_number2";
            this.sts_number2.Width = 200;
            // 
            // violation_date
            // 
            this.violation_date.DataPropertyName = "violation_date";
            this.violation_date.HeaderText = "Дата";
            this.violation_date.MinimumWidth = 10;
            this.violation_date.Name = "violation_date";
            this.violation_date.Width = 200;
            // 
            // violation_time
            // 
            this.violation_time.DataPropertyName = "violation_time";
            this.violation_time.HeaderText = "Время";
            this.violation_time.MinimumWidth = 10;
            this.violation_time.Name = "violation_time";
            this.violation_time.Width = 200;
            // 
            // violation_place
            // 
            this.violation_place.DataPropertyName = "violation_place";
            this.violation_place.HeaderText = "Место";
            this.violation_place.MinimumWidth = 10;
            this.violation_place.Name = "violation_place";
            this.violation_place.Width = 280;
            // 
            // status_id
            // 
            this.status_id.DataPropertyName = "status_id";
            this.status_id.HeaderText = "Статус";
            this.status_id.MinimumWidth = 10;
            this.status_id.Name = "status_id";
            this.status_id.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(26, 313);
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
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Транспорт";
            // 
            // violationDGV
            // 
            this.violationDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.violationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.violationDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sts_number,
            this.brand,
            this.model,
            this.year_of_manufacture,
            this.state_number,
            this.license_number});
            this.violationDGV.Location = new System.Drawing.Point(32, 58);
            this.violationDGV.Name = "violationDGV";
            this.violationDGV.RowHeadersWidth = 80;
            this.violationDGV.RowTemplate.Height = 33;
            this.violationDGV.Size = new System.Drawing.Size(1180, 240);
            this.violationDGV.TabIndex = 0;
            this.violationDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sts_number
            // 
            this.sts_number.DataPropertyName = "sts_number";
            this.sts_number.HeaderText = "Номер СТС";
            this.sts_number.MinimumWidth = 10;
            this.sts_number.Name = "sts_number";
            this.sts_number.Width = 200;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Марка";
            this.brand.MinimumWidth = 10;
            this.brand.Name = "brand";
            this.brand.Width = 200;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Модель";
            this.model.MinimumWidth = 10;
            this.model.Name = "model";
            this.model.Width = 200;
            // 
            // year_of_manufacture
            // 
            this.year_of_manufacture.DataPropertyName = "year_of_manufacture";
            this.year_of_manufacture.HeaderText = "Год выпуска";
            this.year_of_manufacture.MinimumWidth = 10;
            this.year_of_manufacture.Name = "year_of_manufacture";
            this.year_of_manufacture.Width = 200;
            // 
            // state_number
            // 
            this.state_number.DataPropertyName = "state_number";
            this.state_number.HeaderText = "Госномер";
            this.state_number.MinimumWidth = 10;
            this.state_number.Name = "state_number";
            this.state_number.Width = 200;
            // 
            // license_number
            // 
            this.license_number.DataPropertyName = "license_number";
            this.license_number.HeaderText = "Номер в/у";
            this.license_number.MinimumWidth = 10;
            this.license_number.Name = "license_number";
            this.license_number.Width = 200;
            // 
            // full_name_label
            // 
            this.full_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.full_name_label.AutoSize = true;
            this.full_name_label.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name_label.Location = new System.Drawing.Point(24, 18);
            this.full_name_label.Margin = new System.Windows.Forms.Padding(0);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(628, 47);
            this.full_name_label.TabIndex = 4;
            this.full_name_label.Text = "Мельничук Владислав Викторович";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.full_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(1105, 23);
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
            this.ClientSize = new System.Drawing.Size(1254, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.full_name_label);
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverForm";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protocolDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.DataGridView violationDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView protocolDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button protocol_more_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_number2;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_manufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_number;
        private System.Windows.Forms.Label label1;
    }
}