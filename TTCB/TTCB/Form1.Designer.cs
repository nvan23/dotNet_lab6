namespace TTCB
{
    partial class frmTTCB
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblMSCB = new System.Windows.Forms.Label();
            this.lblHoTenCB = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblSoGioGiang = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtMSCB = new System.Windows.Forms.TextBox();
            this.txtHoTenCB = new System.Windows.Forms.TextBox();
            this.txtSoGioGiang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(114, 29);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(181, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "THÔNG TIN CÁN BỘ";
            // 
            // lblMSCB
            // 
            this.lblMSCB.AutoSize = true;
            this.lblMSCB.Location = new System.Drawing.Point(45, 89);
            this.lblMSCB.Name = "lblMSCB";
            this.lblMSCB.Size = new System.Drawing.Size(37, 13);
            this.lblMSCB.TabIndex = 1;
            this.lblMSCB.Text = "MSCB";
            // 
            // lblHoTenCB
            // 
            this.lblHoTenCB.AutoSize = true;
            this.lblHoTenCB.Location = new System.Drawing.Point(45, 122);
            this.lblHoTenCB.Name = "lblHoTenCB";
            this.lblHoTenCB.Size = new System.Drawing.Size(56, 13);
            this.lblHoTenCB.TabIndex = 2;
            this.lblHoTenCB.Text = "Họ tên CB";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(45, 161);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(47, 13);
            this.lblChucVu.TabIndex = 3;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblSoGioGiang
            // 
            this.lblSoGioGiang.AutoSize = true;
            this.lblSoGioGiang.Location = new System.Drawing.Point(45, 197);
            this.lblSoGioGiang.Name = "lblSoGioGiang";
            this.lblSoGioGiang.Size = new System.Drawing.Size(66, 13);
            this.lblSoGioGiang.TabIndex = 4;
            this.lblSoGioGiang.Text = "Số giờ giảng";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(45, 233);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtMSCB
            // 
            this.txtMSCB.Location = new System.Drawing.Point(131, 89);
            this.txtMSCB.Name = "txtMSCB";
            this.txtMSCB.ReadOnly = true;
            this.txtMSCB.Size = new System.Drawing.Size(200, 20);
            this.txtMSCB.TabIndex = 6;
            // 
            // txtHoTenCB
            // 
            this.txtHoTenCB.Location = new System.Drawing.Point(131, 122);
            this.txtHoTenCB.Name = "txtHoTenCB";
            this.txtHoTenCB.Size = new System.Drawing.Size(200, 20);
            this.txtHoTenCB.TabIndex = 7;
            // 
            // txtSoGioGiang
            // 
            this.txtSoGioGiang.Location = new System.Drawing.Point(131, 197);
            this.txtSoGioGiang.Name = "txtSoGioGiang";
            this.txtSoGioGiang.Size = new System.Drawing.Size(200, 20);
            this.txtSoGioGiang.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(131, 233);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(200, 20);
            this.txtDonGia.TabIndex = 9;
            // 
            // cboChucVu
            // 
            this.cboChucVu.DisplayMember = "MaCV";
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(131, 161);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(200, 21);
            this.cboChucVu.TabIndex = 10;
            this.cboChucVu.ValueMember = "MaCV";
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(131, 274);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(196, 274);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 23);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(274, 274);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(57, 23);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmTTCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 328);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoGioGiang);
            this.Controls.Add(this.txtHoTenCB);
            this.Controls.Add(this.txtMSCB);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoGioGiang);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblHoTenCB);
            this.Controls.Add(this.lblMSCB);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmTTCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Cán Bộ";
            this.Load += new System.EventHandler(this.frmTTCB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblMSCB;
        private System.Windows.Forms.Label lblHoTenCB;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblSoGioGiang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtMSCB;
        private System.Windows.Forms.TextBox txtHoTenCB;
        private System.Windows.Forms.TextBox txtSoGioGiang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}

