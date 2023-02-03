
namespace CSDL_QLNS_QLLUONG
{
    partial class FrmTIMKIEM2
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
            this.dataGrid_ketqua = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.optma = new System.Windows.Forms.RadioButton();
            this.optmaCV = new System.Windows.Forms.RadioButton();
            this.optmaPB = new System.Windows.Forms.RadioButton();
            this.optten = new System.Windows.Forms.RadioButton();
            this.cbomaPB = new System.Windows.Forms.ComboBox();
            this.cbomaCV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ketqua)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_ketqua
            // 
            this.dataGrid_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ketqua.Location = new System.Drawing.Point(79, 256);
            this.dataGrid_ketqua.Name = "dataGrid_ketqua";
            this.dataGrid_ketqua.RowHeadersWidth = 51;
            this.dataGrid_ketqua.RowTemplate.Height = 24;
            this.dataGrid_ketqua.Size = new System.Drawing.Size(814, 288);
            this.dataGrid_ketqua.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(702, 147);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 31);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(702, 79);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(139, 31);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(210, 70);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(319, 22);
            this.txtma.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(210, 114);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(319, 22);
            this.txtten.TabIndex = 15;
            // 
            // optma
            // 
            this.optma.AutoSize = true;
            this.optma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optma.Location = new System.Drawing.Point(58, 79);
            this.optma.Name = "optma";
            this.optma.Size = new System.Drawing.Size(112, 29);
            this.optma.TabIndex = 18;
            this.optma.TabStop = true;
            this.optma.Text = "Nhập mã";
            this.optma.UseVisualStyleBackColor = true;
            this.optma.CheckedChanged += new System.EventHandler(this.optma_CheckedChanged);
            // 
            // optmaCV
            // 
            this.optmaCV.AutoSize = true;
            this.optmaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optmaCV.Location = new System.Drawing.Point(58, 191);
            this.optmaCV.Name = "optmaCV";
            this.optmaCV.Size = new System.Drawing.Size(146, 29);
            this.optmaCV.TabIndex = 19;
            this.optmaCV.TabStop = true;
            this.optmaCV.Text = "Nhập mã CV";
            this.optmaCV.UseVisualStyleBackColor = true;
            this.optmaCV.CheckedChanged += new System.EventHandler(this.optmaCV_CheckedChanged);
            // 
            // optmaPB
            // 
            this.optmaPB.AutoSize = true;
            this.optmaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optmaPB.Location = new System.Drawing.Point(58, 157);
            this.optmaPB.Name = "optmaPB";
            this.optmaPB.Size = new System.Drawing.Size(143, 29);
            this.optmaPB.TabIndex = 20;
            this.optmaPB.TabStop = true;
            this.optmaPB.Text = "Nhập mã PB";
            this.optmaPB.UseVisualStyleBackColor = true;
            this.optmaPB.CheckedChanged += new System.EventHandler(this.optmaPB_CheckedChanged);
            // 
            // optten
            // 
            this.optten.AutoSize = true;
            this.optten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optten.Location = new System.Drawing.Point(58, 114);
            this.optten.Name = "optten";
            this.optten.Size = new System.Drawing.Size(112, 29);
            this.optten.TabIndex = 21;
            this.optten.TabStop = true;
            this.optten.Text = "Nhập tên";
            this.optten.UseVisualStyleBackColor = true;
            this.optten.CheckedChanged += new System.EventHandler(this.optten_CheckedChanged);
            // 
            // cbomaPB
            // 
            this.cbomaPB.FormattingEnabled = true;
            this.cbomaPB.Location = new System.Drawing.Point(210, 157);
            this.cbomaPB.Name = "cbomaPB";
            this.cbomaPB.Size = new System.Drawing.Size(319, 24);
            this.cbomaPB.TabIndex = 22;
            // 
            // cbomaCV
            // 
            this.cbomaCV.FormattingEnabled = true;
            this.cbomaCV.Location = new System.Drawing.Point(210, 197);
            this.cbomaCV.Name = "cbomaCV";
            this.cbomaCV.Size = new System.Drawing.Size(319, 24);
            this.cbomaCV.TabIndex = 23;
            // 
            // FrmTIMKIEM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 534);
            this.Controls.Add(this.cbomaCV);
            this.Controls.Add(this.cbomaPB);
            this.Controls.Add(this.optten);
            this.Controls.Add(this.optmaPB);
            this.Controls.Add(this.optmaCV);
            this.Controls.Add(this.optma);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.dataGrid_ketqua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label1);
            this.Name = "FrmTIMKIEM2";
            this.Text = "FrmTIMKIEM2";
            this.Load += new System.EventHandler(this.FrmTIMKIEM2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ketqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_ketqua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.RadioButton optma;
        private System.Windows.Forms.RadioButton optmaCV;
        private System.Windows.Forms.RadioButton optmaPB;
        private System.Windows.Forms.RadioButton optten;
        private System.Windows.Forms.ComboBox cbomaPB;
        private System.Windows.Forms.ComboBox cbomaCV;
    }
}