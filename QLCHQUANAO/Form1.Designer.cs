namespace QLCHQUANAO
{
    partial class FrmQuanLyKhachHang
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
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.dtgMathang = new System.Windows.Forms.DataGridView();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colIDMATHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMATHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMathang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(89, 131);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(95, 45);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(260, 131);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(94, 45);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(419, 131);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(93, 45);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // dtgMathang
            // 
            this.dtgMathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMathang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDMATHANG,
            this.TENMATHANG});
            this.dtgMathang.Location = new System.Drawing.Point(61, 194);
            this.dtgMathang.Name = "dtgMathang";
            this.dtgMathang.ReadOnly = true;
            this.dtgMathang.RowHeadersWidth = 62;
            this.dtgMathang.RowTemplate.Height = 28;
            this.dtgMathang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMathang.Size = new System.Drawing.Size(681, 259);
            this.dtgMathang.TabIndex = 4;
            this.dtgMathang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMathang_RowEnter);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(129, 23);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(181, 26);
            this.txtma.TabIndex = 5;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(536, 162);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(171, 26);
            this.txttimkiem.TabIndex = 7;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(713, 145);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(118, 43);
            this.btntimkiem.TabIndex = 8;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhập tên hàng cần tìm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loại hàng: ";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(402, 20);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(181, 26);
            this.txtten.TabIndex = 15;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(773, 20);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(181, 26);
            this.txtsl.TabIndex = 17;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(773, 74);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(181, 26);
            this.txtgia.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Đơn giá:";
            // 
            // cbbncc
            // 
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Location = new System.Drawing.Point(129, 71);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(181, 28);
            this.cbbncc.TabIndex = 21;
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(402, 71);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(181, 28);
            this.cbbloai.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colIDMATHANG
            // 
            this.colIDMATHANG.DataPropertyName = "IDMATHANG";
            this.colIDMATHANG.HeaderText = "Mã Hàng";
            this.colIDMATHANG.MinimumWidth = 8;
            this.colIDMATHANG.Name = "colIDMATHANG";
            this.colIDMATHANG.ReadOnly = true;
            this.colIDMATHANG.Width = 150;
            // 
            // TENMATHANG
            // 
            this.TENMATHANG.DataPropertyName = "TENMATHANG";
            this.TENMATHANG.HeaderText = "Tên hàng";
            this.TENMATHANG.MinimumWidth = 8;
            this.TENMATHANG.Name = "TENMATHANG";
            this.TENMATHANG.ReadOnly = true;
            this.TENMATHANG.Width = 150;
            // 
            // FrmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.cbbloai);
            this.Controls.Add(this.cbbncc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.dtgMathang);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Name = "FrmQuanLyKhachHang";
            this.Text = "FrmQuanLyHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMathang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.DataGridView dtgMathang;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDMATHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMATHANG;
    }
}

