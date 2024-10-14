namespace Winform_PhongKham
{
    partial class fHistoryMedicine
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
            this.comboDateTreat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvMeidcine = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAddUnit = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericAddMedicine = new System.Windows.Forms.NumericUpDown();
            this.comboAddMedicine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUnitUpdate = new System.Windows.Forms.TextBox();
            this.lbUnitUpdate = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpdateMedicine = new System.Windows.Forms.NumericUpDown();
            this.comboUpdateMedicine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMeidcine)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddMedicine)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDateTreat
            // 
            this.comboDateTreat.FormattingEnabled = true;
            this.comboDateTreat.Location = new System.Drawing.Point(214, 35);
            this.comboDateTreat.Name = "comboDateTreat";
            this.comboDateTreat.Size = new System.Drawing.Size(176, 24);
            this.comboDateTreat.TabIndex = 74;
            this.comboDateTreat.SelectedIndexChanged += new System.EventHandler(this.comboDateTreat_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(58, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 73;
            this.label12.Text = "Chọn ngày điều trị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Danh sách thuốc";
            // 
            // dtgvMeidcine
            // 
            this.dtgvMeidcine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMeidcine.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvMeidcine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMeidcine.Location = new System.Drawing.Point(12, 102);
            this.dtgvMeidcine.Name = "dtgvMeidcine";
            this.dtgvMeidcine.RowHeadersWidth = 51;
            this.dtgvMeidcine.RowTemplate.Height = 24;
            this.dtgvMeidcine.Size = new System.Drawing.Size(471, 209);
            this.dtgvMeidcine.TabIndex = 0;
            this.dtgvMeidcine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMeidcine_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 317);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 179);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtAddUnit);
            this.tabPage1.Controls.Add(this.labelUnit);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numericAddMedicine);
            this.tabPage1.Controls.Add(this.comboAddMedicine);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 150);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm thuốc";
            // 
            // txtAddUnit
            // 
            this.txtAddUnit.Location = new System.Drawing.Point(187, 92);
            this.txtAddUnit.Name = "txtAddUnit";
            this.txtAddUnit.ReadOnly = true;
            this.txtAddUnit.Size = new System.Drawing.Size(69, 22);
            this.txtAddUnit.TabIndex = 84;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(184, 89);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(0, 16);
            this.labelUnit.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 81;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(357, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Số lượng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericAddMedicine
            // 
            this.numericAddMedicine.Location = new System.Drawing.Point(97, 92);
            this.numericAddMedicine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAddMedicine.Name = "numericAddMedicine";
            this.numericAddMedicine.Size = new System.Drawing.Size(65, 22);
            this.numericAddMedicine.TabIndex = 78;
            this.numericAddMedicine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboAddMedicine
            // 
            this.comboAddMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddMedicine.FormattingEnabled = true;
            this.comboAddMedicine.Location = new System.Drawing.Point(97, 37);
            this.comboAddMedicine.Name = "comboAddMedicine";
            this.comboAddMedicine.Size = new System.Drawing.Size(242, 24);
            this.comboAddMedicine.TabIndex = 77;
            this.comboAddMedicine.SelectedIndexChanged += new System.EventHandler(this.comboAddMedicine_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Chọn thuốc:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtUnitUpdate);
            this.tabPage2.Controls.Add(this.lbUnitUpdate);
            this.tabPage2.Controls.Add(this.btnDeleteAll);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numericUpdateMedicine);
            this.tabPage2.Controls.Add(this.comboUpdateMedicine);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa, Xóa thuốc";
            // 
            // txtUnitUpdate
            // 
            this.txtUnitUpdate.Location = new System.Drawing.Point(198, 90);
            this.txtUnitUpdate.Name = "txtUnitUpdate";
            this.txtUnitUpdate.ReadOnly = true;
            this.txtUnitUpdate.Size = new System.Drawing.Size(69, 22);
            this.txtUnitUpdate.TabIndex = 89;
            // 
            // lbUnitUpdate
            // 
            this.lbUnitUpdate.AutoSize = true;
            this.lbUnitUpdate.Location = new System.Drawing.Point(195, 97);
            this.lbUnitUpdate.Name = "lbUnitUpdate";
            this.lbUnitUpdate.Size = new System.Drawing.Size(0, 16);
            this.lbUnitUpdate.TabIndex = 88;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAll.Location = new System.Drawing.Point(357, 111);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(89, 33);
            this.btnDeleteAll.TabIndex = 87;
            this.btnDeleteAll.Text = "Xóa toa";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(357, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 33);
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(357, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 33);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Số lượng:";
            // 
            // numericUpdateMedicine
            // 
            this.numericUpdateMedicine.Location = new System.Drawing.Point(103, 92);
            this.numericUpdateMedicine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpdateMedicine.Name = "numericUpdateMedicine";
            this.numericUpdateMedicine.Size = new System.Drawing.Size(65, 22);
            this.numericUpdateMedicine.TabIndex = 83;
            this.numericUpdateMedicine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboUpdateMedicine
            // 
            this.comboUpdateMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUpdateMedicine.FormattingEnabled = true;
            this.comboUpdateMedicine.Location = new System.Drawing.Point(103, 37);
            this.comboUpdateMedicine.Name = "comboUpdateMedicine";
            this.comboUpdateMedicine.Size = new System.Drawing.Size(238, 24);
            this.comboUpdateMedicine.TabIndex = 82;
            this.comboUpdateMedicine.SelectedIndexChanged += new System.EventHandler(this.comboUpdateMedicine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 81;
            this.label5.Text = "Chọn thuốc:";
            // 
            // fHistoryMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(499, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDateTreat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgvMeidcine);
            this.Name = "fHistoryMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn thuốc";
            this.Load += new System.EventHandler(this.fHistoryMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMeidcine)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddMedicine)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDateTreat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvMeidcine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericAddMedicine;
        private System.Windows.Forms.ComboBox comboAddMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpdateMedicine;
        private System.Windows.Forms.ComboBox comboUpdateMedicine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUnitUpdate;
        private System.Windows.Forms.TextBox txtAddUnit;
        private System.Windows.Forms.TextBox txtUnitUpdate;
    }
}