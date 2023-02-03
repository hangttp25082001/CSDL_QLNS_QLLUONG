using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDL_QLNS_QLLUONG
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        KetNoi1 kn = new KetNoi1();
        private void Hienthi_DL()
        {
            txtmaNV.DataBindings.Clear();
            txtmaNV.DataBindings.Add("Text", DataGrid_Nhanvien.DataSource, "ma_NV");

            txttenNV.DataBindings.Clear();
            txttenNV.DataBindings.Add("Text", DataGrid_Nhanvien.DataSource, "ten_NV");

            hesoluong.DataBindings.Clear();
            hesoluong.DataBindings.Add("Value", DataGrid_Nhanvien.DataSource, "he_so_luong");

            cboChucvu.DataBindings.Clear();
            cboChucvu.DataBindings.Add("Text", DataGrid_Nhanvien.DataSource, "ma_CV");
            cboPhongban.DataBindings.Clear();
            cboPhongban.DataBindings.Add("Text", DataGrid_Nhanvien.DataSource, "ma_PB");

        }
        private void Bang_Nhanvien()
        {
            DataTable dta = new DataTable();
            kn.Lay_DulieuBang("Select* from NHANVIEN order by ma_NV ");
            DataGrid_Nhanvien.DataSource = dta;
            Hienthi_DL();
        }
        private void Bang_Chucvu()
        {
            DataTable dta = new DataTable();
            kn.Lay_DulieuBang("Select * from CHUCVU order by ma_CV ");
            cboChucvu.DataSource = dta;
            cboChucvu.DisplayMember = "ma_CV";
        }
        private void Bang_Phongban()
        {
            DataTable dta = new DataTable();
            kn.Lay_DulieuBang("Select * from PHONGBAN order by ma_PB ");
            cboPhongban.DataSource = dta;
            cboPhongban.DisplayMember = "ma_PB";
        }
        private void btnTaomoi_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKra = "Select ma_NV from NHANVIEN where ma_CV='" + txtmaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();

            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại vui lòng nhập mã khác", "Thông báo");
                txtmaNV.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu;
                sql_luu = "insert into NHANVIEN values ('" + txtmaNV.Text + "','" + txttenNV.Text + "'," + hesoluong.Value +"','"+cboChucvu.Text +"','"+cboPhongban.Text + ")";

                kn.ThucThi(sql_luu);
                Bang_Nhanvien();
            }
        }
    }
}
