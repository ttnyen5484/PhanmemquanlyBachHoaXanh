namespace BachHoaXanh
{
    partial class frmDangNhapQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhapQL));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaql = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Quản Lí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtmaql
            // 
            this.txtmaql.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaql.Location = new System.Drawing.Point(185, 37);
            this.txtmaql.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaql.Name = "txtmaql";
            this.txtmaql.Size = new System.Drawing.Size(179, 27);
            this.txtmaql.TabIndex = 2;
            this.txtmaql.Text = "NV001";
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtmk.Location = new System.Drawing.Point(185, 86);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(179, 27);
            this.txtmk.TabIndex = 3;
            this.txtmk.Text = "Kha050620";
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.SeaGreen;
            this.btndangnhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Location = new System.Drawing.Point(74, 139);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(130, 28);
            this.btndangnhap.TabIndex = 4;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnhuy.ForeColor = System.Drawing.Color.White;
            this.btnhuy.Location = new System.Drawing.Point(234, 139);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(130, 28);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmDangNhapQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(431, 188);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtmaql);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhapQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập dành cho quản lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhapQL_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaql;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnhuy;
    }
}