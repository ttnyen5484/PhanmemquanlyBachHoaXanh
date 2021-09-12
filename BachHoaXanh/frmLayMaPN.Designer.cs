namespace BachHoaXanh
{
    partial class frmLayMaPN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCapNhatGia = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txthsd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnsx = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnCapNhatGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txthsd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnsx);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(757, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin đổi trả";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 84);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 24);
            this.comboBox1.TabIndex = 66;
            // 
            // btnCapNhatGia
            // 
            this.btnCapNhatGia.BackColor = System.Drawing.Color.Gold;
            this.btnCapNhatGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhatGia.Location = new System.Drawing.Point(48, 130);
            this.btnCapNhatGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatGia.Name = "btnCapNhatGia";
            this.btnCapNhatGia.Size = new System.Drawing.Size(661, 64);
            this.btnCapNhatGia.TabIndex = 65;
            this.btnCapNhatGia.Text = "LƯU";
            this.btnCapNhatGia.UseVisualStyleBackColor = false;
            this.btnCapNhatGia.Click += new System.EventHandler(this.btnCapNhatGia_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SeaGreen;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(48, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 30);
            this.label8.TabIndex = 63;
            this.label8.Text = "TÊN SẢN PHẨM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthsd
            // 
            this.txthsd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txthsd.CustomFormat = "dd/MM/yyyy";
            this.txthsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthsd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthsd.Location = new System.Drawing.Point(536, 84);
            this.txthsd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthsd.Name = "txthsd";
            this.txthsd.Size = new System.Drawing.Size(172, 27);
            this.txthsd.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(536, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 30);
            this.label5.TabIndex = 62;
            this.label5.Text = "HẠN SỬ DỤNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(332, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 59;
            this.label3.Text = "NGÀY SẢN XUẤT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnsx
            // 
            this.txtnsx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtnsx.CustomFormat = "dd/MM/yyyy";
            this.txtnsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnsx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtnsx.Location = new System.Drawing.Point(332, 84);
            this.txtnsx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnsx.Name = "txtnsx";
            this.txtnsx.Size = new System.Drawing.Size(172, 27);
            this.txtnsx.TabIndex = 60;
            // 
            // frmLayMaPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 265);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLayMaPN";
            this.Text = "frmLayMaPN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLayMaPN_FormClosing);
            this.Load += new System.EventHandler(this.frmLayMaPN_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCapNhatGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txthsd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtnsx;
    }
}