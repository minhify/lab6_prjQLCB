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

namespace lab6_prjQLCB
{
    public partial class frmQLCB : Form
    {
        int maCB;
        int chucVu;
        int soGioGiang;
        decimal donGia;

        //List<ChucVuModel.ChucVu> listChucVu;
        private ChucVuController controller = new ChucVuController();

        public frmQLCB()
        {
            InitializeComponent();
        }

        void resetFields(bool status)
        {
            tbMSCB.Clear();
            tbTenCB.Clear();
            tbGioGiang.Clear();
            tbDonGia.Clear();
            cbbChucVu.SelectedIndex = -1;
            btnAdd.Enabled = !status;
            btnSave.Enabled = status;
        }

        private void frmQLCB_Load(object sender, EventArgs e)
        {
            //resetFields(true);
            List<ChucVuModel.ChucVu> listChucVu = controller.GetChucVu();
            cbbChucVu.DataSource = listChucVu;
            cbbChucVu.DisplayMember = "_tenCV";
            cbbChucVu.ValueMember = "_maCV";
            cbbChucVu.SelectedIndex = 0;
            btnSave.Enabled = false;
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedMaCV = Convert.ToInt32(cbbChucVu.Text);
            if (cbbChucVu.SelectedIndex == -1) return;
            ChucVuModel.ChucVu selectedChucVu = (ChucVuModel.ChucVu)cbbChucVu.SelectedItem;
            chucVu = selectedChucVu._maCV;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

                private void tbGioGiang_TextChanged(object sender, EventArgs e)
                {
                    //soGioGiang = tbGioGiang.Text;
                }

                private void tbDonGia_TextChanged(object sender, EventArgs e)
                {
                    //donGia = tbDonGia.Text;
                }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Database.OpenConnection();
                SqlCommand cmd =  new SqlCommand("SELECT max(MaCB) from CanBo", Database.con);
                maCB = Convert.ToInt32(cmd.ExecuteScalar());
                Database.CloseConnection();
            }
            catch(Exception)
            {
                maCB = 0;
            }
            maCB++;
            resetFields(true);
            tbMSCB.Text = maCB.ToString();
            }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Database.OpenConnection();
                string cmdInsert = "INSERT INTO CanBo VALUES (@TenCB, @ChucVuCB, @SoGioGiang, @DonGia);";
                SqlCommand cmd = new SqlCommand(cmdInsert, Database.con);

                //SqlParameter p1 = new SqlParameter("@MaCB", SqlDbType.Int);
                //p1.Value = maCB;

                SqlParameter p2 = new SqlParameter("@TenCB", SqlDbType.NVarChar);
                p2.Value = tbTenCB.Text;

                SqlParameter p3 = new SqlParameter("@ChucVuCB", SqlDbType.NVarChar);
                p3.Value = chucVu;

                SqlParameter p4 = new SqlParameter("@SoGioGiang", SqlDbType.Int);
                p4.Value = int.Parse(tbGioGiang.Text);

                SqlParameter p5 = new SqlParameter("@DonGia", SqlDbType.Money);
                p5.Value = decimal.Parse(tbDonGia.Text);

               // cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add (p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!!!");

                Database.CloseConnection();
                resetFields(false);
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
