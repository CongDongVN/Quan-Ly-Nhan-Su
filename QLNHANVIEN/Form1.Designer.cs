namespace QLNHANVIEN
{
    partial class Form1
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
            this.bangluong = new System.Windows.Forms.DataGridView();
            this.nuttimkiem = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.Tbbacluong = new System.Windows.Forms.TextBox();
            this.Tbluongcoban = new System.Windows.Forms.TextBox();
            this.Tbhesophucap = new System.Windows.Forms.TextBox();
            this.Tbhesoluong = new System.Windows.Forms.TextBox();
            this.nutthem = new System.Windows.Forms.Button();
            this.nutsua = new System.Windows.Forms.Button();
            this.nutxoa = new System.Windows.Forms.Button();
            this.nuttinhtong = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Label();
            this.bacluong = new System.Windows.Forms.Label();
            this.luongcoban = new System.Windows.Forms.Label();
            this.hesoluong = new System.Windows.Forms.Label();
            this.hesophucap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tongluong = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bangluong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangluong
            // 
            this.bangluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangluong.Location = new System.Drawing.Point(10, 65);
            this.bangluong.Name = "bangluong";
            this.bangluong.RowHeadersWidth = 51;
            this.bangluong.Size = new System.Drawing.Size(545, 262);
            this.bangluong.TabIndex = 0;
            this.bangluong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangluong_CellContentClick);
            // 
            // nuttimkiem
            // 
            this.nuttimkiem.Location = new System.Drawing.Point(356, 21);
            this.nuttimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nuttimkiem.Name = "nuttimkiem";
            this.nuttimkiem.Size = new System.Drawing.Size(80, 20);
            this.nuttimkiem.TabIndex = 0;
            this.nuttimkiem.Text = "Tim kiem";
            this.nuttimkiem.UseVisualStyleBackColor = true;
            this.nuttimkiem.Click += new System.EventHandler(this.nuttimkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(127, 21);
            this.tbtimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(209, 20);
            this.tbtimkiem.TabIndex = 1;
            // 
            // Tbbacluong
            // 
            this.Tbbacluong.Location = new System.Drawing.Point(128, 14);
            this.Tbbacluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tbbacluong.Name = "Tbbacluong";
            this.Tbbacluong.Size = new System.Drawing.Size(149, 20);
            this.Tbbacluong.TabIndex = 2;
            // 
            // Tbluongcoban
            // 
            this.Tbluongcoban.Location = new System.Drawing.Point(128, 37);
            this.Tbluongcoban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tbluongcoban.Name = "Tbluongcoban";
            this.Tbluongcoban.Size = new System.Drawing.Size(149, 20);
            this.Tbluongcoban.TabIndex = 3;
            // 
            // Tbhesophucap
            // 
            this.Tbhesophucap.Location = new System.Drawing.Point(128, 82);
            this.Tbhesophucap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tbhesophucap.Name = "Tbhesophucap";
            this.Tbhesophucap.Size = new System.Drawing.Size(149, 20);
            this.Tbhesophucap.TabIndex = 4;
            // 
            // Tbhesoluong
            // 
            this.Tbhesoluong.Location = new System.Drawing.Point(128, 59);
            this.Tbhesoluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tbhesoluong.Name = "Tbhesoluong";
            this.Tbhesoluong.Size = new System.Drawing.Size(149, 20);
            this.Tbhesoluong.TabIndex = 5;
            // 
            // nutthem
            // 
            this.nutthem.Location = new System.Drawing.Point(4, 27);
            this.nutthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nutthem.Name = "nutthem";
            this.nutthem.Size = new System.Drawing.Size(82, 37);
            this.nutthem.TabIndex = 7;
            this.nutthem.Text = "Thêm";
            this.nutthem.UseVisualStyleBackColor = true;
            this.nutthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // nutsua
            // 
            this.nutsua.Location = new System.Drawing.Point(112, 27);
            this.nutsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nutsua.Name = "nutsua";
            this.nutsua.Size = new System.Drawing.Size(82, 37);
            this.nutsua.TabIndex = 8;
            this.nutsua.Text = "Sửa";
            this.nutsua.UseVisualStyleBackColor = true;
            this.nutsua.Click += new System.EventHandler(this.nutsua_Click);
            // 
            // nutxoa
            // 
            this.nutxoa.Location = new System.Drawing.Point(218, 27);
            this.nutxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nutxoa.Name = "nutxoa";
            this.nutxoa.Size = new System.Drawing.Size(82, 37);
            this.nutxoa.TabIndex = 9;
            this.nutxoa.Text = "Xóa";
            this.nutxoa.UseVisualStyleBackColor = true;
            this.nutxoa.Click += new System.EventHandler(this.nutxoa_Click);
            // 
            // nuttinhtong
            // 
            this.nuttinhtong.Location = new System.Drawing.Point(64, 349);
            this.nuttinhtong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nuttinhtong.Name = "nuttinhtong";
            this.nuttinhtong.Size = new System.Drawing.Size(86, 31);
            this.nuttinhtong.TabIndex = 10;
            this.nuttinhtong.Text = "Tính tổng";
            this.nuttinhtong.UseVisualStyleBackColor = true;
            this.nuttinhtong.Click += new System.EventHandler(this.button4_Click);
            // 
            // timkiem
            // 
            this.timkiem.AutoSize = true;
            this.timkiem.Location = new System.Drawing.Point(62, 21);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(49, 13);
            this.timkiem.TabIndex = 11;
            this.timkiem.Text = "Tìm kiếm";
            // 
            // bacluong
            // 
            this.bacluong.AutoSize = true;
            this.bacluong.Location = new System.Drawing.Point(11, 19);
            this.bacluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bacluong.Name = "bacluong";
            this.bacluong.Size = new System.Drawing.Size(55, 13);
            this.bacluong.TabIndex = 12;
            this.bacluong.Text = "Bậc lương";
            // 
            // luongcoban
            // 
            this.luongcoban.AutoSize = true;
            this.luongcoban.Location = new System.Drawing.Point(11, 41);
            this.luongcoban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.luongcoban.Name = "luongcoban";
            this.luongcoban.Size = new System.Drawing.Size(75, 13);
            this.luongcoban.TabIndex = 13;
            this.luongcoban.Text = "Lương Cơ Bản";
            // 
            // hesoluong
            // 
            this.hesoluong.AutoSize = true;
            this.hesoluong.Location = new System.Drawing.Point(11, 64);
            this.hesoluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hesoluong.Name = "hesoluong";
            this.hesoluong.Size = new System.Drawing.Size(70, 13);
            this.hesoluong.TabIndex = 14;
            this.hesoluong.Text = "Hệ Số Lương";
            // 
            // hesophucap
            // 
            this.hesophucap.AutoSize = true;
            this.hesophucap.Location = new System.Drawing.Point(11, 87);
            this.hesophucap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hesophucap.Name = "hesophucap";
            this.hesophucap.Size = new System.Drawing.Size(81, 13);
            this.hesophucap.TabIndex = 15;
            this.hesophucap.Text = "Hệ Sô Phụ Cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbhesophucap);
            this.groupBox1.Controls.Add(this.Tbhesoluong);
            this.groupBox1.Controls.Add(this.Tbluongcoban);
            this.groupBox1.Controls.Add(this.Tbbacluong);
            this.groupBox1.Controls.Add(this.bacluong);
            this.groupBox1.Controls.Add(this.hesophucap);
            this.groupBox1.Controls.Add(this.luongcoban);
            this.groupBox1.Controls.Add(this.hesoluong);
            this.groupBox1.Location = new System.Drawing.Point(573, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(304, 136);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // tongluong
            // 
            this.tongluong.AutoSize = true;
            this.tongluong.Location = new System.Drawing.Point(166, 358);
            this.tongluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tongluong.Name = "tongluong";
            this.tongluong.Size = new System.Drawing.Size(67, 13);
            this.tongluong.TabIndex = 18;
            this.tongluong.Text = "Tổng lương: ";
            this.tongluong.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nutsua);
            this.groupBox2.Controls.Add(this.nutthem);
            this.groupBox2.Controls.Add(this.nutxoa);
            this.groupBox2.Location = new System.Drawing.Point(573, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(304, 81);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tongluong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nuttinhtong);
            this.Controls.Add(this.bangluong);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.nuttimkiem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangluong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bangluong;
        private System.Windows.Forms.Button nuttimkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.TextBox Tbbacluong;
        private System.Windows.Forms.TextBox Tbluongcoban;
        private System.Windows.Forms.TextBox Tbhesophucap;
        private System.Windows.Forms.TextBox Tbhesoluong;
        private System.Windows.Forms.Button nutthem;
        private System.Windows.Forms.Button nutsua;
        private System.Windows.Forms.Button nutxoa;
        private System.Windows.Forms.Button nuttinhtong;
        private System.Windows.Forms.Label timkiem;
        private System.Windows.Forms.Label bacluong;
        private System.Windows.Forms.Label luongcoban;
        private System.Windows.Forms.Label hesoluong;
        private System.Windows.Forms.Label hesophucap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tongluong;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

