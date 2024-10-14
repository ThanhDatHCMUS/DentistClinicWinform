namespace Winform_PhongKham
{
    partial class fCreateAppointment
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBranch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAnnounceChooseDate = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.comboPartOfDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDateCheck = new System.Windows.Forms.Label();
            this.comboDatePreCheck = new System.Windows.Forms.ComboBox();
            this.rdBtnFirstCheck = new System.Windows.Forms.RadioButton();
            this.rdBtnNotFirstCheck = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDentist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.comboBranch);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbAnnounceChooseDate);
            this.tabPage2.Controls.Add(this.btn2);
            this.tabPage2.Controls.Add(this.btn3);
            this.tabPage2.Controls.Add(this.comboPartOfDay);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chọn thời gian";
            // 
            // comboBranch
            // 
            this.comboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBranch.FormattingEnabled = true;
            this.comboBranch.Items.AddRange(new object[] {
            "Buổi sáng",
            "Buối chiều",
            "Buổi tối"});
            this.comboBranch.Location = new System.Drawing.Point(211, 178);
            this.comboBranch.Name = "comboBranch";
            this.comboBranch.Size = new System.Drawing.Size(337, 24);
            this.comboBranch.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chọn chi nhánh:";
            // 
            // lbAnnounceChooseDate
            // 
            this.lbAnnounceChooseDate.AutoSize = true;
            this.lbAnnounceChooseDate.ForeColor = System.Drawing.Color.Red;
            this.lbAnnounceChooseDate.Location = new System.Drawing.Point(377, 44);
            this.lbAnnounceChooseDate.Name = "lbAnnounceChooseDate";
            this.lbAnnounceChooseDate.Size = new System.Drawing.Size(171, 16);
            this.lbAnnounceChooseDate.TabIndex = 14;
            this.lbAnnounceChooseDate.Text = "Chọn ngày không phù hợp!!!";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(74, 329);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 42);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "Quay lại";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(626, 329);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(94, 42);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "Tiếp theo";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // comboPartOfDay
            // 
            this.comboPartOfDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPartOfDay.FormattingEnabled = true;
            this.comboPartOfDay.Items.AddRange(new object[] {
            "Buổi sáng",
            "Buối chiều",
            "Buổi tối"});
            this.comboPartOfDay.Location = new System.Drawing.Point(211, 107);
            this.comboPartOfDay.Name = "comboPartOfDay";
            this.comboPartOfDay.Size = new System.Drawing.Size(125, 24);
            this.comboPartOfDay.TabIndex = 10;
            this.comboPartOfDay.SelectedIndexChanged += new System.EventHandler(this.comboPartOfDay_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chọn thời gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "**Thời gian gần nhất của nha sĩ mặc định:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày hẹn:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chọn loại khám";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(626, 329);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 42);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Tiếp theo";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDateCheck);
            this.panel1.Controls.Add(this.comboDatePreCheck);
            this.panel1.Controls.Add(this.rdBtnFirstCheck);
            this.panel1.Controls.Add(this.rdBtnNotFirstCheck);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 2;
            // 
            // lbDateCheck
            // 
            this.lbDateCheck.AutoSize = true;
            this.lbDateCheck.Location = new System.Drawing.Point(26, 120);
            this.lbDateCheck.Name = "lbDateCheck";
            this.lbDateCheck.Size = new System.Drawing.Size(127, 16);
            this.lbDateCheck.TabIndex = 3;
            this.lbDateCheck.Text = "Chọn ngày tái khám:";
            // 
            // comboDatePreCheck
            // 
            this.comboDatePreCheck.FormattingEnabled = true;
            this.comboDatePreCheck.Location = new System.Drawing.Point(177, 117);
            this.comboDatePreCheck.Name = "comboDatePreCheck";
            this.comboDatePreCheck.Size = new System.Drawing.Size(150, 24);
            this.comboDatePreCheck.TabIndex = 2;
            this.comboDatePreCheck.SelectedIndexChanged += new System.EventHandler(this.comboDateCheck_SelectedIndexChanged);
            // 
            // rdBtnFirstCheck
            // 
            this.rdBtnFirstCheck.AutoSize = true;
            this.rdBtnFirstCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdBtnFirstCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFirstCheck.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdBtnFirstCheck.Location = new System.Drawing.Point(29, 28);
            this.rdBtnFirstCheck.Name = "rdBtnFirstCheck";
            this.rdBtnFirstCheck.Size = new System.Drawing.Size(126, 24);
            this.rdBtnFirstCheck.TabIndex = 0;
            this.rdBtnFirstCheck.TabStop = true;
            this.rdBtnFirstCheck.Text = "Khám lần đầu";
            this.rdBtnFirstCheck.UseVisualStyleBackColor = true;
            this.rdBtnFirstCheck.CheckedChanged += new System.EventHandler(this.rdBtnFirstCheck_CheckedChanged);
            // 
            // rdBtnNotFirstCheck
            // 
            this.rdBtnNotFirstCheck.AutoSize = true;
            this.rdBtnNotFirstCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnNotFirstCheck.Location = new System.Drawing.Point(29, 71);
            this.rdBtnNotFirstCheck.Name = "rdBtnNotFirstCheck";
            this.rdBtnNotFirstCheck.Size = new System.Drawing.Size(93, 24);
            this.rdBtnNotFirstCheck.TabIndex = 1;
            this.rdBtnNotFirstCheck.TabStop = true;
            this.rdBtnNotFirstCheck.Text = "Tái khám";
            this.rdBtnNotFirstCheck.UseVisualStyleBackColor = true;
            this.rdBtnNotFirstCheck.CheckedChanged += new System.EventHandler(this.rdBtnNotFirstCheck_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 461);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.btn4);
            this.tabPage3.Controls.Add(this.btn5);
            this.tabPage3.Controls.Add(this.comboTime);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.comboDentist);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chọn nha sĩ";
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(74, 329);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(94, 42);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "Quay lại";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(626, 329);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(94, 42);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "Tạo";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // comboTime
            // 
            this.comboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Location = new System.Drawing.Point(391, 142);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(81, 24);
            this.comboTime.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chọn thời gian khám:";
            // 
            // comboDentist
            // 
            this.comboDentist.FormattingEnabled = true;
            this.comboDentist.Location = new System.Drawing.Point(391, 90);
            this.comboDentist.Name = "comboDentist";
            this.comboDentist.Size = new System.Drawing.Size(230, 24);
            this.comboDentist.TabIndex = 9;
            this.comboDentist.SelectedIndexChanged += new System.EventHandler(this.comboDentist_SelectedIndexChanged);
            this.comboDentist.SelectionChangeCommitted += new System.EventHandler(this.comboDentist_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chọn nha sĩ:";
            // 
            // fCreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "fCreateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo cuộc hẹn";
            this.Load += new System.EventHandler(this.fCreateAppointment_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDateCheck;
        private System.Windows.Forms.ComboBox comboDatePreCheck;
        private System.Windows.Forms.RadioButton rdBtnFirstCheck;
        private System.Windows.Forms.RadioButton rdBtnNotFirstCheck;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPartOfDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbAnnounceChooseDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDentist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBranch;
        private System.Windows.Forms.Label label6;
    }
}