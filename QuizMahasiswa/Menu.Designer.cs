namespace QuizMahasiswa
{
    partial class Menu
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
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMaster
            // 
            this.btnMaster.AutoSize = true;
            this.btnMaster.Location = new System.Drawing.Point(68, 111);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(111, 27);
            this.btnMaster.TabIndex = 0;
            this.btnMaster.Text = "Master Barang";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.Location = new System.Drawing.Point(68, 169);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(111, 27);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report Barang";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Barang";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMaster);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
    }
}