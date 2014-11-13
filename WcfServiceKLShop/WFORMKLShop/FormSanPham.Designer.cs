namespace WFORMKLShop
{
    partial class FormSanPham
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dvSanpham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pichinhanh = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtha = new System.Windows.Forms.TextBox();
            this.btnchon = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmota = new System.Windows.Forms.RichTextBox();
            this.cboDanhmuc = new System.Windows.Forms.ComboBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKichthuoc = new System.Windows.Forms.TextBox();
            this.txtMausac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(109, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Quản lý sản phẩm";
            // 
            // btnThoat
            // 
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(710, 596);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dvSanpham
            // 
            this.dvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvSanpham.Location = new System.Drawing.Point(433, 59);
            this.dvSanpham.Margin = new System.Windows.Forms.Padding(4);
            this.dvSanpham.Name = "dvSanpham";
            this.dvSanpham.ReadOnly = true;
            this.dvSanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSanpham.Size = new System.Drawing.Size(565, 496);
            this.dvSanpham.TabIndex = 54;
            this.dvSanpham.SelectionChanged += new System.EventHandler(this.dvSanpham_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSP";
            this.Column1.HeaderText = "Tên Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 105;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HinhAnh";
            this.Column5.HeaderText = "Hình";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gia";
            this.Column2.HeaderText = "Giá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MoTa";
            this.Column3.HeaderText = "Mô Tả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenDM";
            this.Column4.HeaderText = "Loại Danh Mục";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pichinhanh
            // 
            this.pichinhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pichinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pichinhanh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pichinhanh.Location = new System.Drawing.Point(143, 147);
            this.pichinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.pichinhanh.Name = "pichinhanh";
            this.pichinhanh.Size = new System.Drawing.Size(192, 123);
            this.pichinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinhanh.TabIndex = 53;
            this.pichinhanh.TabStop = false;
            // 
            // txtha
            // 
            this.txtha.Enabled = false;
            this.txtha.Location = new System.Drawing.Point(145, 101);
            this.txtha.Margin = new System.Windows.Forms.Padding(4);
            this.txtha.Name = "txtha";
            this.txtha.Size = new System.Drawing.Size(190, 20);
            this.txtha.TabIndex = 52;
            // 
            // btnchon
            // 
            this.btnchon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnchon.Location = new System.Drawing.Point(354, 98);
            this.btnchon.Margin = new System.Windows.Forms.Padding(4);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(49, 28);
            this.btnchon.TabIndex = 51;
            this.btnchon.Text = "...";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btntaomoi.Location = new System.Drawing.Point(4, 595);
            this.btntaomoi.Margin = new System.Windows.Forms.Padding(4);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(100, 28);
            this.btntaomoi.TabIndex = 50;
            this.btntaomoi.Text = "Tạo Mới";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsua.Location = new System.Drawing.Point(235, 596);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 48;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnthem.Location = new System.Drawing.Point(112, 596);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 47;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(140, 416);
            this.txtmota.Margin = new System.Windows.Forms.Padding(4);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(239, 95);
            this.txtmota.TabIndex = 46;
            this.txtmota.Text = "";
            // 
            // cboDanhmuc
            // 
            this.cboDanhmuc.FormattingEnabled = true;
            this.cboDanhmuc.Location = new System.Drawing.Point(139, 531);
            this.cboDanhmuc.Margin = new System.Windows.Forms.Padding(4);
            this.cboDanhmuc.Name = "cboDanhmuc";
            this.cboDanhmuc.Size = new System.Drawing.Size(196, 21);
            this.cboDanhmuc.TabIndex = 45;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(142, 371);
            this.txtgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(193, 20);
            this.txtgia.TabIndex = 44;
            this.txtgia.TextChanged += new System.EventHandler(this.txtgia_TextChanged);
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(145, 59);
            this.txttensp.Margin = new System.Windows.Forms.Padding(4);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(190, 20);
            this.txttensp.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 531);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Loại Danh Mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mô Tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(22, 371);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Giá Cả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Hình Ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(22, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Kích Thước";
            // 
            // txtKichthuoc
            // 
            this.txtKichthuoc.Location = new System.Drawing.Point(145, 287);
            this.txtKichthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtKichthuoc.Name = "txtKichthuoc";
            this.txtKichthuoc.Size = new System.Drawing.Size(190, 20);
            this.txtKichthuoc.TabIndex = 59;
            // 
            // txtMausac
            // 
            this.txtMausac.Location = new System.Drawing.Point(145, 324);
            this.txtMausac.Margin = new System.Windows.Forms.Padding(4);
            this.txtMausac.Name = "txtMausac";
            this.txtMausac.Size = new System.Drawing.Size(190, 20);
            this.txtMausac.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(22, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Màu Sắc";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(19, 204);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(4);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(76, 20);
            this.txtmasp.TabIndex = 62;
            this.txtmasp.Visible = false;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(19, 232);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(76, 20);
            this.txtsoluong.TabIndex = 63;
            this.txtsoluong.Visible = false;
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Location = new System.Drawing.Point(140, 561);
            this.cboTrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(196, 21);
            this.cboTrangthai.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(17, 561);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Trạng Thái";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 639);
            this.Controls.Add(this.cboTrangthai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.txtMausac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKichthuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dvSanpham);
            this.Controls.Add(this.pichinhanh);
            this.Controls.Add(this.txtha);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.cboDanhmuc);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dvSanpham;
        private System.Windows.Forms.PictureBox pichinhanh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtha;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.RichTextBox txtmota;
        private System.Windows.Forms.ComboBox cboDanhmuc;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKichthuoc;
        private System.Windows.Forms.TextBox txtMausac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.Label label9;

    }
}