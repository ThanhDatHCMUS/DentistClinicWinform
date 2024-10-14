namespace Winform_PhongKham
{
    partial class fChoosePatient
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
            this.btnFind = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dtgvListPatient = new System.Windows.Forms.DataGridView();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnIncre = new System.Windows.Forms.Button();
            this.btnDecre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Location = new System.Drawing.Point(315, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 29);
            this.btnFind.TabIndex = 49;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Nhập họ tên:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(133, 15);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(166, 22);
            this.txtFind.TabIndex = 47;
            // 
            // dtgvListPatient
            // 
            this.dtgvListPatient.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListPatient.Location = new System.Drawing.Point(12, 49);
            this.dtgvListPatient.Name = "dtgvListPatient";
            this.dtgvListPatient.RowHeadersWidth = 51;
            this.dtgvListPatient.RowTemplate.Height = 24;
            this.dtgvListPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListPatient.Size = new System.Drawing.Size(828, 296);
            this.dtgvListPatient.TabIndex = 46;
            this.dtgvListPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListPatient_CellClick);
            this.dtgvListPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListPatient_CellContentClick);
            // 
            // btnPick
            // 
            this.btnPick.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPick.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPick.Location = new System.Drawing.Point(742, 430);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(92, 29);
            this.btnPick.TabIndex = 50;
            this.btnPick.Text = "Chọn";
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnIncre
            // 
            this.btnIncre.Location = new System.Drawing.Point(758, 361);
            this.btnIncre.Name = "btnIncre";
            this.btnIncre.Size = new System.Drawing.Size(76, 38);
            this.btnIncre.TabIndex = 51;
            this.btnIncre.Text = ">>";
            this.btnIncre.UseVisualStyleBackColor = true;
            this.btnIncre.Click += new System.EventHandler(this.btnIncre_Click);
            // 
            // btnDecre
            // 
            this.btnDecre.Location = new System.Drawing.Point(667, 361);
            this.btnDecre.Name = "btnDecre";
            this.btnDecre.Size = new System.Drawing.Size(76, 38);
            this.btnDecre.TabIndex = 52;
            this.btnDecre.Text = "<<";
            this.btnDecre.UseVisualStyleBackColor = true;
            this.btnDecre.Click += new System.EventHandler(this.btnDecre_Click);
            // 
            // fChoosePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(846, 485);
            this.Controls.Add(this.btnDecre);
            this.Controls.Add(this.btnIncre);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dtgvListPatient);
            this.Name = "fChoosePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn bệnh nhân";
            this.Load += new System.EventHandler(this.fChoosePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dtgvListPatient;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnIncre;
        private System.Windows.Forms.Button btnDecre;
    }
}