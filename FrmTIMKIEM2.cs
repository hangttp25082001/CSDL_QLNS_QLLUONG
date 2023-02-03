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
    public partial class FrmTIMKIEM2 : Form
    {
        KetNoi1 kn = new KetNoi1();
        public FrmTIMKIEM2()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTIMKIEM2_Load(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if(optma.Checked==true)
            {
                sqltk = "Select * from NHANVIEN where ma_NV like '" + txtma.Text + "'";
                dta = kn.Lay_DulieuBang(sqltk);

            }
            if (optten.Checked == true)
            {
                sqltk = "Select * from NHANVIEN where ten_NV like '" + txtten.Text + "%'";
                dta = kn.Lay_DulieuBang(sqltk);

            }
            if (optmaPB.Checked == true)
            {
                sqltk = "Select * from NHANVIEN where ma_PB like '" + cbomaPB.Text + "'";
                dta = kn.Lay_DulieuBang(sqltk);

            }
            if (optmaCV.Checked == true)
            {
                sqltk = "Select * from NHANVIEN where ma_CV like '" + cbomaCV.Text + "'";
                dta = kn.Lay_DulieuBang(sqltk);

            }
            dataGrid_ketqua.DataSource = dta;

        }

        private void optma_CheckedChanged(object sender, EventArgs e)
        {
            txtma.Focus();
            txtma.Enabled = true;
            txtten.Clear();
            cbomaCV.Enabled = false;
            cbomaPB.Enabled = false;

        }

        private void optten_CheckedChanged(object sender, EventArgs e)
        {
            txtten.Focus();
            txtten.Enabled = true;
            txtma.Clear();
            cbomaCV.Enabled = false;
            cbomaPB.Enabled = false;
        }

        private void optmaPB_CheckedChanged(object sender, EventArgs e)
        {
            txtma.Focus();
            txtma.Enabled = true;
            txtten.Clear();
            cbomaCV.Enabled = false;
            cbomaPB.Enabled = false;
        }

        private void optmaCV_CheckedChanged(object sender, EventArgs e)
        {
            cbomaCV.Focus();
            cbomaCV.Enabled = true;
            
           txtten.Enabled = false;
            txtma.Enabled = false;
        }
    }
}
