namespace WindowsFormsApp3
{
    partial class dangnhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 272);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageKey = "(none)";
            this.label3.Location = new System.Drawing.Point(212, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "ĐĂNG NHẬP ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtmatkhau);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(22, 136);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 84);
            this.panel3.TabIndex = 1;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.AcceptsReturn = true;
            this.txtmatkhau.BackColor = System.Drawing.Color.LightGray;
            this.txtmatkhau.Location = new System.Drawing.Point(194, 16);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(238, 29);
            this.txtmatkhau.TabIndex = 2;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmatkhau_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "MẬT KHẨU:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txttentaikhoan);
            this.panel2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(22, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 69);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN TÀI KHOẢN :";
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.BackColor = System.Drawing.Color.LightGray;
            this.txttentaikhoan.ForeColor = System.Drawing.Color.Black;
            this.txttentaikhoan.Location = new System.Drawing.Point(194, 19);
            this.txttentaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(235, 29);
            this.txttentaikhoan.TabIndex = 3;
            this.txttentaikhoan.UseWaitCursor = true;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btthoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthoat.ForeColor = System.Drawing.Color.OrangeRed;
            this.btthoat.Location = new System.Drawing.Point(341, 277);
            this.btthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(164, 55);
            this.btthoat.TabIndex = 4;
            this.btthoat.Text = "THOÁT";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btdangnhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btdangnhap.ForeColor = System.Drawing.Color.Coral;
            this.btdangnhap.Location = new System.Drawing.Point(33, 277);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(202, 55);
            this.btdangnhap.TabIndex = 3;
            this.btdangnhap.Text = "ĐĂNG NHẬP ";
            this.btdangnhap.UseVisualStyleBackColor = false;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 370);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐĂNG NHẬP ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

