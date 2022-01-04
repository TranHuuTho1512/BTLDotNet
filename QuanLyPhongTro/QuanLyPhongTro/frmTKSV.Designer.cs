namespace QuanLyPhongTro
{
    partial class frmTKSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKSV));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCanTim = new System.Windows.Forms.TextBox();
            this.btnOUT = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.radTheoMSSV = new System.Windows.Forms.RadioButton();
            this.radTehoQQ = new System.Windows.Forms.RadioButton();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.radTheoTenSV = new System.Windows.Forms.RadioButton();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(997, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm Thông Tin Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCanTim);
            this.groupBox1.Controls.Add(this.btnOUT);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(this.radTheoMSSV);
            this.groupBox1.Controls.Add(this.radTehoQQ);
            this.groupBox1.Controls.Add(this.radLop);
            this.groupBox1.Controls.Add(this.radTheoTenSV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm";
            // 
            // txtCanTim
            // 
            this.txtCanTim.Location = new System.Drawing.Point(12, 60);
            this.txtCanTim.Name = "txtCanTim";
            this.txtCanTim.Size = new System.Drawing.Size(249, 26);
            this.txtCanTim.TabIndex = 4;
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(574, 60);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(134, 28);
            this.btnOUT.TabIndex = 6;
            this.btnOUT.Text = "Thoát";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(284, 59);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(96, 28);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Tìm";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // radTheoMSSV
            // 
            this.radTheoMSSV.AutoSize = true;
            this.radTheoMSSV.Location = new System.Drawing.Point(12, 28);
            this.radTheoMSSV.Name = "radTheoMSSV";
            this.radTheoMSSV.Size = new System.Drawing.Size(81, 24);
            this.radTheoMSSV.TabIndex = 0;
            this.radTheoMSSV.TabStop = true;
            this.radTheoMSSV.Text = "MSSV";
            this.radTheoMSSV.UseVisualStyleBackColor = true;
            this.radTheoMSSV.CheckedChanged += new System.EventHandler(this.radTheoMSSV_CheckedChanged);
            // 
            // radTehoQQ
            // 
            this.radTehoQQ.AutoSize = true;
            this.radTehoQQ.Location = new System.Drawing.Point(506, 28);
            this.radTehoQQ.Name = "radTehoQQ";
            this.radTehoQQ.Size = new System.Drawing.Size(114, 24);
            this.radTehoQQ.TabIndex = 3;
            this.radTehoQQ.TabStop = true;
            this.radTehoQQ.Text = "Quê Quán";
            this.radTehoQQ.UseVisualStyleBackColor = true;
            this.radTehoQQ.CheckedChanged += new System.EventHandler(this.radTehoQQ_CheckedChanged);
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(349, 28);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(72, 24);
            this.radLop.TabIndex = 2;
            this.radLop.TabStop = true;
            this.radLop.Text = "Khoa";
            this.radLop.UseVisualStyleBackColor = true;
            this.radLop.CheckedChanged += new System.EventHandler(this.radLop_CheckedChanged);
            // 
            // radTheoTenSV
            // 
            this.radTheoTenSV.AutoSize = true;
            this.radTheoTenSV.Location = new System.Drawing.Point(170, 28);
            this.radTheoTenSV.Name = "radTheoTenSV";
            this.radTheoTenSV.Size = new System.Drawing.Size(91, 24);
            this.radTheoTenSV.TabIndex = 1;
            this.radTheoTenSV.TabStop = true;
            this.radTheoTenSV.Text = "Tên SV";
            this.radTheoTenSV.UseVisualStyleBackColor = true;
            this.radTheoTenSV.CheckedChanged += new System.EventHandler(this.radTheoTenSV_CheckedChanged);
            // 
            // dgvSV
            // 
            this.dgvSV.AllowUserToAddRows = false;
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSV.BackgroundColor = System.Drawing.Color.White;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSV.Location = new System.Drawing.Point(0, 141);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.Size = new System.Drawing.Size(997, 409);
            this.dgvSV.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTKSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 550);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTKSV";
            this.Text = "frmTKSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCanTim;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.RadioButton radTheoMSSV;
        private System.Windows.Forms.RadioButton radTheoTenSV;
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.RadioButton radTehoQQ;
        private System.Windows.Forms.Button button1;
    }
}