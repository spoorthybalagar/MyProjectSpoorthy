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
namespace WinFormsApp2
{
    public partial class StoredProcedure : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-GF410M3\\SQLSERVER2022;Database=EmployeeDb;User Id=sa;Password=user123;");
        SqlCommand cmd; SqlParameter p1;SqlDataReader dr;
        public StoredProcedure()
        {
            InitializeComponent();
        }

        private void BTNCLEAR_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BTNINSERT_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempid.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempname", SqlDbType.VarChar);
            p1.Value = txtempname.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("Pempdesig", SqlDbType.VarChar);
            p1.Value = txtEmpDesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdoj", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtempdoj.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempsal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempsal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempdept.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s) Inserted");


        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Update1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempid.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempname", SqlDbType.VarChar);
            p1.Value = txtempname.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("Pempdesig", SqlDbType.VarChar);
            p1.Value = txtEmpDesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdoj", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtempdoj.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempsal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempsal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempdept.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s) Updated");

        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DelRec", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempid.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s) Deleted");
        }

        private void BTNFind_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from employeetb where EmpId=" + txtempid.Text, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr=cmd.ExecuteReader();
            if(dr.Read()==true)
            {
                txtempid.Text = dr[0].ToString();
                txtempname.Text = dr[1].ToString();
                txtEmpDesig.Text = dr[2].ToString();
                txtempdoj.Text = dr[3].ToString();
                txtempsal.Text = dr[4].ToString();
                txtempdept.Text = dr[5].ToString();
            }
            else
            {
                MessageBox.Show("records not found");
                dr.Close();
            }
            con.Close();
        }


        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void StoredProcedure_Load(object sender, EventArgs e)
        //{

        //}

        //private void BTNINSERT_Click(object sender, EventArgs e)
        //{

        //}

        //private void BTNUPDATE_Click(object sender, EventArgs e)
        //{

        //}

    }
}
