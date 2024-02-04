using System.Data;
using System.Data.SqlClient;


namespace login_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=""simple Login page info"";Integrated Security=True");

        private void button_login_Click(object sender, EventArgs e)
        {
            string username, password;

            username = text_username.Text;
            password = text_pass.Text;

            try
            {
                string query = "SELECT * FROM login WHERE username = '" + text_username.Text + "'  AND password = '" + text_pass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = text_username.Text;
                    password = text_pass.Text;


                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Login details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_username.Clear();
                    text_pass.Clear();

                    text_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                Conn.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_username.Clear();
            text_pass.Clear();

            text_username.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do You Want to exit ?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}