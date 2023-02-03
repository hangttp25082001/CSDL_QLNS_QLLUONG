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
    public partial class FrmChucVu : Form
    {
    
        public FrmChucVu()
        {
            InitializeComponent();
        }

         KetNoi1 kn = new KetNoi1();

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            
                this.Close();

        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtmaCV.Text = "";
            txttenCV.Text = "";
            phu_cap.Value = 0;

            txtmaCV.Focus();

        }
        private void Hienthi_DL()
        {
            txtmaCV.DataBindings.Clear();
            txtmaCV.DataBindings.Add("Text", dataGrid_CV.DataSource, "ma_CV");

            txttenCV.DataBindings.Clear();
            txttenCV.DataBindings.Add("Text", dataGrid_CV.DataSource, "ten_CV");

            phu_cap.DataBindings.Clear();
            phu_cap.DataBindings.Add("Values ", dataGrid_CV.DataSource, "phu_cap");
        }
        
            private void Bang_Chucvu()
        {
            DataTable dta = new DataTable();
            kn.Lay_DulieuBang("Select ma_CV, ten_CV, phu_cap from CHUCVU order by ma_CV ");
            dataGrid_CV.DataSource = dta;

           
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKra = "Select ma_CV from CHUCVU where ma_CV='" + txtmaCV.Text +"'";
            SqlCommand cmd = new SqlCommand(strKra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();

            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã chức vụ này đã tồn tại vui lòng nhập mã khác", "Thông báo");
                txtmaCV.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu;
                sql_luu = "insert into CHUCVU values ('" + txtmaCV.Text + "','" + txttenCV.Text + "'," + phu_cap.Value + ")";

                kn.ThucThi(sql_luu);
                Bang_Chucvu();
            }
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
           Bang_Chucvu();
            //Hienthi_DL();
        }

        private void DataGrid_Chucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // Bang_Chucvu();
            Hienthi_DL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa;
                sql_xoa = "Delete CHUCVU where ma_CV ='" + txtmaCV.Text + "'";

                kn.ThucThi(sql_xoa);
                Bang_Chucvu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
                string sql_sua;

                sql_sua = " update CHUCVU set ten_CV ='" + txttenCV.Text + "',' " + "phu_cap ='" + phu_cap.Value + "'" + "where ma_CV ='" + txtmaCV.Text + "'";
                kn.ThucThi(sql_sua);
                Bang_Chucvu();
            

        }


    }
}
