namespace Winform_PhongKham
{
    partial class fAddTooth
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
            this.ptbNumberTooth = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericTooth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboLocationTooth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSurface = new System.Windows.Forms.ComboBox();
            this.dtgvListTooth = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSurface = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteSurface = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNumberTooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTooth)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbNumberTooth
            // 
            this.ptbNumberTooth.Location = new System.Drawing.Point(205, 23);
            this.ptbNumberTooth.Name = "ptbNumberTooth";
            this.ptbNumberTooth.Size = new System.Drawing.Size(461, 306);
            this.ptbNumberTooth.TabIndex = 0;
            this.ptbNumberTooth.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số răng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericTooth
            // 
            this.numericTooth.Location = new System.Drawing.Point(564, 458);
            this.numericTooth.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericTooth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTooth.Name = "numericTooth";
            this.numericTooth.Size = new System.Drawing.Size(50, 22);
            this.numericTooth.TabIndex = 8;
            this.numericTooth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vị trí răng:";
            // 
            // comboLocationTooth
            // 
            this.comboLocationTooth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocationTooth.FormattingEnabled = true;
            this.comboLocationTooth.Location = new System.Drawing.Point(564, 410);
            this.comboLocationTooth.Name = "comboLocationTooth";
            this.comboLocationTooth.Size = new System.Drawing.Size(139, 24);
            this.comboLocationTooth.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bề mặt:";
            // 
            // comboSurface
            // 
            this.comboSurface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSurface.FormattingEnabled = true;
            this.comboSurface.Location = new System.Drawing.Point(564, 513);
            this.comboSurface.Name = "comboSurface";
            this.comboSurface.Size = new System.Drawing.Size(139, 24);
            this.comboSurface.TabIndex = 12;
            // 
            // dtgvListTooth
            // 
            this.dtgvListTooth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvListTooth.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvListTooth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListTooth.Location = new System.Drawing.Point(24, 376);
            this.dtgvListTooth.Name = "dtgvListTooth";
            this.dtgvListTooth.RowHeadersWidth = 51;
            this.dtgvListTooth.RowTemplate.Height = 24;
            this.dtgvListTooth.Size = new System.Drawing.Size(363, 210);
            this.dtgvListTooth.TabIndex = 13;
            this.dtgvListTooth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListTooth_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(731, 423);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 39);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(731, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 39);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddSurface
            // 
            this.btnAddSurface.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddSurface.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSurface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSurface.Location = new System.Drawing.Point(456, 560);
            this.btnAddSurface.Name = "btnAddSurface";
            this.btnAddSurface.Size = new System.Drawing.Size(109, 26);
            this.btnAddSurface.TabIndex = 16;
            this.btnAddSurface.Text = "Thêm bề mặt";
            this.btnAddSurface.UseVisualStyleBackColor = false;
            this.btnAddSurface.Click += new System.EventHandler(this.btnAddSurface_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Danh sách răng điều trị ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 18;
            // 
            // btnDeleteSurface
            // 
            this.btnDeleteSurface.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteSurface.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSurface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSurface.Location = new System.Drawing.Point(594, 560);
            this.btnDeleteSurface.Name = "btnDeleteSurface";
            this.btnDeleteSurface.Size = new System.Drawing.Size(109, 26);
            this.btnDeleteSurface.TabIndex = 19;
            this.btnDeleteSurface.Text = "Xóa bề mặt";
            this.btnDeleteSurface.UseVisualStyleBackColor = false;
            this.btnDeleteSurface.Click += new System.EventHandler(this.btnDeleteSurface_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(365, 624);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 39);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "Xác nhận";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fAddTooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(847, 687);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDeleteSurface);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddSurface);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvListTooth);
            this.Controls.Add(this.comboSurface);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboLocationTooth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericTooth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbNumberTooth);
            this.Name = "fAddTooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn răng";
            this.Load += new System.EventHandler(this.fAddTooth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNumberTooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbNumberTooth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericTooth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboLocationTooth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSurface;
        private System.Windows.Forms.DataGridView dtgvListTooth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSurface;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteSurface;
        private System.Windows.Forms.Button btnOK;
    }
}