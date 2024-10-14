namespace Winform_PhongKham
{
    partial class fAppointment
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCheck = new System.Windows.Forms.DataGridView();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDentist = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBranch = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDecre = new System.Windows.Forms.Button();
            this.btnIncre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(120, 45);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(131, 22);
            this.date.TabIndex = 0;
            this.date.CloseUp += new System.EventHandler(this.date_CloseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgvCheck
            // 
            this.dtgvCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCheck.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCheck.Location = new System.Drawing.Point(12, 193);
            this.dtgvCheck.Name = "dtgvCheck";
            this.dtgvCheck.RowHeadersWidth = 51;
            this.dtgvCheck.RowTemplate.Height = 24;
            this.dtgvCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCheck.Size = new System.Drawing.Size(777, 357);
            this.dtgvCheck.TabIndex = 2;
            this.dtgvCheck.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCheck_CellClick);
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(15, 139);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(137, 22);
            this.txtPatient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bệnh nhân:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatient.Location = new System.Drawing.Point(158, 133);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(64, 29);
            this.btnPatient.TabIndex = 5;
            this.btnPatient.Text = "Lọc";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDentist
            // 
            this.btnDentist.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDentist.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDentist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDentist.Location = new System.Drawing.Point(622, 133);
            this.btnDentist.Name = "btnDentist";
            this.btnDentist.Size = new System.Drawing.Size(167, 35);
            this.btnDentist.TabIndex = 8;
            this.btnDentist.Text = "Cuộc hẹn cá nhân";
            this.btnDentist.UseVisualStyleBackColor = false;
            this.btnDentist.Click += new System.EventHandler(this.btnDentist_Click);
            // 
            // btnBranch
            // 
            this.btnBranch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBranch.Location = new System.Drawing.Point(449, 136);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(64, 32);
            this.btnBranch.TabIndex = 11;
            this.btnBranch.Text = "Lọc";
            this.btnBranch.UseVisualStyleBackColor = false;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chi nhánh:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBranch
            // 
            this.comboBranch.FormattingEnabled = true;
            this.comboBranch.Location = new System.Drawing.Point(302, 139);
            this.comboBranch.Name = "comboBranch";
            this.comboBranch.Size = new System.Drawing.Size(141, 24);
            this.comboBranch.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(677, 652);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Điều chỉnh";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(561, 652);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDecre
            // 
            this.btnDecre.Location = new System.Drawing.Point(634, 573);
            this.btnDecre.Name = "btnDecre";
            this.btnDecre.Size = new System.Drawing.Size(63, 35);
            this.btnDecre.TabIndex = 15;
            this.btnDecre.Text = "<<";
            this.btnDecre.UseVisualStyleBackColor = true;
            this.btnDecre.Click += new System.EventHandler(this.btnDecre_Click);
            // 
            // btnIncre
            // 
            this.btnIncre.Location = new System.Drawing.Point(723, 573);
            this.btnIncre.Name = "btnIncre";
            this.btnIncre.Size = new System.Drawing.Size(63, 35);
            this.btnIncre.TabIndex = 16;
            this.btnIncre.Text = ">>";
            this.btnIncre.UseVisualStyleBackColor = true;
            this.btnIncre.Click += new System.EventHandler(this.btnIncre_Click);
            // 
            // fAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(802, 722);
            this.Controls.Add(this.btnIncre);
            this.Controls.Add(this.btnDecre);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBranch);
            this.Controls.Add(this.btnBranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDentist);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.dtgvCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Name = "fAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuộc hẹn";
            this.Load += new System.EventHandler(this.fAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCheck;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnDentist;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBranch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDecre;
        private System.Windows.Forms.Button btnIncre;
    }
}