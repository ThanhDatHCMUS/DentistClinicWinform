namespace Winform_PhongKham
{
    partial class fCreatePay
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
            this.dtgvListNotPayDay = new System.Windows.Forms.DataGridView();
            this.dtgvMedicine = new System.Windows.Forms.DataGridView();
            this.dtgvTreat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNotPayDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTreat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListNotPayDay
            // 
            this.dtgvListNotPayDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListNotPayDay.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvListNotPayDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListNotPayDay.Location = new System.Drawing.Point(255, 12);
            this.dtgvListNotPayDay.Name = "dtgvListNotPayDay";
            this.dtgvListNotPayDay.RowHeadersWidth = 51;
            this.dtgvListNotPayDay.RowTemplate.Height = 24;
            this.dtgvListNotPayDay.Size = new System.Drawing.Size(301, 173);
            this.dtgvListNotPayDay.TabIndex = 0;
            this.dtgvListNotPayDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListNotPayDay_CellClick);
            this.dtgvListNotPayDay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtgvMedicine
            // 
            this.dtgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvMedicine.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicine.Location = new System.Drawing.Point(442, 294);
            this.dtgvMedicine.Name = "dtgvMedicine";
            this.dtgvMedicine.RowHeadersWidth = 51;
            this.dtgvMedicine.RowTemplate.Height = 24;
            this.dtgvMedicine.Size = new System.Drawing.Size(358, 253);
            this.dtgvMedicine.TabIndex = 1;
            this.dtgvMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dtgvTreat
            // 
            this.dtgvTreat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvTreat.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvTreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTreat.Location = new System.Drawing.Point(44, 294);
            this.dtgvTreat.Name = "dtgvTreat";
            this.dtgvTreat.RowHeadersWidth = 51;
            this.dtgvTreat.RowTemplate.Height = 24;
            this.dtgvTreat.Size = new System.Drawing.Size(337, 253);
            this.dtgvTreat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "**Nhấn vào ngày để xem chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách điều trị";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(671, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng tiền:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 600);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 8;
            // 
            // fCreatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(813, 710);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTreat);
            this.Controls.Add(this.dtgvMedicine);
            this.Controls.Add(this.dtgvListNotPayDay);
            this.Name = "fCreatePay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePay";
            this.Load += new System.EventHandler(this.fCreatePay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNotPayDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTreat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListNotPayDay;
        private System.Windows.Forms.DataGridView dtgvMedicine;
        private System.Windows.Forms.DataGridView dtgvTreat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}