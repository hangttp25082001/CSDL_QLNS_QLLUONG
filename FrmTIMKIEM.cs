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
    public partial class FrmTIMKIEM : Form
    {
        KetNoi1 kn = new KetNoi1();

        public FrmTIMKIEM()
        {
            InitializeComponent();
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk = "select * from NHANVIEN where ma_NV like '" + textBox1.Text + "'";
            dta = kn.Lay_DulieuBang(sqltk);
            dataGrid_ketqua.DataSource = dta;
        }

       
    }
}
