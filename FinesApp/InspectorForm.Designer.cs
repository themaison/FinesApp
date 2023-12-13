namespace FinesApp
{
    partial class InspectorForm
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
            this.profile_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.full_name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // profile_button
            // 
            this.profile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.profile_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profile_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profile_button.Location = new System.Drawing.Point(1046, 5);
            this.profile_button.Margin = new System.Windows.Forms.Padding(4);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(180, 81);
            this.profile_button.TabIndex = 12;
            this.profile_button.Text = "Профиль";
            this.profile_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(914, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выйти";
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Font = new System.Drawing.Font("Product Sans", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.full_name_label.Location = new System.Drawing.Point(18, 20);
            this.full_name_label.Margin = new System.Windows.Forms.Padding(0);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(432, 47);
            this.full_name_label.TabIndex = 11;
            this.full_name_label.Text = "Имя Фамилия Отчество\r\n";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 555);
            this.panel2.TabIndex = 14;
            // 
            // InspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.full_name_label);
            this.Name = "InspectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.Panel panel2;
    }
}