namespace Trinhdohocvan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMatrinhdo = new System.Windows.Forms.TextBox();
            this.txtTentrinhdo = new System.Windows.Forms.TextBox();
            this.txtTenchuyennganh = new System.Windows.Forms.TextBox();
            this.labMa = new System.Windows.Forms.Label();
            this.labTen = new System.Windows.Forms.Label();
            this.labCNganh = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtMatrinhdo
            // 
            this.txtMatrinhdo.Location = new System.Drawing.Point(111, 12);
            this.txtMatrinhdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatrinhdo.Name = "txtMatrinhdo";
            this.txtMatrinhdo.Size = new System.Drawing.Size(139, 20);
            this.txtMatrinhdo.TabIndex = 1;
            this.txtMatrinhdo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTentrinhdo
            // 
            this.txtTentrinhdo.Location = new System.Drawing.Point(111, 55);
            this.txtTentrinhdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTentrinhdo.Name = "txtTentrinhdo";
            this.txtTentrinhdo.Size = new System.Drawing.Size(139, 20);
            this.txtTentrinhdo.TabIndex = 2;
            // 
            // txtTenchuyennganh
            // 
            this.txtTenchuyennganh.Location = new System.Drawing.Point(111, 98);
            this.txtTenchuyennganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenchuyennganh.Name = "txtTenchuyennganh";
            this.txtTenchuyennganh.Size = new System.Drawing.Size(139, 20);
            this.txtTenchuyennganh.TabIndex = 3;
            // 
            // labMa
            // 
            this.labMa.AutoSize = true;
            this.labMa.Location = new System.Drawing.Point(4, 17);
            this.labMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMa.Name = "labMa";
            this.labMa.Size = new System.Drawing.Size(61, 13);
            this.labMa.TabIndex = 4;
            this.labMa.Text = "Mã trình độ";
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(4, 60);
            this.labTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(64, 13);
            this.labTen.TabIndex = 5;
            this.labTen.Text = "Tên trình dộ";
            // 
            // labCNganh
            // 
            this.labCNganh.AutoSize = true;
            this.labCNganh.Location = new System.Drawing.Point(4, 103);
            this.labCNganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCNganh.Name = "labCNganh";
            this.labCNganh.Size = new System.Drawing.Size(97, 13);
            this.labCNganh.TabIndex = 6;
            this.labCNganh.Text = "Tên chuyên ngành";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(7, 18);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(161, 20);
            this.txtTimkiem.TabIndex = 7;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(178, 11);
            this.btTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(69, 32);
            this.btTimkiem.TabIndex = 8;
            this.btTimkiem.Text = "Tìm Kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labMa);
            this.groupBox1.Controls.Add(this.labTen);
            this.groupBox1.Controls.Add(this.labCNganh);
            this.groupBox1.Controls.Add(this.txtTenchuyennganh);
            this.groupBox1.Controls.Add(this.txtMatrinhdo);
            this.groupBox1.Controls.Add(this.txtTentrinhdo);
            this.groupBox1.Location = new System.Drawing.Point(20, 210);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(254, 125);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(335, 286);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(74, 32);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(422, 286);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(74, 32);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(508, 286);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(74, 32);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.btTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(335, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(252, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMatrinhdo;
        private System.Windows.Forms.TextBox txtTentrinhdo;
        private System.Windows.Forms.TextBox txtTenchuyennganh;
        private System.Windows.Forms.Label labMa;
        private System.Windows.Forms.Label labTen;
        private System.Windows.Forms.Label labCNganh;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

