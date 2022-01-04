namespace QuanLyPhongTro
{
    partial class frmQly
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQly));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.lbGio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbNgay = new System.Windows.Forms.Label();
            this.ptbMenu = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tVadmin = new System.Windows.Forms.TreeView();
            this.ImageTree = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwChuTro = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lvwPhongTro = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwSinhvien = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQlyChuTro = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btntkChuTro = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btntkPhong = new System.Windows.Forms.Button();
            this.btntkSV = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.lbGio);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbNgay);
            this.panel2.Controls.Add(this.ptbMenu);
            this.panel2.Controls.Add(this.lb);
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 50);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.LightCyan;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Location = new System.Drawing.Point(159, 12);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(103, 36);
            this.btnreset.TabIndex = 0;
            this.btnreset.Text = "Làm Mới";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.BackColor = System.Drawing.Color.LightCyan;
            this.lbGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.Location = new System.Drawing.Point(374, 28);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(15, 15);
            this.lbGio.TabIndex = 13;
            this.lbGio.Text = "1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1324, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.BackColor = System.Drawing.Color.LightCyan;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(384, 9);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(15, 15);
            this.lbNgay.TabIndex = 14;
            this.lbNgay.Text = "1";
            // 
            // ptbMenu
            // 
            this.ptbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ptbMenu.Location = new System.Drawing.Point(0, 0);
            this.ptbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(59, 50);
            this.ptbMenu.TabIndex = 1;
            this.ptbMenu.Text = "...";
            this.ptbMenu.UseVisualStyleBackColor = true;
            this.ptbMenu.Click += new System.EventHandler(this.ptbMenu_Click_1);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.LightCyan;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(339, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(39, 15);
            this.lb.TabIndex = 15;
            this.lb.Text = "Ngày";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.LightCyan;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(71, 11);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 31);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Menu";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1371, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quản lý tổng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(216, 50);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tVadmin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1155, 700);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 9;
            // 
            // tVadmin
            // 
            this.tVadmin.AllowDrop = true;
            this.tVadmin.BackColor = System.Drawing.Color.LightCyan;
            this.tVadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tVadmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tVadmin.ImageIndex = 0;
            this.tVadmin.ImageList = this.ImageTree;
            this.tVadmin.Location = new System.Drawing.Point(0, 0);
            this.tVadmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tVadmin.Name = "tVadmin";
            this.tVadmin.SelectedImageIndex = 0;
            this.tVadmin.ShowPlusMinus = false;
            this.tVadmin.Size = new System.Drawing.Size(174, 700);
            this.tVadmin.TabIndex = 1;
            this.tVadmin.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVadmin_AfterSelect_1);
            this.tVadmin.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tVadmin_NodeMouseClick);
            // 
            // ImageTree
            // 
            this.ImageTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageTree.ImageStream")));
            this.ImageTree.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageTree.Images.SetKeyName(0, "chutrodong.png");
            this.ImageTree.Images.SetKeyName(1, "chutromo.png");
            this.ImageTree.Images.SetKeyName(2, "house close.png");
            this.ImageTree.Images.SetKeyName(3, "house open.png");
            this.ImageTree.Images.SetKeyName(4, "sv.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwChuTro);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(977, 700);
            this.splitContainer2.SplitterDistance = 134;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvwChuTro
            // 
            this.lvwChuTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwChuTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwChuTro.HideSelection = false;
            this.lvwChuTro.Location = new System.Drawing.Point(0, 39);
            this.lvwChuTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwChuTro.MultiSelect = false;
            this.lvwChuTro.Name = "lvwChuTro";
            this.lvwChuTro.Size = new System.Drawing.Size(977, 95);
            this.lvwChuTro.TabIndex = 2;
            this.lvwChuTro.UseCompatibleStateImageBehavior = false;
            this.lvwChuTro.SelectedIndexChanged += new System.EventHandler(this.lvwChuTro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(977, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách chủ trọ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lvwPhongTro);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lvwSinhvien);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(977, 562);
            this.splitContainer3.SplitterDistance = 130;
            this.splitContainer3.TabIndex = 0;
            // 
            // lvwPhongTro
            // 
            this.lvwPhongTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwPhongTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwPhongTro.HideSelection = false;
            this.lvwPhongTro.Location = new System.Drawing.Point(0, 39);
            this.lvwPhongTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwPhongTro.MultiSelect = false;
            this.lvwPhongTro.Name = "lvwPhongTro";
            this.lvwPhongTro.Size = new System.Drawing.Size(977, 91);
            this.lvwPhongTro.TabIndex = 4;
            this.lvwPhongTro.UseCompatibleStateImageBehavior = false;
            this.lvwPhongTro.SelectedIndexChanged += new System.EventHandler(this.lvwPhongTro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(977, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách phòng trọ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwSinhvien
            // 
            this.lvwSinhvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwSinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSinhvien.HideSelection = false;
            this.lvwSinhvien.Location = new System.Drawing.Point(0, 39);
            this.lvwSinhvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwSinhvien.MultiSelect = false;
            this.lvwSinhvien.Name = "lvwSinhvien";
            this.lvwSinhvien.Size = new System.Drawing.Size(977, 389);
            this.lvwSinhvien.TabIndex = 4;
            this.lvwSinhvien.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(977, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách sinh viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightCyan;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.tableLayoutPanel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(216, 700);
            this.pnlMenu.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnQlyChuTro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThongTin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btntkChuTro, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOut, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btntkPhong, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btntkSV, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 464);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnQlyChuTro
            // 
            this.btnQlyChuTro.BackColor = System.Drawing.Color.LightCyan;
            this.btnQlyChuTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQlyChuTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQlyChuTro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQlyChuTro.Location = new System.Drawing.Point(3, 2);
            this.btnQlyChuTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQlyChuTro.Name = "btnQlyChuTro";
            this.btnQlyChuTro.Size = new System.Drawing.Size(208, 73);
            this.btnQlyChuTro.TabIndex = 0;
            this.btnQlyChuTro.Text = "Quản lý Chủ Trọ";
            this.btnQlyChuTro.UseVisualStyleBackColor = false;
            this.btnQlyChuTro.Click += new System.EventHandler(this.btnQlyTro_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.LightCyan;
            this.btnThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongTin.Location = new System.Drawing.Point(3, 79);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(208, 73);
            this.btnThongTin.TabIndex = 1;
            this.btnThongTin.Text = "Thông tin phần mềm";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btntkChuTro
            // 
            this.btntkChuTro.BackColor = System.Drawing.Color.LightCyan;
            this.btntkChuTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntkChuTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btntkChuTro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntkChuTro.Location = new System.Drawing.Point(3, 156);
            this.btntkChuTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntkChuTro.Name = "btntkChuTro";
            this.btntkChuTro.Size = new System.Drawing.Size(208, 73);
            this.btntkChuTro.TabIndex = 2;
            this.btntkChuTro.Text = "Tìm Chủ trọ";
            this.btntkChuTro.UseVisualStyleBackColor = false;
            this.btntkChuTro.Click += new System.EventHandler(this.btntkChuTro_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.LightCyan;
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOut.Location = new System.Drawing.Point(3, 388);
            this.btnOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(208, 74);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btntkPhong
            // 
            this.btntkPhong.BackColor = System.Drawing.Color.LightCyan;
            this.btntkPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntkPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btntkPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntkPhong.Location = new System.Drawing.Point(3, 233);
            this.btntkPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntkPhong.Name = "btntkPhong";
            this.btntkPhong.Size = new System.Drawing.Size(208, 73);
            this.btntkPhong.TabIndex = 3;
            this.btntkPhong.Text = "Tìm phòng trọ";
            this.btntkPhong.UseVisualStyleBackColor = false;
            this.btntkPhong.Click += new System.EventHandler(this.btntkPhong_Click);
            // 
            // btntkSV
            // 
            this.btntkSV.BackColor = System.Drawing.Color.LightCyan;
            this.btntkSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntkSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btntkSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntkSV.Location = new System.Drawing.Point(3, 310);
            this.btntkSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntkSV.Name = "btntkSV";
            this.btntkSV.Size = new System.Drawing.Size(208, 74);
            this.btntkSV.TabIndex = 4;
            this.btntkSV.Text = "Tìm sinh viên";
            this.btntkSV.UseVisualStyleBackColor = false;
            this.btntkSV.Click += new System.EventHandler(this.btntkSV_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmQly";
            this.Text = "Quản Lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwChuTro;
        private System.Windows.Forms.ListView lvwPhongTro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwSinhvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tVadmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button ptbMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnQlyChuTro;
        private System.Windows.Forms.Button btntkChuTro;
        private System.Windows.Forms.Button btntkPhong;
        private System.Windows.Forms.Button btntkSV;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.ImageList ImageTree;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lb;
    }
}

