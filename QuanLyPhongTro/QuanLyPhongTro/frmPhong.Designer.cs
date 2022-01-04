namespace QuanLyPhongTro
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTTP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSoLuongSV = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnLuuPhong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lvwPhong = new System.Windows.Forms.ListView();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNut.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1317, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh Sách Phòng Trọ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1317, 180);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Liệu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTTP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboSoLuongSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(507, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 147);
            this.panel2.TabIndex = 4;
            // 
            // cboTTP
            // 
            this.cboTTP.FormattingEnabled = true;
            this.cboTTP.Items.AddRange(new object[] {
            "Còn",
            "Hết"});
            this.cboTTP.Location = new System.Drawing.Point(343, 21);
            this.cboTTP.Margin = new System.Windows.Forms.Padding(4);
            this.cboTTP.Name = "cboTTP";
            this.cboTTP.Size = new System.Drawing.Size(113, 37);
            this.cboTTP.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng sinh viên/1 phòng";
            // 
            // cboSoLuongSV
            // 
            this.cboSoLuongSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSoLuongSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoLuongSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSoLuongSV.FormattingEnabled = true;
            this.cboSoLuongSV.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboSoLuongSV.Location = new System.Drawing.Point(343, 73);
            this.cboSoLuongSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSoLuongSV.Name = "cboSoLuongSV";
            this.cboSoLuongSV.Size = new System.Drawing.Size(113, 37);
            this.cboSoLuongSV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenPhong);
            this.panel1.Controls.Add(this.txtGiaPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 147);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(147, 31);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(348, 36);
            this.txtTenPhong.TabIndex = 0;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.Location = new System.Drawing.Point(147, 76);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(348, 36);
            this.txtGiaPhong.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThoat.Location = new System.Drawing.Point(3, 374);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(195, 92);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaPhong.Enabled = false;
            this.btnSuaPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhong.Image")));
            this.btnSuaPhong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSuaPhong.Location = new System.Drawing.Point(3, 188);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(195, 89);
            this.btnSuaPhong.TabIndex = 2;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaPhong.Enabled = false;
            this.btnXoaPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhong.Image")));
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoaPhong.Location = new System.Drawing.Point(3, 281);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(195, 89);
            this.btnXoaPhong.TabIndex = 3;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnLuuPhong
            // 
            this.btnLuuPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuuPhong.Enabled = false;
            this.btnLuuPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhong.Image")));
            this.btnLuuPhong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLuuPhong.Location = new System.Drawing.Point(3, 95);
            this.btnLuuPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuPhong.Name = "btnLuuPhong";
            this.btnLuuPhong.Size = new System.Drawing.Size(195, 89);
            this.btnLuuPhong.TabIndex = 1;
            this.btnLuuPhong.Text = "Lưu";
            this.btnLuuPhong.UseVisualStyleBackColor = false;
            this.btnLuuPhong.Click += new System.EventHandler(this.btnLuuPhong_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(193, 85);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lvwPhong
            // 
            this.lvwPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvwPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPhong.HideSelection = false;
            this.lvwPhong.Location = new System.Drawing.Point(0, 222);
            this.lvwPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwPhong.Name = "lvwPhong";
            this.lvwPhong.Size = new System.Drawing.Size(1112, 468);
            this.lvwPhong.TabIndex = 14;
            this.lvwPhong.UseCompatibleStateImageBehavior = false;
            this.lvwPhong.SelectedIndexChanged += new System.EventHandler(this.lvwPhong_SelectedIndexChanged);
            // 
            // pnlNut
            // 
            this.pnlNut.Controls.Add(this.tableLayoutPanel1);
            this.pnlNut.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNut.Location = new System.Drawing.Point(1116, 222);
            this.pnlNut.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.Size = new System.Drawing.Size(201, 468);
            this.pnlNut.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuuPhong, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSuaPhong, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXoaPhong, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnThoat, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 690);
            this.ControlBox = false;
            this.Controls.Add(this.lvwPhong);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhong";
            this.Text = "Quản lý phòng trọ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhong_FormClosing);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNut.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnLuuPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboSoLuongSV;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvwPhong;
        private System.Windows.Forms.Panel pnlNut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cboTTP;
    }
}