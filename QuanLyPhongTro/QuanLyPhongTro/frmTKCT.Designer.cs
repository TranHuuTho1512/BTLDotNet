namespace QuanLyPhongTro
{
    partial class frmTKCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKCT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCanTim = new System.Windows.Forms.TextBox();
            this.btnOUT = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.radDiaChiCT = new System.Windows.Forms.RadioButton();
            this.radSDTCT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChuTro = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuTro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCanTim);
            this.groupBox1.Controls.Add(this.btnOUT);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(this.radDiaChiCT);
            this.groupBox1.Controls.Add(this.radSDTCT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1143, 99);
            this.groupBox1.TabIndex = 11;
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
            this.btnOUT.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOUT.Location = new System.Drawing.Point(630, 58);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(134, 28);
            this.btnOUT.TabIndex = 4;
            this.btnOUT.Text = "Thoát";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThucHien.Location = new System.Drawing.Point(284, 59);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(96, 28);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Tìm";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // radDiaChiCT
            // 
            this.radDiaChiCT.AutoSize = true;
            this.radDiaChiCT.Location = new System.Drawing.Point(12, 28);
            this.radDiaChiCT.Name = "radDiaChiCT";
            this.radDiaChiCT.Size = new System.Drawing.Size(89, 24);
            this.radDiaChiCT.TabIndex = 0;
            this.radDiaChiCT.TabStop = true;
            this.radDiaChiCT.Text = "Địa chỉ";
            this.radDiaChiCT.UseVisualStyleBackColor = true;
            this.radDiaChiCT.CheckedChanged += new System.EventHandler(this.radDiaChiCT_CheckedChanged);
            // 
            // radSDTCT
            // 
            this.radSDTCT.AutoSize = true;
            this.radSDTCT.Location = new System.Drawing.Point(169, 28);
            this.radSDTCT.Name = "radSDTCT";
            this.radSDTCT.Size = new System.Drawing.Size(140, 24);
            this.radSDTCT.TabIndex = 1;
            this.radSDTCT.TabStop = true;
            this.radSDTCT.Text = "Số điện thoại";
            this.radSDTCT.UseVisualStyleBackColor = true;
            this.radSDTCT.CheckedChanged += new System.EventHandler(this.radSDTCT_CheckedChanged);
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
            this.label1.Size = new System.Drawing.Size(1143, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm Kiếm Thông Tin Chủ Trọ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvChuTro
            // 
            this.dgvChuTro.AllowUserToAddRows = false;
            this.dgvChuTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuTro.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuTro.Location = new System.Drawing.Point(0, 141);
            this.dgvChuTro.Name = "dgvChuTro";
            this.dgvChuTro.Size = new System.Drawing.Size(1143, 472);
            this.dgvChuTro.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(436, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTKCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 613);
            this.Controls.Add(this.dgvChuTro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTKCT";
            this.Text = "frmTKCT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKCT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCanTim;
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.RadioButton radDiaChiCT;
        private System.Windows.Forms.RadioButton radSDTCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChuTro;
        private System.Windows.Forms.Button button1;
    }
}