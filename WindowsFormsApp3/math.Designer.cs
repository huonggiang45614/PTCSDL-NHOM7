namespace WindowsFormsApp3
{
    partial class math
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.dtgMathang = new System.Windows.Forms.DataGridView();
            this.IDMATHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMATHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLOAIHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNHACUNGCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMathang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtgia);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbbloai);
            this.panel1.Controls.Add(this.cbbncc);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 202);
            this.panel1.TabIndex = 0;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(684, 128);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(110, 22);
            this.txtgia.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(591, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số Lượng ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Đơn giá ";
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(430, 126);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(121, 24);
            this.cbbloai.TabIndex = 14;
            // 
            // cbbncc
            // 
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Location = new System.Drawing.Point(143, 131);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(121, 24);
            this.cbbncc.TabIndex = 12;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(418, 23);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 22);
            this.txtten.TabIndex = 9;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(684, 20);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(110, 22);
            this.txtsl.TabIndex = 7;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(133, 26);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(131, 22);
            this.txtma.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên hàng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà cung cấp ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng ";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(200, 247);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(142, 37);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(449, 247);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(134, 37);
            this.btsua.TabIndex = 8;
            this.btsua.Text = "Sửa ";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(693, 247);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(111, 37);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // dtgMathang
            // 
            this.dtgMathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMathang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMATHANG,
            this.TENMATHANG,
            this.IDLOAIHANG,
            this.IDNHACUNGCAP,
            this.GIA,
            this.SOLUONGTON});
            this.dtgMathang.Location = new System.Drawing.Point(12, 347);
            this.dtgMathang.Name = "dtgMathang";
            this.dtgMathang.RowHeadersWidth = 51;
            this.dtgMathang.RowTemplate.Height = 24;
            this.dtgMathang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMathang.Size = new System.Drawing.Size(855, 169);
            this.dtgMathang.TabIndex = 10;
            this.dtgMathang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMathang_RowEnter);
            // 
            // IDMATHANG
            // 
            this.IDMATHANG.DataPropertyName = "IDMATHANG";
            this.IDMATHANG.HeaderText = "Mã hàng";
            this.IDMATHANG.MinimumWidth = 6;
            this.IDMATHANG.Name = "IDMATHANG";
            this.IDMATHANG.Width = 125;
            // 
            // TENMATHANG
            // 
            this.TENMATHANG.DataPropertyName = "TENMATHANG";
            this.TENMATHANG.HeaderText = "Tên hàng";
            this.TENMATHANG.MinimumWidth = 6;
            this.TENMATHANG.Name = "TENMATHANG";
            this.TENMATHANG.Width = 125;
            // 
            // IDLOAIHANG
            // 
            this.IDLOAIHANG.DataPropertyName = "IDLOAIHANG";
            this.IDLOAIHANG.HeaderText = "Loại hàng";
            this.IDLOAIHANG.MinimumWidth = 6;
            this.IDLOAIHANG.Name = "IDLOAIHANG";
            this.IDLOAIHANG.Width = 125;
            // 
            // IDNHACUNGCAP
            // 
            this.IDNHACUNGCAP.DataPropertyName = "IDNHACUNGCAP";
            this.IDNHACUNGCAP.HeaderText = "Nhà cung cấp";
            this.IDNHACUNGCAP.MinimumWidth = 6;
            this.IDNHACUNGCAP.Name = "IDNHACUNGCAP";
            this.IDNHACUNGCAP.Width = 125;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Đơn giá";
            this.GIA.MinimumWidth = 6;
            this.GIA.Name = "GIA";
            this.GIA.Width = 125;
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.DataPropertyName = "SOLUONGTON";
            this.SOLUONGTON.HeaderText = "Số lượng";
            this.SOLUONGTON.MinimumWidth = 6;
            this.SOLUONGTON.Name = "SOLUONGTON";
            this.SOLUONGTON.Width = 125;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(525, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Tìm kiếm ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhập tên hàng cần tìm ";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(258, 304);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(226, 22);
            this.txttimkiem.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 544);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtgMathang);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.panel1);
            this.Name = "math";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMathang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.DataGridView dtgMathang;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMATHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMATHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLOAIHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNHACUNGCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTON;
    }
}