
namespace CSDL_QLNS_QLLUONG
{
    partial class FrmPhongBan
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
            this.DataGrid_PhongBan = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txttenPB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.txtmaPB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_PhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_PhongBan
            // 
            this.DataGrid_PhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_PhongBan.Location = new System.Drawing.Point(45, 308);
            this.DataGrid_PhongBan.Name = "DataGrid_PhongBan";
            this.DataGrid_PhongBan.RowHeadersWidth = 51;
            this.DataGrid_PhongBan.RowTemplate.Height = 24;
            this.DataGrid_PhongBan.Size = new System.Drawing.Size(581, 214);
            this.DataGrid_PhongBan.TabIndex = 26;
            this.DataGrid_PhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_PhongBan_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(661, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(163, 38);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(661, 404);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(163, 38);
            this.btnthoat.TabIndex = 23;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(661, 163);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(163, 38);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txttenPB
            // 
            this.txttenPB.Location = new System.Drawing.Point(199, 198);
            this.txttenPB.Name = "txttenPB";
            this.txttenPB.Size = new System.Drawing.Size(268, 22);
            this.txttenPB.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên phòng ban";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(661, 228);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(163, 38);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Điện thoại";
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaomoi.Location = new System.Drawing.Point(661, 90);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(163, 38);
            this.btnTaomoi.TabIndex = 17;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // txtmaPB
            // 
            this.txtmaPB.Location = new System.Drawing.Point(199, 125);
            this.txtmaPB.Name = "txtmaPB";
            this.txtmaPB.Size = new System.Drawing.Size(268, 22);
            this.txtmaPB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "THÔNG TIN PHÒNG BAN";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(199, 262);
            this.txtDienthoai.MaxLength = 10;
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(268, 22);
            this.txtDienthoai.TabIndex = 27;
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 587);
            this.ControlBox = false;
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.DataGrid_PhongBan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txttenPB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.txtmaPB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_PhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_PhongBan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txttenPB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.TextBox txtmaPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDienthoai;
    }
}