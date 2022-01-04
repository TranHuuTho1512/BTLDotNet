namespace QuanLyPhongTro
{
    partial class frmTKPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCanTim = new System.Windows.Forms.TextBox();
            this.btnOUT = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.radTheoTenPhong = new System.Windows.Forms.RadioButton();
            this.radIDChuTro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCanTim);
            this.groupBox1.Controls.Add(this.btnOUT);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(this.radTheoTenPhong);
            this.groupBox1.Controls.Add(this.radIDChuTro);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1319, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm";
            // 
            // txtCanTim
            // 
            this.txtCanTim.Location = new System.Drawing.Point(12, 60);
            this.txtCanTim.Name = "txtCanTim";
            this.txtCanTim.Size = new System.Drawing.Size(249, 26);
            this.txtCanTim.TabIndex = 2;
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(589, 59);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(134, 28);
            this.btnOUT.TabIndex = 4;
            this.btnOUT.Text = "Thoát";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(284, 59);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(96, 28);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Tìm";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // radTheoTenPhong
            // 
            this.radTheoTenPhong.AutoSize = true;
            this.radTheoTenPhong.Location = new System.Drawing.Point(12, 28);
            this.radTheoTenPhong.Name = "radTheoTenPhong";
            this.radTheoTenPhong.Size = new System.Drawing.Size(119, 24);
            this.radTheoTenPhong.TabIndex = 0;
            this.radTheoTenPhong.TabStop = true;
            this.radTheoTenPhong.Text = "Tên Phòng";
            this.radTheoTenPhong.UseVisualStyleBackColor = true;
            this.radTheoTenPhong.CheckedChanged += new System.EventHandler(this.radTheoTenPhong_CheckedChanged);
            // 
            // radIDChuTro
            // 
            this.radIDChuTro.AutoSize = true;
            this.radIDChuTro.Location = new System.Drawing.Point(170, 28);
            this.radIDChuTro.Name = "radIDChuTro";
            this.radIDChuTro.Size = new System.Drawing.Size(122, 24);
            this.radIDChuTro.TabIndex = 1;
            this.radIDChuTro.TabStop = true;
            this.radIDChuTro.Text = "ID Chủ Trọ";
            this.radIDChuTro.UseVisualStyleBackColor = true;
            this.radIDChuTro.CheckedChanged += new System.EventHandler(this.radIDChuTro_CheckedChanged);
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
            this.label1.Size = new System.Drawing.Size(1319, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm Thông Tin Phòng Trọ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 141);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(1319, 545);
            this.dgvPhong.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTKPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 686);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTKPhong";
            this.Text = "frmTKPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCanTim;
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.RadioButton radTheoTenPhong;
        private System.Windows.Forms.RadioButton radIDChuTro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button button1;
    }
}