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

namespace ThanhToan
{
    public partial class frmThanhToan : Form
    {
        int SoHD;

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("Select * from Phong", clsDatabase.con);
                SqlDataReader dr = com.ExecuteReader();


                DataTable dt = new DataTable();
                DataColumn dc_MaPhong = new DataColumn("MaPhong");
                DataColumn dc_TenPhong = new DataColumn("TenPhong");
                dt.Columns.Add(dc_MaPhong);
                dt.Columns.Add(dc_TenPhong);

                while (dr.Read())
                {
                    dt.Rows.Add(Convert.ToInt32(dr[0]), dr[1].ToString());
                }

                cboSoPhong.DataSource = dt;
                cboSoPhong.ValueMember = "MaPhong";
                cboSoPhong.DisplayMember = "TenPhong";

                clsDatabase.CloseConnection();

                btnLuu.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Thông Báo", "Không Có Phòng này", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("Select MAX(SoHD) from KhachHang", clsDatabase.con);
                SoHD = Convert.ToInt32(com.ExecuteScalar());
                clsDatabase.CloseConnection();
            }
            catch
            {
                SoHD = 0;
            }

            SoHD++;
            ResetFields(true);
            txtSoHD.Text = SoHD.ToString();
        }

        void ResetFields(bool status)
        {
            txtSoHD.Clear();
            txtHoTen.Clear();
            txtSoCMND.Clear();
            txtSoTienTT.Clear();
            cboSoPhong.SelectedIndex = -1;
            dtpNgayTT.Value = DateTime.Now;
            btnLuu.Enabled = status;
            btnThem.Enabled = !status;
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert into KhachHang values(@SoHD, @HoTenKH, @SoCMND, @SoTienTT, @NgayTT, @SoPhong)";
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@SoHD", SqlDbType.Int);
                p1.Value = SoHD;
                SqlParameter p2 = new SqlParameter("@HoTenKH", SqlDbType.NVarChar);
                p2.Value = txtHoTen.Text;
                SqlParameter p3 = new SqlParameter("@SoCMND", SqlDbType.Int);
                p3.Value = txtSoCMND.Text;
                SqlParameter p4 = new SqlParameter("@SoTienTT", SqlDbType.Money);
                p4.Value = txtSoTienTT.Text;
                SqlParameter p5 = new SqlParameter("@NgayTT", SqlDbType.DateTime);
                p5.Value = dtpNgayTT.Value;
                SqlParameter p6 = new SqlParameter("@SoPhong", SqlDbType.Int);
                p6.Value = cboSoPhong.SelectedValue;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.Parameters.Add(p6);
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
            con = new SqlConnection("Data Source=DESKTOP-E30J54Q\\SQLEXPRESS;Initial Catalog=ThanhToan;Integrated Security=True");
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