namespace FinesApp
{
    partial class AdminForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.drivers_button = new System.Windows.Forms.Button();
            this.vehicles_button = new System.Windows.Forms.Button();
            this.protocols_button = new System.Windows.Forms.Button();
            this.volations_button = new System.Windows.Forms.Button();
            this.payment_statuses_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 566);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.drivers_button);
            this.flowLayoutPanel1.Controls.Add(this.vehicles_button);
            this.flowLayoutPanel1.Controls.Add(this.protocols_button);
            this.flowLayoutPanel1.Controls.Add(this.volations_button);
            this.flowLayoutPanel1.Controls.Add(this.payment_statuses_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(146, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(944, 300);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // drivers_button
            // 
            this.drivers_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drivers_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.drivers_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drivers_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.drivers_button.Location = new System.Drawing.Point(10, 10);
            this.drivers_button.Margin = new System.Windows.Forms.Padding(10);
            this.drivers_button.Name = "drivers_button";
            this.drivers_button.Padding = new System.Windows.Forms.Padding(10);
            this.drivers_button.Size = new System.Drawing.Size(294, 80);
            this.drivers_button.TabIndex = 6;
            this.drivers_button.Text = "Водители";
            this.drivers_button.UseVisualStyleBackColor = true;
            this.drivers_button.Click += new System.EventHandler(this.drivers_button_Click);
            // 
            // vehicles_button
            // 
            this.vehicles_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicles_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.vehicles_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vehicles_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vehicles_button.Location = new System.Drawing.Point(324, 10);
            this.vehicles_button.Margin = new System.Windows.Forms.Padding(10);
            this.vehicles_button.Name = "vehicles_button";
            this.vehicles_button.Padding = new System.Windows.Forms.Padding(10);
            this.vehicles_button.Size = new System.Drawing.Size(294, 80);
            this.vehicles_button.TabIndex = 7;
            this.vehicles_button.Text = "Транспорт";
            this.vehicles_button.UseVisualStyleBackColor = true;
            this.vehicles_button.Click += new System.EventHandler(this.vehicles_button_Click);
            // 
            // protocols_button
            // 
            this.protocols_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protocols_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.protocols_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocols_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.protocols_button.Location = new System.Drawing.Point(638, 10);
            this.protocols_button.Margin = new System.Windows.Forms.Padding(10);
            this.protocols_button.Name = "protocols_button";
            this.protocols_button.Padding = new System.Windows.Forms.Padding(10);
            this.protocols_button.Size = new System.Drawing.Size(294, 80);
            this.protocols_button.TabIndex = 8;
            this.protocols_button.Text = "Протоколы";
            this.protocols_button.UseVisualStyleBackColor = true;
            this.protocols_button.Click += new System.EventHandler(this.protocols_button_Click);
            // 
            // volations_button
            // 
            this.volations_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volations_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.volations_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volations_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.volations_button.Location = new System.Drawing.Point(10, 110);
            this.volations_button.Margin = new System.Windows.Forms.Padding(10);
            this.volations_button.Name = "volations_button";
            this.volations_button.Padding = new System.Windows.Forms.Padding(10);
            this.volations_button.Size = new System.Drawing.Size(294, 80);
            this.volations_button.TabIndex = 9;
            this.volations_button.Text = "Нарушения";
            this.volations_button.UseVisualStyleBackColor = true;
            this.volations_button.Click += new System.EventHandler(this.volations_button_Click);
            // 
            // payment_statuses_button
            // 
            this.payment_statuses_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_statuses_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.payment_statuses_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payment_statuses_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.payment_statuses_button.Location = new System.Drawing.Point(324, 110);
            this.payment_statuses_button.Margin = new System.Windows.Forms.Padding(10);
            this.payment_statuses_button.Name = "payment_statuses_button";
            this.payment_statuses_button.Padding = new System.Windows.Forms.Padding(10);
            this.payment_statuses_button.Size = new System.Drawing.Size(294, 80);
            this.payment_statuses_button.TabIndex = 10;
            this.payment_statuses_button.Text = "Статусы оплаты";
            this.payment_statuses_button.UseVisualStyleBackColor = true;
            this.payment_statuses_button.Click += new System.EventHandler(this.payment_statuses_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Product Sans Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(1254, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Панель Администратора";
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
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Выйти";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button drivers_button;
        private System.Windows.Forms.Button vehicles_button;
        private System.Windows.Forms.Button protocols_button;
        private System.Windows.Forms.Button volations_button;
        private System.Windows.Forms.Button payment_statuses_button;
        private System.Windows.Forms.Label exitButton;
    }
}