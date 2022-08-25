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

namespace CS223_LabSession_4
{
    public partial class SQLTEST : Form
    {
        public SQLTEST()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Query = "Insert into persons values('Bruk','Manchester',125,15,85,180,'July 5 1985')";
                String ConnectionString = "Data Source=DESKTOP-44OPTQE\\SQLEXPRESS;Initial Catalog=University;Integrated Security=true";
                SqlConnection sq = new SqlConnection(ConnectionString);
                sq.Open();
                SqlCommand cmd = new SqlCommand(Query,sq);
                int c= (int)cmd.ExecuteNonQuery();
                MessageBox.Show(c.ToString()+ " Number of rows inserted");
                // MessageBox.Show("DB Connected");
                sq.Close();


            }
            catch (SqlException s) { MessageBox.Show(s.Message
                ); }
        }
    }
}
