namespace WFORMKLShop
{
    partial class FormDanhMucSP
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(76, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Quản lý Danh Mục";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(155, 136);
            this.txtMaDM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(190, 20);
            this.txtMaDM.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mã Danh Mục";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(155, 173);
            this.txtTenDM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(190, 20);
            this.txtTenDM.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tên Danh Mục";
            // 
            // dvDanhMuc
            // 
            this.dvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5});
            this.dvDanhMuc.Location = new System.Drawing.Point(389, 78);
            this.dvDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.dvDanhMuc.Name = "dvDanhMuc";
            this.dvDanhMuc.Size = new System.Drawing.Size(269, 284);
            this.dvDanhMuc.TabIndex = 63;
            this.dvDanhMuc.SelectionChanged += new System.EventHandler(this.dvDanhMuc_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDM";
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenDM";
            this.Column5.HeaderText = "Tên Danh Mục";
            this.Column5.Name = "Column5";
            // 
            // btntaomoi
            // 
            this.btntaomoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btntaomoi.Location = new System.Drawing.Point(30, 257);
            this.btntaomoi.Margin = new System.Windows.Forms.Padding(4);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(100, 28);
            this.btntaomoi.TabIndex = 66;
            this.btntaomoi.Text = "Tạo Mới";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsua.Location = new System.Drawing.Point(261, 258);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 65;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnthem.Location = new System.Drawing.Point(138, 258);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 64;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(541, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 67;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(261, 294);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 68;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormDanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 434);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dvDanhMuc);
            this.Controls.Add(this.txtTenDM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FormDanhMucSP";
            this.Text = "FormDanhMucSP";
            this.Load += new System.EventHandler(this.FormDanhMucSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoa;
    }
}