namespace Winform_PhongKham
{
    partial class fMedicine
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMedicine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvListMedicine = new System.Windows.Forms.DataGridView();
            this.txtCCD = new System.Windows.Forms.TextBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnDecre = new System.Windows.Forms.Button();
            this.btnIncre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Location = new System.Drawing.Point(435, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 35);
            this.btnFind.TabIndex = 45;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nhập tên thuốc";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(163, 38);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(207, 22);
            this.txtFind.TabIndex = 43;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(672, 579);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(672, 525);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(672, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Chống chỉ định:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(378, 484);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(246, 22);
            this.txtMedicineName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên thuốc:";
            // 
            // txtIDMedicine
            // 
            this.txtIDMedicine.Location = new System.Drawing.Point(107, 474);
            this.txtIDMedicine.Name = "txtIDMedicine";
            this.txtIDMedicine.Size = new System.Drawing.Size(100, 22);
            this.txtIDMedicine.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            // 
            // dtgvListMedicine
            // 
            this.dtgvListMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvListMedicine.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvListMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListMedicine.Location = new System.Drawing.Point(12, 81);
            this.dtgvListMedicine.Name = "dtgvListMedicine";
            this.dtgvListMedicine.RowHeadersWidth = 51;
            this.dtgvListMedicine.RowTemplate.Height = 24;
            this.dtgvListMedicine.Size = new System.Drawing.Size(753, 296);
            this.dtgvListMedicine.TabIndex = 23;
            this.dtgvListMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListMedicine_CellClick);
            this.dtgvListMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListMedicine_CellContentClick);
            // 
            // txtCCD
            // 
            this.txtCCD.Location = new System.Drawing.Point(378, 534);
            this.txtCCD.Multiline = true;
            this.txtCCD.Name = "txtCCD";
            this.txtCCD.Size = new System.Drawing.Size(246, 69);
            this.txtCCD.TabIndex = 46;
            this.txtCCD.TextChanged += new System.EventHandler(this.txtCCD_TextChanged);
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(107, 521);
            this.numericPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(100, 22);
            this.numericPrice.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Đơn vị:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(107, 564);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(75, 22);
            this.txtUnit.TabIndex = 49;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStock.Location = new System.Drawing.Point(623, 403);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(124, 35);
            this.btnStock.TabIndex = 50;
            this.btnStock.Text = "Số lượng tồn";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnDecre
            // 
            this.btnDecre.Location = new System.Drawing.Point(317, 392);
            this.btnDecre.Name = "btnDecre";
            this.btnDecre.Size = new System.Drawing.Size(74, 36);
            this.btnDecre.TabIndex = 51;
            this.btnDecre.Text = "<<";
            this.btnDecre.UseVisualStyleBackColor = true;
            this.btnDecre.Click += new System.EventHandler(this.btnDecre_Click);
            // 
            // btnIncre
            // 
            this.btnIncre.Location = new System.Drawing.Point(397, 392);
            this.btnIncre.Name = "btnIncre";
            this.btnIncre.Size = new System.Drawing.Size(74, 36);
            this.btnIncre.TabIndex = 52;
            this.btnIncre.Text = ">>";
            this.btnIncre.UseVisualStyleBackColor = true;
            this.btnIncre.Click += new System.EventHandler(this.btnIncre_Click);
            // 
            // fMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(780, 663);
            this.Controls.Add(this.btnIncre);
            this.Controls.Add(this.btnDecre);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.txtCCD);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvListMedicine);
            this.Name = "fMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.fMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvListMedicine;
        private System.Windows.Forms.TextBox txtCCD;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnDecre;
        private System.Windows.Forms.Button btnIncre;
    }
}