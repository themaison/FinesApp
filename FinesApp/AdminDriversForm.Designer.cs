namespace FinesApp
{
    partial class AdminDriversForm
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
            this.update_driver_box = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.update_cancel_box_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.update_box_button = new System.Windows.Forms.Button();
            this.update_dp3 = new System.Windows.Forms.DateTimePicker();
            this.update_dp2 = new System.Windows.Forms.DateTimePicker();
            this.update_dp1 = new System.Windows.Forms.DateTimePicker();
            this.female_update_rb = new System.Windows.Forms.RadioButton();
            this.male_update_rb = new System.Windows.Forms.RadioButton();
            this.update_tb2 = new System.Windows.Forms.TextBox();
            this.update_tb1 = new System.Windows.Forms.TextBox();
            this.insert_driver_box = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_cancel_box_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_box_button = new System.Windows.Forms.Button();
            this.insert_dp3 = new System.Windows.Forms.DateTimePicker();
            this.insert_dp2 = new System.Windows.Forms.DateTimePicker();
            this.insert_dp1 = new System.Windows.Forms.DateTimePicker();
            this.female_insert_rb = new System.Windows.Forms.RadioButton();
            this.male_insert_rb = new System.Windows.Forms.RadioButton();
            this.insert_tb2 = new System.Windows.Forms.TextBox();
            this.insert_tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.driverDGV = new System.Windows.Forms.DataGridView();
            this.license_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.full_name_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.to_back_button = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.update_driver_box.SuspendLayout();
            this.insert_driver_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.update_driver_box);
            this.panel2.Controls.Add(this.insert_driver_box);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.driverDGV);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 846);
            this.panel2.TabIndex = 12;
            // 
            // update_driver_box
            // 
            this.update_driver_box.BackColor = System.Drawing.Color.LightGray;
            this.update_driver_box.Controls.Add(this.label8);
            this.update_driver_box.Controls.Add(this.label9);
            this.update_driver_box.Controls.Add(this.label10);
            this.update_driver_box.Controls.Add(this.update_cancel_box_button);
            this.update_driver_box.Controls.Add(this.label11);
            this.update_driver_box.Controls.Add(this.label12);
            this.update_driver_box.Controls.Add(this.label13);
            this.update_driver_box.Controls.Add(this.update_box_button);
            this.update_driver_box.Controls.Add(this.update_dp3);
            this.update_driver_box.Controls.Add(this.update_dp2);
            this.update_driver_box.Controls.Add(this.update_dp1);
            this.update_driver_box.Controls.Add(this.female_update_rb);
            this.update_driver_box.Controls.Add(this.male_update_rb);
            this.update_driver_box.Controls.Add(this.update_tb2);
            this.update_driver_box.Controls.Add(this.update_tb1);
            this.update_driver_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_driver_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_driver_box.Location = new System.Drawing.Point(32, 356);
            this.update_driver_box.Name = "update_driver_box";
            this.update_driver_box.Size = new System.Drawing.Size(714, 479);
            this.update_driver_box.TabIndex = 21;
            this.update_driver_box.TabStop = false;
            this.update_driver_box.Text = "Изменение";
            this.update_driver_box.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(363, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 34);
            this.label8.TabIndex = 20;
            this.label8.Text = "Срок действия в/у";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(12, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 34);
            this.label9.TabIndex = 19;
            this.label9.Text = "Дата выдачи в/у";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(363, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 34);
            this.label10.TabIndex = 18;
            this.label10.Text = "Дата рождения";
            // 
            // update_cancel_box_button
            // 
            this.update_cancel_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.update_cancel_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.update_cancel_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_cancel_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_cancel_box_button.Location = new System.Drawing.Point(18, 381);
            this.update_cancel_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_cancel_box_button.Name = "update_cancel_box_button";
            this.update_cancel_box_button.Size = new System.Drawing.Size(327, 80);
            this.update_cancel_box_button.TabIndex = 17;
            this.update_cancel_box_button.Text = "Отмена";
            this.update_cancel_box_button.UseVisualStyleBackColor = true;
            this.update_cancel_box_button.Click += new System.EventHandler(this.update_cancel_box_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(12, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 34);
            this.label11.TabIndex = 16;
            this.label11.Text = "Пол";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(363, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 34);
            this.label12.TabIndex = 15;
            this.label12.Text = "ФИО";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(12, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 34);
            this.label13.TabIndex = 14;
            this.label13.Text = "Номер в/у";
            // 
            // update_box_button
            // 
            this.update_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.update_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_box_button.Location = new System.Drawing.Point(369, 381);
            this.update_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_box_button.Name = "update_box_button";
            this.update_box_button.Size = new System.Drawing.Size(327, 80);
            this.update_box_button.TabIndex = 13;
            this.update_box_button.Text = "Изменить";
            this.update_box_button.UseVisualStyleBackColor = true;
            this.update_box_button.Click += new System.EventHandler(this.update_box_button_Click);
            // 
            // update_dp3
            // 
            this.update_dp3.Location = new System.Drawing.Point(369, 310);
            this.update_dp3.Name = "update_dp3";
            this.update_dp3.Size = new System.Drawing.Size(327, 40);
            this.update_dp3.TabIndex = 6;
            // 
            // update_dp2
            // 
            this.update_dp2.Location = new System.Drawing.Point(18, 310);
            this.update_dp2.Name = "update_dp2";
            this.update_dp2.Size = new System.Drawing.Size(327, 40);
            this.update_dp2.TabIndex = 5;
            // 
            // update_dp1
            // 
            this.update_dp1.Location = new System.Drawing.Point(369, 172);
            this.update_dp1.Name = "update_dp1";
            this.update_dp1.Size = new System.Drawing.Size(327, 40);
            this.update_dp1.TabIndex = 4;
            // 
            // female_update_rb
            // 
            this.female_update_rb.AutoSize = true;
            this.female_update_rb.Location = new System.Drawing.Point(18, 216);
            this.female_update_rb.Name = "female_update_rb";
            this.female_update_rb.Size = new System.Drawing.Size(164, 38);
            this.female_update_rb.TabIndex = 3;
            this.female_update_rb.TabStop = true;
            this.female_update_rb.Text = "Женщина";
            this.female_update_rb.UseVisualStyleBackColor = true;
            // 
            // male_update_rb
            // 
            this.male_update_rb.AutoSize = true;
            this.male_update_rb.Location = new System.Drawing.Point(18, 172);
            this.male_update_rb.Name = "male_update_rb";
            this.male_update_rb.Size = new System.Drawing.Size(160, 38);
            this.male_update_rb.TabIndex = 2;
            this.male_update_rb.TabStop = true;
            this.male_update_rb.Text = "Мужчина";
            this.male_update_rb.UseVisualStyleBackColor = true;
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
            // insert_driver_box
            // 
            this.insert_driver_box.BackColor = System.Drawing.Color.LightGray;
            this.insert_driver_box.Controls.Add(this.label7);
            this.insert_driver_box.Controls.Add(this.label6);
            this.insert_driver_box.Controls.Add(this.label5);
            this.insert_driver_box.Controls.Add(this.insert_cancel_box_button);
            this.insert_driver_box.Controls.Add(this.label4);
            this.insert_driver_box.Controls.Add(this.label3);
            this.insert_driver_box.Controls.Add(this.label1);
            this.insert_driver_box.Controls.Add(this.insert_box_button);
            this.insert_driver_box.Controls.Add(this.insert_dp3);
            this.insert_driver_box.Controls.Add(this.insert_dp2);
            this.insert_driver_box.Controls.Add(this.insert_dp1);
            this.insert_driver_box.Controls.Add(this.female_insert_rb);
            this.insert_driver_box.Controls.Add(this.male_insert_rb);
            this.insert_driver_box.Controls.Add(this.insert_tb2);
            this.insert_driver_box.Controls.Add(this.insert_tb1);
            this.insert_driver_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_driver_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_driver_box.Location = new System.Drawing.Point(32, 356);
            this.insert_driver_box.Name = "insert_driver_box";
            this.insert_driver_box.Size = new System.Drawing.Size(714, 479);
            this.insert_driver_box.TabIndex = 2;
            this.insert_driver_box.TabStop = false;
            this.insert_driver_box.Text = "Добавление";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(363, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 34);
            this.label7.TabIndex = 20;
            this.label7.Text = "Срок действия в/у";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "Дата выдачи в/у";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(363, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата рождения";
            // 
            // insert_cancel_box_button
            // 
            this.insert_cancel_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.insert_cancel_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.insert_cancel_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_cancel_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_cancel_box_button.Location = new System.Drawing.Point(18, 381);
            this.insert_cancel_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_cancel_box_button.Name = "insert_cancel_box_button";
            this.insert_cancel_box_button.Size = new System.Drawing.Size(327, 80);
            this.insert_cancel_box_button.TabIndex = 17;
            this.insert_cancel_box_button.Text = "Отмена";
            this.insert_cancel_box_button.UseVisualStyleBackColor = true;
            this.insert_cancel_box_button.Click += new System.EventHandler(this.insert_cancel_box_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(363, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Номер в/у";
            // 
            // insert_box_button
            // 
            this.insert_box_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_box_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.insert_box_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_box_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_box_button.Location = new System.Drawing.Point(369, 381);
            this.insert_box_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_box_button.Name = "insert_box_button";
            this.insert_box_button.Size = new System.Drawing.Size(327, 80);
            this.insert_box_button.TabIndex = 13;
            this.insert_box_button.Text = "Добавить";
            this.insert_box_button.UseVisualStyleBackColor = true;
            this.insert_box_button.Click += new System.EventHandler(this.insert_box_button_Click);
            // 
            // insert_dp3
            // 
            this.insert_dp3.Location = new System.Drawing.Point(369, 310);
            this.insert_dp3.Name = "insert_dp3";
            this.insert_dp3.Size = new System.Drawing.Size(327, 40);
            this.insert_dp3.TabIndex = 6;
            // 
            // insert_dp2
            // 
            this.insert_dp2.Location = new System.Drawing.Point(18, 310);
            this.insert_dp2.Name = "insert_dp2";
            this.insert_dp2.Size = new System.Drawing.Size(327, 40);
            this.insert_dp2.TabIndex = 5;
            // 
            // insert_dp1
            // 
            this.insert_dp1.Location = new System.Drawing.Point(369, 172);
            this.insert_dp1.Name = "insert_dp1";
            this.insert_dp1.Size = new System.Drawing.Size(327, 40);
            this.insert_dp1.TabIndex = 4;
            this.insert_dp1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // female_insert_rb
            // 
            this.female_insert_rb.AutoSize = true;
            this.female_insert_rb.Location = new System.Drawing.Point(18, 216);
            this.female_insert_rb.Name = "female_insert_rb";
            this.female_insert_rb.Size = new System.Drawing.Size(164, 38);
            this.female_insert_rb.TabIndex = 3;
            this.female_insert_rb.TabStop = true;
            this.female_insert_rb.Text = "Женщина";
            this.female_insert_rb.UseVisualStyleBackColor = true;
            // 
            // male_insert_rb
            // 
            this.male_insert_rb.AutoSize = true;
            this.male_insert_rb.Location = new System.Drawing.Point(18, 172);
            this.male_insert_rb.Name = "male_insert_rb";
            this.male_insert_rb.Size = new System.Drawing.Size(160, 38);
            this.male_insert_rb.TabIndex = 2;
            this.male_insert_rb.TabStop = true;
            this.male_insert_rb.Text = "Мужчина";
            this.male_insert_rb.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(133, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Водители";
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
            this.driverDGV.Location = new System.Drawing.Point(32, 58);
            this.driverDGV.Margin = new System.Windows.Forms.Padding(4);
            this.driverDGV.Name = "driverDGV";
            this.driverDGV.ReadOnly = true;
            this.driverDGV.RowHeadersWidth = 80;
            this.driverDGV.RowTemplate.Height = 33;
            this.driverDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driverDGV.Size = new System.Drawing.Size(1180, 280);
            this.driverDGV.TabIndex = 0;
            // 
            // license_number
            // 
            this.license_number.DataPropertyName = "license_number";
            this.license_number.HeaderText = "Номер в/у";
            this.license_number.MinimumWidth = 10;
            this.license_number.Name = "license_number";
            this.license_number.ReadOnly = true;
            this.license_number.Width = 200;
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
            this.gender.Width = 200;
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
            this.insert_button.TabIndex = 8;
            this.insert_button.Text = "Добавить";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
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
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.full_name_label.Location = new System.Drawing.Point(88, 17);
            this.full_name_label.Margin = new System.Windows.Forms.Padding(0);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(293, 47);
            this.full_name_label.TabIndex = 11;
            this.full_name_label.Text = "Таблица: Driver";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.update_button.TabIndex = 9;
            this.update_button.Text = "Изменить";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
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
            this.to_back_button.TabIndex = 13;
            this.to_back_button.Text = "<- ";
            this.to_back_button.Click += new System.EventHandler(this.to_back_button_Click);
            // 
            // AdminDriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 929);
            this.Controls.Add(this.to_back_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.full_name_label);
            this.MaximumSize = new System.Drawing.Size(1280, 1000);
            this.MinimumSize = new System.Drawing.Size(1280, 1000);
            this.Name = "AdminDriversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDriversForm";
            this.Load += new System.EventHandler(this.AdminDriversForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.update_driver_box.ResumeLayout(false);
            this.update_driver_box.PerformLayout();
            this.insert_driver_box.ResumeLayout(false);
            this.insert_driver_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView driverDGV;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.GroupBox insert_driver_box;
        private System.Windows.Forms.DateTimePicker insert_dp3;
        private System.Windows.Forms.DateTimePicker insert_dp2;
        private System.Windows.Forms.DateTimePicker insert_dp1;
        private System.Windows.Forms.RadioButton female_insert_rb;
        private System.Windows.Forms.RadioButton male_insert_rb;
        private System.Windows.Forms.TextBox insert_tb2;
        private System.Windows.Forms.TextBox insert_tb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert_cancel_box_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_box_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox update_driver_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button update_cancel_box_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button update_box_button;
        private System.Windows.Forms.DateTimePicker update_dp3;
        private System.Windows.Forms.DateTimePicker update_dp2;
        private System.Windows.Forms.DateTimePicker update_dp1;
        private System.Windows.Forms.RadioButton female_update_rb;
        private System.Windows.Forms.RadioButton male_update_rb;
        private System.Windows.Forms.TextBox update_tb2;
        private System.Windows.Forms.TextBox update_tb1;
        private System.Windows.Forms.Label to_back_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_validity;
    }
}