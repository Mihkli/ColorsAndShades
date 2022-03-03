using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsAndShades
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorsAndShades.Properties.Settings.ColorsConnectionString"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PopulatePetsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Primarycolor", connection))
            {
                DataTable colortable = new DataTable();
                adapter.Fill(colortable);

                listPrimaryColors.DisplayMember = "PrimaryColorName";
                listPrimaryColors.ValueMember = "Id";
                listPrimaryColors.DataSource = colortable;

            }
        }
    }
}
