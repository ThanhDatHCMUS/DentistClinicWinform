namespace Winform_PhongKham
{
    partial class fHistoryPay
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
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatePay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnContent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvHistory.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Location = new System.Drawing.Point(12, 62);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.RowHeadersWidth = 51;
            this.dtgvHistory.RowTemplate.Height = 24;
            this.dtgvHistory.Size = new System.Drawing.Size(662, 252);
            this.dtgvHistory.TabIndex = 0;
            this.dtgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHistory_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch sử thanh toán";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDatePay
            // 
            this.txtDatePay.Location = new System.Drawing.Point(172, 362);
            this.txtDatePay.Name = "txtDatePay";
            this.txtDatePay.ReadOnly = true;
            this.txtDatePay.Size = new System.Drawing.Size(167, 22);
            this.txtDatePay.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ngày thanh toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Người thanh toán:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 412);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(167, 22);
            this.txtName.TabIndex = 47;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(542, 360);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(94, 22);
            this.txtTotal.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tổng tiền:";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(542, 412);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(94, 22);
            this.txtPay.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tiền trả:";
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(542, 462);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.ReadOnly = true;
            this.txtReturn.Size = new System.Drawing.Size(94, 22);
            this.txtReturn.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tiền thối:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Hình thức";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(542, 523);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(94, 22);
            this.txtType.TabIndex = 55;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(102, 464);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(237, 119);
            this.txtNote.TabIndex = 57;
            this.txtNote.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "Ghi chú:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnContent
            // 
            this.btnContent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnContent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContent.Location = new System.Drawing.Point(482, 577);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(154, 45);
            this.btnContent.TabIndex = 58;
            this.btnContent.Text = "Chi tiết thanh toán";
            this.btnContent.UseVisualStyleBackColor = false;
            this.btnContent.Click += new System.EventHandler(this.btnContent_Click);
            // 
            // fHistoryPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(686, 648);
            this.Controls.Add(this.btnContent);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatePay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvHistory);
            this.Name = "fHistoryPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử thanh toán";
            this.Load += new System.EventHandler(this.fHistoryPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatePay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnContent;
    }
}