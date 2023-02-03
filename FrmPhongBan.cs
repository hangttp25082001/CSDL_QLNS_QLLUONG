using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL_QLNS_QLLUONG
{
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        KetNoi1 kn = new KetNoi1();
        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtmaPB.Text = "";
            txttenPB.Text = "";
            txtDienthoai.Text = "";
            txtmaPB.Focus();
        }
        private void Bang_PhongBan()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from PHONGBAN");
            DataGrid_PhongBan.DataSource = dta;
        }

        private void Hienthi_DL()
        {
            txtmaPB.DataBindings.Clear();
            txtmaPB.DataBindings.Add("Text", DataGrid_PhongBan.DataSource, "ma_PB");
            txttenPB.DataBindings.Clear();
            txttenPB.DataBindings.Add("Text", DataGrid_PhongBan.DataSource, "ten_PB");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", DataGrid_PhongBan.DataSource, "dien_thoai");


        }

        private void DataGrid_PhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Hienthi_DL();
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            Bang_PhongBan();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_luu;
            sql_luu = "insert into PHONGBAN values ('" + txtmaPB.Text + "','" + txttenPB.Text + "','" + txtDienthoai.Text + "')";

            kn.ThucThi(sql_luu);
            Bang_PhongBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa;
            sql_xoa = "Delete PHONGBAN where ma_PB ='" + txtmaPB.Text + "'";
            kn.ThucThi(sql_xoa);
            Bang_PhongBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua;
            sql_sua = "update PHONGBAN set ten_PB ='" + txttenPB.Text + "'," + "dien_thoai='" + txtDienthoai.Text + "'"+"where ma_PB ='"+txtmaPB.Text +"'";
            kn.ThucThi(sql_sua);
            Bang_PhongBan();
        }
    }
}
