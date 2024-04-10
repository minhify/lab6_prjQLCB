namespace lab6_prjQLCB
{
    partial class frmQLCB
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTenCB = new System.Windows.Forms.TextBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbNameCB = new System.Windows.Forms.Label();
            this.lbMSCB = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.tbMSCB = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbGioGiang = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.tbGioGiang = new System.Windows.Forms.TextBox();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 306);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(196, 306);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 38);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 306);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 38);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbTenCB
            // 
            this.tbTenCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTenCB.Location = new System.Drawing.Point(170, 116);
            this.tbTenCB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbTenCB.Name = "tbTenCB";
            this.tbTenCB.Size = new System.Drawing.Size(279, 27);
            this.tbTenCB.TabIndex = 35;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(29, 165);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(70, 20);
            this.lbChucVu.TabIndex = 33;
            this.lbChucVu.Text = "Chúc vụ";
            // 
            // lbNameCB
            // 
            this.lbNameCB.AutoSize = true;
            this.lbNameCB.Location = new System.Drawing.Point(31, 123);
            this.lbNameCB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNameCB.Name = "lbNameCB";
            this.lbNameCB.Size = new System.Drawing.Size(88, 20);
            this.lbNameCB.TabIndex = 32;
            this.lbNameCB.Text = "Họ tên CB";
            // 
            // lbMSCB
            // 
            this.lbMSCB.AutoSize = true;
            this.lbMSCB.Location = new System.Drawing.Point(31, 75);
            this.lbMSCB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMSCB.Name = "lbMSCB";
            this.lbMSCB.Size = new System.Drawing.Size(58, 20);
            this.lbMSCB.TabIndex = 31;
            this.lbMSCB.Text = "MSCB";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(169, 162);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(280, 28);
            this.cbbChucVu.TabIndex = 28;
            this.cbbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbbChucVu_SelectedIndexChanged);
            // 
            // tbMSCB
            // 
            this.tbMSCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMSCB.Location = new System.Drawing.Point(171, 75);
            this.tbMSCB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbMSCB.Name = "tbMSCB";
            this.tbMSCB.Size = new System.Drawing.Size(115, 27);
            this.tbMSCB.TabIndex = 27;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(96, 19);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(296, 32);
            this.lbTitle.TabIndex = 26;
            this.lbTitle.Text = "THÔNG TIN CÁN BỘ";
            // 
            // lbGioGiang
            // 
            this.lbGioGiang.AutoSize = true;
            this.lbGioGiang.Location = new System.Drawing.Point(29, 212);
            this.lbGioGiang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbGioGiang.Name = "lbGioGiang";
            this.lbGioGiang.Size = new System.Drawing.Size(101, 20);
            this.lbGioGiang.TabIndex = 34;
            this.lbGioGiang.Text = "Số giờ giảng";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(29, 256);
            this.lbDonGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(66, 20);
            this.lbDonGia.TabIndex = 39;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // tbGioGiang
            // 
            this.tbGioGiang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGioGiang.Location = new System.Drawing.Point(169, 210);
            this.tbGioGiang.Margin = new System.Windows.Forms.Padding(5);
            this.tbGioGiang.Name = "tbGioGiang";
            this.tbGioGiang.Size = new System.Drawing.Size(183, 27);
            this.tbGioGiang.TabIndex = 40;
            this.tbGioGiang.TextChanged += new System.EventHandler(this.tbGioGiang_TextChanged);
            // 
            // tbDonGia
            // 
            this.tbDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDonGia.Location = new System.Drawing.Point(169, 254);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(5);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(183, 27);
            this.tbDonGia.TabIndex = 41;
            this.tbDonGia.TextChanged += new System.EventHandler(this.tbDonGia_TextChanged);
            // 
            // frmQLCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 358);
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.tbGioGiang);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTenCB);
            this.Controls.Add(this.lbGioGiang);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbNameCB);
            this.Controls.Add(this.lbMSCB);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.tbMSCB);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLCB";
            this.Text = "QLCB";
            this.Load += new System.EventHandler(this.frmQLCB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbTenCB;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbNameCB;
        private System.Windows.Forms.Label lbMSCB;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.TextBox tbMSCB;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbGioGiang;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox tbGioGiang;
        private System.Windows.Forms.TextBox tbDonGia;
    }
}

