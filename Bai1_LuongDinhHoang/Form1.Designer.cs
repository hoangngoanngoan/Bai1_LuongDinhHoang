namespace Bai1_LuongDinhHoang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            txtbsx = new TextBox();
            label3 = new Label();
            btnxoa = new Button();
            groupBox1 = new GroupBox();
            txtgbanx = new TextBox();
            btnthem = new Button();
            txtnamsxx = new TextBox();
            txttenx = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dt1 = new DataGridView();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            label7 = new Label();
            txtbsoxd = new TextBox();
            btnxoaxd = new Button();
            groupBox2 = new GroupBox();
            txtpin = new TextBox();
            btnthemxd = new Button();
            label9 = new Label();
            txtgbanxd = new TextBox();
            txttenxd = new TextBox();
            label5 = new Label();
            txtnamxd = new TextBox();
            label6 = new Label();
            label8 = new Label();
            dt2 = new DataGridView();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).BeginInit();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dt1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 281);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtbsx);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnxoa);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(376, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(427, 281);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Xóa xe";
            // 
            // txtbsx
            // 
            txtbsx.Location = new Point(105, 44);
            txtbsx.Name = "txtbsx";
            txtbsx.Size = new Size(171, 27);
            txtbsx.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 47);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Biển số xe:";
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(105, 83);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "Xóa xe";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtgbanx);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(txtnamsxx);
            groupBox1.Controls.Add(txttenx);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 281);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm xe";
            // 
            // txtgbanx
            // 
            txtgbanx.Location = new Point(139, 123);
            txtgbanx.Name = "txtgbanx";
            txtgbanx.Size = new Size(155, 27);
            txtgbanx.TabIndex = 3;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(140, 169);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm xe";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txtnamsxx
            // 
            txtnamsxx.Location = new Point(139, 80);
            txtnamsxx.Name = "txtnamsxx";
            txtnamsxx.Size = new Size(155, 27);
            txtnamsxx.TabIndex = 3;
            // 
            // txttenx
            // 
            txttenx.Location = new Point(140, 44);
            txttenx.Name = "txttenx";
            txttenx.Size = new Size(155, 27);
            txttenx.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 126);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Gía bán:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 83);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Năm sản xuất:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Hảng xe:";
            // 
            // dt1
            // 
            dt1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt1.Dock = DockStyle.Right;
            dt1.Location = new Point(803, 0);
            dt1.Name = "dt1";
            dt1.RowHeadersWidth = 51;
            dt1.Size = new Size(738, 281);
            dt1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(dt2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(1541, 327);
            panel2.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtbsoxd);
            groupBox4.Controls.Add(btnxoaxd);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(376, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(427, 327);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Xóa xe điện";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 42);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 4;
            label7.Text = "Biến số xe:";
            // 
            // txtbsoxd
            // 
            txtbsoxd.Location = new Point(105, 39);
            txtbsoxd.Name = "txtbsoxd";
            txtbsoxd.Size = new Size(171, 27);
            txtbsoxd.TabIndex = 3;
            // 
            // btnxoaxd
            // 
            btnxoaxd.Location = new Point(105, 78);
            btnxoaxd.Name = "btnxoaxd";
            btnxoaxd.Size = new Size(94, 29);
            btnxoaxd.TabIndex = 2;
            btnxoaxd.Text = "Xóa xe";
            btnxoaxd.UseVisualStyleBackColor = true;
            btnxoaxd.Click += btnxoaxd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtpin);
            groupBox2.Controls.Add(btnthemxd);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtgbanxd);
            groupBox2.Controls.Add(txttenxd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtnamxd);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 327);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thêm xe điện";
            // 
            // txtpin
            // 
            txtpin.Location = new Point(140, 143);
            txtpin.Name = "txtpin";
            txtpin.Size = new Size(154, 27);
            txtpin.TabIndex = 6;
            // 
            // btnthemxd
            // 
            btnthemxd.Location = new Point(140, 194);
            btnthemxd.Name = "btnthemxd";
            btnthemxd.Size = new Size(94, 29);
            btnthemxd.TabIndex = 0;
            btnthemxd.Text = "Thêm xe điện";
            btnthemxd.UseVisualStyleBackColor = true;
            btnthemxd.Click += btnthemxd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 146);
            label9.Name = "label9";
            label9.Size = new Size(32, 20);
            label9.TabIndex = 5;
            label9.Text = "Pin:";
            // 
            // txtgbanxd
            // 
            txtgbanxd.Location = new Point(140, 110);
            txtgbanxd.Name = "txtgbanxd";
            txtgbanxd.Size = new Size(155, 27);
            txtgbanxd.TabIndex = 4;
            // 
            // txttenxd
            // 
            txttenxd.Location = new Point(140, 39);
            txttenxd.Name = "txttenxd";
            txttenxd.Size = new Size(155, 27);
            txttenxd.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 42);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 0;
            label5.Text = "Hảng xe:";
            // 
            // txtnamxd
            // 
            txtnamxd.Location = new Point(140, 75);
            txtnamxd.Name = "txtnamxd";
            txtnamxd.Size = new Size(155, 27);
            txtnamxd.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 78);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 1;
            label6.Text = "Năm sản xuất:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 113);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 3;
            label8.Text = "Gía bán:";
            // 
            // dt2
            // 
            dt2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt2.Dock = DockStyle.Right;
            dt2.Location = new Point(803, 0);
            dt2.Name = "dt2";
            dt2.RowHeadersWidth = 51;
            dt2.Size = new Size(738, 327);
            dt2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 608);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình quản lý xe 2024";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).EndInit();
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dt1;
        private Panel panel2;
        private DataGridView dt2;
        private Button btnxoa;
        private Button btnthem;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtbsoxd;
        private TextBox txtbsx;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnxoaxd;
        private Button btnthemxd;
        private TextBox txtgbanxd;
        private TextBox txttenxd;
        private Label label5;
        private TextBox txtnamxd;
        private Label label6;
        private Label label8;
        private Label label10;
        private TextBox txtpin;
        private Label label9;
        private TextBox txtgbanx;
        private TextBox txtnamsxx;
        private TextBox txttenx;
        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox4;
        private Label label7;
    }
}
