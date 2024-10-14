namespace Winform_PhongKham
{
    partial class fChoosePatientType
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
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnOldPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNewPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPatient.Location = new System.Drawing.Point(40, 52);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(150, 103);
            this.btnNewPatient.TabIndex = 0;
            this.btnNewPatient.Text = "Khách hàng mới";
            this.btnNewPatient.UseVisualStyleBackColor = false;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnOldPatient
            // 
            this.btnOldPatient.BackColor = System.Drawing.Color.AliceBlue;
            this.btnOldPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldPatient.Location = new System.Drawing.Point(250, 52);
            this.btnOldPatient.Name = "btnOldPatient";
            this.btnOldPatient.Size = new System.Drawing.Size(150, 103);
            this.btnOldPatient.TabIndex = 1;
            this.btnOldPatient.Text = "Khách hàng cũ";
            this.btnOldPatient.UseVisualStyleBackColor = false;
            this.btnOldPatient.Click += new System.EventHandler(this.btnOldPatient_Click);
            // 
            // fChoosePatientType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(463, 226);
            this.Controls.Add(this.btnOldPatient);
            this.Controls.Add(this.btnNewPatient);
            this.Name = "fChoosePatientType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn loại khách hàng";
            this.Load += new System.EventHandler(this.fChoosePatientType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnOldPatient;
    }
}