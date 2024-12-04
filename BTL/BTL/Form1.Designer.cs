namespace BTL
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btthem = new System.Windows.Forms.Button();
            this.tbidnhacungcap = new System.Windows.Forms.TextBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.btsua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtennhacungcap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.tbidnhacungcap);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbdiachi);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbtennhacungcap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbsdt);
            this.groupBox1.Location = new System.Drawing.Point(32, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(90, 149);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(108, 40);
            this.btthem.TabIndex = 16;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbidnhacungcap
            // 
            this.tbidnhacungcap.Enabled = false;
            this.tbidnhacungcap.Location = new System.Drawing.Point(184, 34);
            this.tbidnhacungcap.Name = "tbidnhacungcap";
            this.tbidnhacungcap.Size = new System.Drawing.Size(194, 26);
            this.tbidnhacungcap.TabIndex = 13;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(508, 149);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(108, 40);
            this.btxoa.TabIndex = 14;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại:";
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(535, 34);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(162, 26);
            this.tbdiachi.TabIndex = 12;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(303, 149);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(108, 40);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            // 
            // tbtennhacungcap
            // 
            this.tbtennhacungcap.Location = new System.Drawing.Point(184, 94);
            this.tbtennhacungcap.Name = "tbtennhacungcap";
            this.tbtennhacungcap.Size = new System.Drawing.Size(194, 26);
            this.tbtennhacungcap.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID nhà cung cấp:";
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(535, 94);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(162, 26);
            this.tbsdt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông tin tìm kiếm:";
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(206, 278);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(523, 26);
            this.tbtimkiem.TabIndex = 11;
            this.tbtimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(32, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 263);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(723, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên nhà cung cấp:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox tbidnhacungcap;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbtennhacungcap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

