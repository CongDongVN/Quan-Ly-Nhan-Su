namespace QLPB
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
            this.QLPB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.tbSDTPB = new System.Windows.Forms.TextBox();
            this.tbTenPB = new System.Windows.Forms.TextBox();
            this.tbMaPB = new System.Windows.Forms.TextBox();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.QLPB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QLPB
            // 
            this.QLPB.Controls.Add(this.label3);
            this.QLPB.Controls.Add(this.label2);
            this.QLPB.Controls.Add(this.label1);
            this.QLPB.Controls.Add(this.btnDel);
            this.QLPB.Controls.Add(this.btnUp);
            this.QLPB.Controls.Add(this.btnAdd);
            this.QLPB.Controls.Add(this.btTimkiem);
            this.QLPB.Controls.Add(this.tbSDTPB);
            this.QLPB.Controls.Add(this.tbTenPB);
            this.QLPB.Controls.Add(this.tbMaPB);
            this.QLPB.Controls.Add(this.tbTimkiem);
            this.QLPB.Location = new System.Drawing.Point(666, 20);
            this.QLPB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QLPB.Name = "QLPB";
            this.QLPB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QLPB.Size = new System.Drawing.Size(575, 349);
            this.QLPB.TabIndex = 1;
            this.QLPB.TabStop = false;
            this.QLPB.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT PB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên PB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã PB";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(427, 249);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(148, 35);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(222, 249);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(148, 35);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Sửa";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 249);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(296, 25);
            this.btTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(112, 35);
            this.btTimkiem.TabIndex = 1;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // tbSDTPB
            // 
            this.tbSDTPB.Location = new System.Drawing.Point(427, 172);
            this.tbSDTPB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSDTPB.Name = "tbSDTPB";
            this.tbSDTPB.Size = new System.Drawing.Size(148, 26);
            this.tbSDTPB.TabIndex = 0;
            // 
            // tbTenPB
            // 
            this.tbTenPB.Location = new System.Drawing.Point(222, 172);
            this.tbTenPB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTenPB.Name = "tbTenPB";
            this.tbTenPB.Size = new System.Drawing.Size(148, 26);
            this.tbTenPB.TabIndex = 0;
            // 
            // tbMaPB
            // 
            this.tbMaPB.Location = new System.Drawing.Point(30, 172);
            this.tbMaPB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaPB.Name = "tbMaPB";
            this.tbMaPB.Size = new System.Drawing.Size(148, 26);
            this.tbMaPB.TabIndex = 0;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.Location = new System.Drawing.Point(64, 31);
            this.tbTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(148, 26);
            this.tbTimkiem.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 692);
            this.Controls.Add(this.QLPB);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.QLPB.ResumeLayout(false);
            this.QLPB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox QLPB;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.TextBox tbTenPB;
        private System.Windows.Forms.TextBox tbMaPB;
        private System.Windows.Forms.TextBox tbTimkiem;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSDTPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

