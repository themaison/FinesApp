namespace FinesApp
{
    partial class InspectorProtocolsForm
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
            this.update_protocol_box = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.update_tb4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.update_tb3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.update_dp2 = new System.Windows.Forms.DateTimePicker();
            this.update_dp1 = new System.Windows.Forms.DateTimePicker();
            this.update_tb2 = new System.Windows.Forms.TextBox();
            this.update_tb1 = new System.Windows.Forms.TextBox();
            this.update_cancel_box_button = new System.Windows.Forms.Button();
            this.update_box_button = new System.Windows.Forms.Button();
            this.insert_protocol_box = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.insert_tb4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insert_tb3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_cancel_box_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_box_button = new System.Windows.Forms.Button();
            this.insert_dp2 = new System.Windows.Forms.DateTimePicker();
            this.insert_dp1 = new System.Windows.Forms.DateTimePicker();
            this.insert_tb2 = new System.Windows.Forms.TextBox();
            this.insert_tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.driverDGV = new System.Windows.Forms.DataGridView();
            this.protocol_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sts_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violation_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert_button = new System.Windows.Forms.Button();
            this.full_name_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.update_protocol_box.SuspendLayout();
            this.insert_protocol_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDGV)).BeginInit();
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
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.update_protocol_box);
            this.panel2.Controls.Add(this.insert_protocol_box);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.driverDGV);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 846);
            this.panel2.TabIndex = 24;
            // 
            // update_protocol_box
            // 
            this.update_protocol_box.BackColor = System.Drawing.Color.LightGray;
            this.update_protocol_box.Controls.Add(this.label8);
            this.update_protocol_box.Controls.Add(this.update_tb4);
            this.update_protocol_box.Controls.Add(this.label9);
            this.update_protocol_box.Controls.Add(this.update_tb3);
            this.update_protocol_box.Controls.Add(this.label10);
            this.update_protocol_box.Controls.Add(this.label11);
            this.update_protocol_box.Controls.Add(this.label12);
            this.update_protocol_box.Controls.Add(this.label13);
            this.update_protocol_box.Controls.Add(this.update_dp2);
            this.update_protocol_box.Controls.Add(this.update_dp1);
            this.update_protocol_box.Controls.Add(this.update_tb2);
            this.update_protocol_box.Controls.Add(this.update_tb1);
            this.update_protocol_box.Controls.Add(this.update_cancel_box_button);
            this.update_protocol_box.Controls.Add(this.update_box_button);
            this.update_protocol_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_protocol_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_protocol_box.Location = new System.Drawing.Point(32, 356);
            this.update_protocol_box.Name = "update_protocol_box";
            this.update_protocol_box.Size = new System.Drawing.Size(714, 479);
            this.update_protocol_box.TabIndex = 21;
            this.update_protocol_box.TabStop = false;
            this.update_protocol_box.Text = "Изменение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(363, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 34);
            this.label8.TabIndex = 36;
            this.label8.Text = "ID Статуса оплаты";
            // 
            // update_tb4
            // 
            this.update_tb4.Location = new System.Drawing.Point(369, 269);
            this.update_tb4.Name = "update_tb4";
            this.update_tb4.Size = new System.Drawing.Size(327, 40);
            this.update_tb4.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 34);
            this.label9.TabIndex = 34;
            this.label9.Text = "Место нарушения";
            // 
            // update_tb3
            // 
            this.update_tb3.Location = new System.Drawing.Point(18, 269);
            this.update_tb3.Name = "update_tb3";
            this.update_tb3.Size = new System.Drawing.Size(327, 40);
            this.update_tb3.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(363, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 34);
            this.label10.TabIndex = 32;
            this.label10.Text = "Время нарушения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(12, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 34);
            this.label11.TabIndex = 31;
            this.label11.Text = "Дата нарушения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(363, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 34);
            this.label12.TabIndex = 30;
            this.label12.Text = "Номер СТС";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(12, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 34);
            this.label13.TabIndex = 29;
            this.label13.Text = "ID Нарушения";
            // 
            // update_dp2
            // 
            this.update_dp2.Location = new System.Drawing.Point(369, 172);
            this.update_dp2.Name = "update_dp2";
            this.update_dp2.Size = new System.Drawing.Size(327, 40);
            this.update_dp2.TabIndex = 28;
            // 
            // update_dp1
            // 
            this.update_dp1.Location = new System.Drawing.Point(18, 172);
            this.update_dp1.Name = "update_dp1";
            this.update_dp1.Size = new System.Drawing.Size(327, 40);
            this.update_dp1.TabIndex = 27;
            // 
            // update_tb2
            // 
            this.update_tb2.Location = new System.Drawing.Point(369, 86);
            this.update_tb2.Name = "update_tb2";
            this.update_tb2.Size = new System.Drawing.Size(327, 40);
            this.update_tb2.TabIndex = 26;
            // 
            // update_tb1
            // 
            this.update_tb1.Location = new System.Drawing.Point(18, 86);
            this.update_tb1.Name = "update_tb1";
            this.update_tb1.Size = new System.Drawing.Size(327, 40);
            this.update_tb1.TabIndex = 25;
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
            // 
            // insert_protocol_box
            // 
            this.insert_protocol_box.BackColor = System.Drawing.Color.LightGray;
            this.insert_protocol_box.Controls.Add(this.label7);
            this.insert_protocol_box.Controls.Add(this.insert_tb4);
            this.insert_protocol_box.Controls.Add(this.label4);
            this.insert_protocol_box.Controls.Add(this.insert_tb3);
            this.insert_protocol_box.Controls.Add(this.label6);
            this.insert_protocol_box.Controls.Add(this.label5);
            this.insert_protocol_box.Controls.Add(this.insert_cancel_box_button);
            this.insert_protocol_box.Controls.Add(this.label3);
            this.insert_protocol_box.Controls.Add(this.label1);
            this.insert_protocol_box.Controls.Add(this.insert_box_button);
            this.insert_protocol_box.Controls.Add(this.insert_dp2);
            this.insert_protocol_box.Controls.Add(this.insert_dp1);
            this.insert_protocol_box.Controls.Add(this.insert_tb2);
            this.insert_protocol_box.Controls.Add(this.insert_tb1);
            this.insert_protocol_box.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_protocol_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert_protocol_box.Location = new System.Drawing.Point(32, 356);
            this.insert_protocol_box.Name = "insert_protocol_box";
            this.insert_protocol_box.Size = new System.Drawing.Size(714, 479);
            this.insert_protocol_box.TabIndex = 2;
            this.insert_protocol_box.TabStop = false;
            this.insert_protocol_box.Text = "Добавление";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(363, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 34);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID Статуса оплаты";
            // 
            // insert_tb4
            // 
            this.insert_tb4.Location = new System.Drawing.Point(369, 269);
            this.insert_tb4.Name = "insert_tb4";
            this.insert_tb4.Size = new System.Drawing.Size(327, 40);
            this.insert_tb4.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 34);
            this.label4.TabIndex = 22;
            this.label4.Text = "Место нарушения";
            // 
            // insert_tb3
            // 
            this.insert_tb3.Location = new System.Drawing.Point(18, 269);
            this.insert_tb3.Name = "insert_tb3";
            this.insert_tb3.Size = new System.Drawing.Size(327, 40);
            this.insert_tb3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(363, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "Время нарушения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата нарушения";
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(363, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Номер СТС";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Нарушения";
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
            // 
            // insert_dp2
            // 
            this.insert_dp2.Location = new System.Drawing.Point(369, 172);
            this.insert_dp2.Name = "insert_dp2";
            this.insert_dp2.Size = new System.Drawing.Size(327, 40);
            this.insert_dp2.TabIndex = 5;
            // 
            // insert_dp1
            // 
            this.insert_dp1.Location = new System.Drawing.Point(18, 172);
            this.insert_dp1.Name = "insert_dp1";
            this.insert_dp1.Size = new System.Drawing.Size(327, 40);
            this.insert_dp1.TabIndex = 4;
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
            this.protocol_id,
            this.violation_id,
            this.sts_number,
            this.violation_date,
            this.violation_time,
            this.violation_place,
            this.status_id});
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
            // protocol_id
            // 
            this.protocol_id.DataPropertyName = "protocol_id";
            this.protocol_id.HeaderText = "ID Протокола";
            this.protocol_id.MinimumWidth = 10;
            this.protocol_id.Name = "protocol_id";
            this.protocol_id.ReadOnly = true;
            this.protocol_id.Width = 200;
            // 
            // violation_id
            // 
            this.violation_id.DataPropertyName = "violation_id";
            this.violation_id.HeaderText = "ID Нарушения";
            this.violation_id.MinimumWidth = 10;
            this.violation_id.Name = "violation_id";
            this.violation_id.ReadOnly = true;
            this.violation_id.Width = 200;
            // 
            // sts_number
            // 
            this.sts_number.DataPropertyName = "sts_number";
            this.sts_number.HeaderText = "Номер СТС";
            this.sts_number.MinimumWidth = 10;
            this.sts_number.Name = "sts_number";
            this.sts_number.ReadOnly = true;
            this.sts_number.Width = 200;
            // 
            // violation_date
            // 
            this.violation_date.DataPropertyName = "violation_date";
            this.violation_date.HeaderText = "Дата нарушения";
            this.violation_date.MinimumWidth = 10;
            this.violation_date.Name = "violation_date";
            this.violation_date.ReadOnly = true;
            this.violation_date.Width = 140;
            // 
            // violation_time
            // 
            this.violation_time.DataPropertyName = "violation_time";
            this.violation_time.HeaderText = "Время нарушения";
            this.violation_time.MinimumWidth = 10;
            this.violation_time.Name = "violation_time";
            this.violation_time.ReadOnly = true;
            this.violation_time.Width = 140;
            // 
            // violation_place
            // 
            this.violation_place.DataPropertyName = "violation_place";
            this.violation_place.HeaderText = "Место нарушения";
            this.violation_place.MinimumWidth = 10;
            this.violation_place.Name = "violation_place";
            this.violation_place.ReadOnly = true;
            this.violation_place.Width = 200;
            // 
            // status_id
            // 
            this.status_id.DataPropertyName = "status_id";
            this.status_id.HeaderText = "ID Статуса оплаты";
            this.status_id.MinimumWidth = 10;
            this.status_id.Name = "status_id";
            this.status_id.ReadOnly = true;
            this.status_id.Width = 140;
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
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.full_name_label.Location = new System.Drawing.Point(88, 17);
            this.full_name_label.Margin = new System.Windows.Forms.Padding(0);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(328, 47);
            this.full_name_label.TabIndex = 23;
            this.full_name_label.Text = "Таблица: Protocol";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InspectorProtocolsForm
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
            this.Name = "InspectorProtocolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectorProtocolsForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.update_protocol_box.ResumeLayout(false);
            this.update_protocol_box.PerformLayout();
            this.insert_protocol_box.ResumeLayout(false);
            this.insert_protocol_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label to_back_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox update_protocol_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox update_tb4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox update_tb3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker update_dp2;
        private System.Windows.Forms.DateTimePicker update_dp1;
        private System.Windows.Forms.TextBox update_tb2;
        private System.Windows.Forms.TextBox update_tb1;
        private System.Windows.Forms.Button update_cancel_box_button;
        private System.Windows.Forms.Button update_box_button;
        private System.Windows.Forms.GroupBox insert_protocol_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox insert_tb4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insert_tb3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert_cancel_box_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_box_button;
        private System.Windows.Forms.DateTimePicker insert_dp2;
        private System.Windows.Forms.DateTimePicker insert_dp1;
        private System.Windows.Forms.TextBox insert_tb2;
        private System.Windows.Forms.TextBox insert_tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView driverDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn violation_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_id;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Label full_name_label;
    }
}