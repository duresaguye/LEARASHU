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

namespace LEARASHU
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            DisplayDataOnTableLayoutPanel();
        }
        private void DisplayDataOnTableLayoutPanel()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS; Initial Catalog=LEARASHU; Integrated Security=True");
            string query = "SELECT * FROM Exporter_create_account"; 
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Exporter_create_account");

            // Check if there are any rows in the dataset
            if (dataSet.Tables["Exporter_create_account"].Rows.Count > 0)
            {
                // Assuming you want to display the first row's data in label1
                DataRow row = dataSet.Tables["Exporter_create_account"].Rows[0];

                // Assuming you have a column named "ColumnName" in your table
                string dataToDisplay = row["ExporterID"].ToString();

                // Set the text of label1 with the fetched data
                label1.Text = dataToDisplay;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
