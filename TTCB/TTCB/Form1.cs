using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCB
{
    public partial class frmTTCB : Form
    {
        int CodeNo;

        public frmTTCB()
        {
            InitializeComponent();
        }

        private void frmTTCB_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("Select * from ChucVu", clsDatabase.con);
                SqlDataReader dr = com.ExecuteReader();


                DataTable dt = new DataTable();
                DataColumn dc_MaCV = new DataColumn("MaCV");
                DataColumn dc_TenCV = new DataColumn("TenCV");
                dt.Columns.Add(dc_MaCV);
                dt.Columns.Add(dc_TenCV);

                while (dr.Read())
                {
                    dt.Rows.Add(Convert.ToInt32(dr[0]), dr[1].ToString());
                }

                cboChucVu.DataSource = dt;
                cboChucVu.ValueMember = "MaCV";
                cboChucVu.DisplayMember = "TenCV";

                clsDatabase.CloseConnection();

                btnLuu.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Thông Báo", "Không Có Chức Vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("Select MAX(MaCB) from CanBo", clsDatabase.con);
                CodeNo = Convert.ToInt32(com.ExecuteScalar());
                clsDatabase.CloseConnection();
            }
            catch
            {
                CodeNo = 0;
            }

            CodeNo++;
            ResetFields(true);
            txtMSCB.Text = CodeNo.ToString();
        }

        void ResetFields(bool status)
        {
            txtMSCB.Clear();
            txtHoTenCB.Clear();
            cboChucVu.SelectedIndex = 0;
            txtSoGioGiang.Clear();
            txtDonGia.Clear();
            btnLuu.Enabled = status;
            btnThem.Enabled = !status;
            txtHoTenCB.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert into CanBo values(@MaCB, @TenCB, @ChucVuCB, @SoGioGiang, @DonGia)";
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@MaCB", SqlDbType.Int);
                p1.Value = CodeNo;
                SqlParameter p2 = new SqlParameter("@TenCB", SqlDbType.NVarChar);
                p2.Value = txtHoTenCB.Text;
                SqlParameter p3 = new SqlParameter("@ChucVuCB", SqlDbType.Int);
                p3.Value = cboChucVu.SelectedValue;
                SqlParameter p4 = new SqlParameter("@SoGioGiang", SqlDbType.Int);
                p4.Value = txtSoGioGiang.Text;
                SqlParameter p5 = new SqlParameter("@DonGia", SqlDbType.Money);
                p5.Value = txtDonGia.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.ExecuteNonQuery();

                MessageBox.Show("Insert Successfully!!!");
                clsDatabase.CloseConnection();
                ResetFields(false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}

class clsDatabase
{
    public static SqlConnection con;

    public static bool OpenConnection()
    {
        try
        {
            //login with window authentication option, so there are no user name and password
            con = new SqlConnection("Data Source=DESKTOP-E30J54Q\\SQLEXPRESS;Initial Catalog=QLCB;Integrated Security=True");
            con.Open();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public static bool CloseConnection()
    {
        try
        {
            con.Close();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

}