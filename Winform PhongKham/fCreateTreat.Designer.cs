namespace Winform_PhongKham
{
    partial class fCreateTreat
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTreat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDateCheck = new System.Windows.Forms.Label();
            this.comboChooseDentist = new System.Windows.Forms.ComboBox();
            this.comboChooseAssistant = new System.Windows.Forms.ComboBox();
            this.checkBoxNotChoose = new System.Windows.Forms.CheckBox();
            this.lbAnnounceChooseDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboChooseDirectory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboChoosedDirectory = new System.Windows.Forms.ComboBox();
            this.dtgvChoosedDirectory = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgvChoosedTreat = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboChoosedTreat = new System.Windows.Forms.ComboBox();
            this.comboChooseTreat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtgvChooseTooth = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChoosedDirectory)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChoosedTreat)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChooseTooth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn ngày điều trị:";
            // 
            // dateTreat
            // 
            this.dateTreat.AllowDrop = true;
            this.dateTreat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTreat.Location = new System.Drawing.Point(260, 55);
            this.dateTreat.Name = "dateTreat";
            this.dateTreat.Size = new System.Drawing.Size(118, 22);
            this.dateTreat.TabIndex = 1;
            this.dateTreat.CloseUp += new System.EventHandler(this.dateTreat_CloseUp);
            this.dateTreat.ValueChanged += new System.EventHandler(this.dateTreat_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn ngày bác sĩ điều trị:";
            // 
            // lbDateCheck
            // 
            this.lbDateCheck.AutoSize = true;
            this.lbDateCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateCheck.Location = new System.Drawing.Point(55, 194);
            this.lbDateCheck.Name = "lbDateCheck";
            this.lbDateCheck.Size = new System.Drawing.Size(117, 20);
            this.lbDateCheck.TabIndex = 7;
            this.lbDateCheck.Text = "Chọn trợ khám:";
            // 
            // comboChooseDentist
            // 
            this.comboChooseDentist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChooseDentist.FormattingEnabled = true;
            this.comboChooseDentist.Location = new System.Drawing.Point(260, 123);
            this.comboChooseDentist.Name = "comboChooseDentist";
            this.comboChooseDentist.Size = new System.Drawing.Size(255, 24);
            this.comboChooseDentist.TabIndex = 6;
            this.comboChooseDentist.SelectionChangeCommitted += new System.EventHandler(this.comboChooseDentist_SelectionChangeCommitted);
            // 
            // comboChooseAssistant
            // 
            this.comboChooseAssistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChooseAssistant.FormattingEnabled = true;
            this.comboChooseAssistant.Location = new System.Drawing.Point(260, 192);
            this.comboChooseAssistant.Name = "comboChooseAssistant";
            this.comboChooseAssistant.Size = new System.Drawing.Size(255, 24);
            this.comboChooseAssistant.TabIndex = 8;
            this.comboChooseAssistant.SelectionChangeCommitted += new System.EventHandler(this.comboChooseAssistant_SelectionChangeCommitted);
            // 
            // checkBoxNotChoose
            // 
            this.checkBoxNotChoose.AutoSize = true;
            this.checkBoxNotChoose.Location = new System.Drawing.Point(533, 194);
            this.checkBoxNotChoose.Name = "checkBoxNotChoose";
            this.checkBoxNotChoose.Size = new System.Drawing.Size(99, 20);
            this.checkBoxNotChoose.TabIndex = 9;
            this.checkBoxNotChoose.Text = "Không chọn";
            this.checkBoxNotChoose.UseVisualStyleBackColor = true;
            this.checkBoxNotChoose.CheckedChanged += new System.EventHandler(this.checkBoxNotChoose_CheckedChanged);
            // 
            // lbAnnounceChooseDate
            // 
            this.lbAnnounceChooseDate.AutoSize = true;
            this.lbAnnounceChooseDate.ForeColor = System.Drawing.Color.Red;
            this.lbAnnounceChooseDate.Location = new System.Drawing.Point(405, 59);
            this.lbAnnounceChooseDate.Name = "lbAnnounceChooseDate";
            this.lbAnnounceChooseDate.Size = new System.Drawing.Size(171, 16);
            this.lbAnnounceChooseDate.TabIndex = 10;
            this.lbAnnounceChooseDate.Text = "Chọn ngày không phù hợp!!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thêm danh mục";
            // 
            // comboChooseDirectory
            // 
            this.comboChooseDirectory.FormattingEnabled = true;
            this.comboChooseDirectory.Location = new System.Drawing.Point(475, 91);
            this.comboChooseDirectory.Name = "comboChooseDirectory";
            this.comboChooseDirectory.Size = new System.Drawing.Size(262, 24);
            this.comboChooseDirectory.TabIndex = 12;
            this.comboChooseDirectory.SelectedIndexChanged += new System.EventHandler(this.comboChooseDirectory_SelectedIndexChanged);
            this.comboChooseDirectory.SelectionChangeCommitted += new System.EventHandler(this.comboChooseDirectory_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Xóa danh mục";
            // 
            // comboChoosedDirectory
            // 
            this.comboChoosedDirectory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChoosedDirectory.FormattingEnabled = true;
            this.comboChoosedDirectory.Location = new System.Drawing.Point(475, 184);
            this.comboChoosedDirectory.Name = "comboChoosedDirectory";
            this.comboChoosedDirectory.Size = new System.Drawing.Size(262, 24);
            this.comboChoosedDirectory.TabIndex = 14;
            this.comboChoosedDirectory.SelectionChangeCommitted += new System.EventHandler(this.comboChoosedDirectory_SelectionChangeCommitted);
            // 
            // dtgvChoosedDirectory
            // 
            this.dtgvChoosedDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChoosedDirectory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvChoosedDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChoosedDirectory.Location = new System.Drawing.Point(45, 59);
            this.dtgvChoosedDirectory.Name = "dtgvChoosedDirectory";
            this.dtgvChoosedDirectory.RowHeadersWidth = 51;
            this.dtgvChoosedDirectory.RowTemplate.Height = 24;
            this.dtgvChoosedDirectory.Size = new System.Drawing.Size(379, 182);
            this.dtgvChoosedDirectory.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Danh sách danh mục điều trị đã chọn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 471);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 377);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.dtgvChoosedDirectory);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboChoosedDirectory);
            this.tabPage1.Controls.Add(this.comboChooseDirectory);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chọn danh mục điều trị";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(637, 281);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 35);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "Xác nhận";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dtgvChoosedTreat);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboChoosedTreat);
            this.tabPage2.Controls.Add(this.comboChooseTreat);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chọn điều trị";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(45, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(637, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Xác nhận";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgvChoosedTreat
            // 
            this.dtgvChoosedTreat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChoosedTreat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvChoosedTreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChoosedTreat.Location = new System.Drawing.Point(45, 59);
            this.dtgvChoosedTreat.Name = "dtgvChoosedTreat";
            this.dtgvChoosedTreat.RowHeadersWidth = 51;
            this.dtgvChoosedTreat.RowTemplate.Height = 24;
            this.dtgvChoosedTreat.Size = new System.Drawing.Size(402, 182);
            this.dtgvChoosedTreat.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Danh sách điều trị đã chọn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Thêm điều trị";
            // 
            // comboChoosedTreat
            // 
            this.comboChoosedTreat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChoosedTreat.FormattingEnabled = true;
            this.comboChoosedTreat.Location = new System.Drawing.Point(499, 184);
            this.comboChoosedTreat.Name = "comboChoosedTreat";
            this.comboChoosedTreat.Size = new System.Drawing.Size(238, 24);
            this.comboChoosedTreat.TabIndex = 21;
            this.comboChoosedTreat.SelectionChangeCommitted += new System.EventHandler(this.comboChoosedTreat_SelectionChangeCommitted);
            // 
            // comboChooseTreat
            // 
            this.comboChooseTreat.FormattingEnabled = true;
            this.comboChooseTreat.Location = new System.Drawing.Point(499, 91);
            this.comboChooseTreat.Name = "comboChooseTreat";
            this.comboChooseTreat.Size = new System.Drawing.Size(238, 24);
            this.comboChooseTreat.TabIndex = 19;
            this.comboChooseTreat.SelectionChangeCommitted += new System.EventHandler(this.comboChooseTreat_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Xóa điều trị";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dtgvChooseTooth);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tạo kế hoạch điều trị";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(45, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 27;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(621, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 35);
            this.button5.TabIndex = 26;
            this.button5.Text = "Tạo kế hoạch";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtgvChooseTooth
            // 
            this.dtgvChooseTooth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChooseTooth.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvChooseTooth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChooseTooth.Location = new System.Drawing.Point(158, 66);
            this.dtgvChooseTooth.Name = "dtgvChooseTooth";
            this.dtgvChooseTooth.RowHeadersWidth = 51;
            this.dtgvChooseTooth.RowTemplate.Height = 24;
            this.dtgvChooseTooth.Size = new System.Drawing.Size(458, 182);
            this.dtgvChooseTooth.TabIndex = 24;
            this.dtgvChooseTooth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChooseTooth_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Danh sách điều trị cần chọn răng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(260, 288);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(372, 143);
            this.txtNote.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ghi chú cho buổi điều trị:";
            // 
            // fCreateTreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(822, 920);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbAnnounceChooseDate);
            this.Controls.Add(this.checkBoxNotChoose);
            this.Controls.Add(this.comboChooseAssistant);
            this.Controls.Add(this.lbDateCheck);
            this.Controls.Add(this.comboChooseDentist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTreat);
            this.Controls.Add(this.label1);
            this.Name = "fCreateTreat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo kế hoạch điều trị";
            this.Load += new System.EventHandler(this.fCreateTreat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChoosedDirectory)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChoosedTreat)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChooseTooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTreat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDateCheck;
        private System.Windows.Forms.ComboBox comboChooseDentist;
        private System.Windows.Forms.ComboBox comboChooseAssistant;
        private System.Windows.Forms.CheckBox checkBoxNotChoose;
        private System.Windows.Forms.Label lbAnnounceChooseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboChooseDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboChoosedDirectory;
        private System.Windows.Forms.DataGridView dtgvChoosedDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgvChoosedTreat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboChoosedTreat;
        private System.Windows.Forms.ComboBox comboChooseTreat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtgvChooseTooth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label11;
    }
}