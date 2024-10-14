namespace Winform_PhongKham
{
    partial class fRequestCheck
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
            this.dtgvRequestCheck = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRequestCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRequestCheck
            // 
            this.dtgvRequestCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvRequestCheck.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvRequestCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRequestCheck.Location = new System.Drawing.Point(12, 12);
            this.dtgvRequestCheck.Name = "dtgvRequestCheck";
            this.dtgvRequestCheck.RowHeadersWidth = 51;
            this.dtgvRequestCheck.RowTemplate.Height = 24;
            this.dtgvRequestCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRequestCheck.Size = new System.Drawing.Size(740, 340);
            this.dtgvRequestCheck.TabIndex = 0;
            this.dtgvRequestCheck.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRequestCheck_CellClick);
            this.dtgvRequestCheck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRequestCheck_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(657, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fRequestCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(767, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvRequestCheck);
            this.Name = "fRequestCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yêu cầu hẹn";
            this.Load += new System.EventHandler(this.RequestCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRequestCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRequestCheck;
        private System.Windows.Forms.Button button1;
    }
}