using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace LEARASHU
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }




        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True");


        

        

       

        private void FloginBtn_Click(object sender, EventArgs e)
        {
            string username = EtxtBoxPhoneOrEmail.Text;
            string password = EtxtBoxPassword.Text;

            try
            {
                string query = "SELECT * FROM exporterCreateAccountt WHERE phoneNumber = @username AND password = @password";
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Successful login
                        firstPage firstPageInstance = new firstPage();
                        firstPageInstance.AccessPasswordTextBox.Text = password;
                        firstPageInstance.AccessPhoneNumberTextBox.Text = username;

                        // Show the same instance of firstPage
                        firstPageInstance.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Invalid login
                        MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display a more informative error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EtxtBoxPassword.Clear(); // Clear the password field
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            create_account create_Account = new create_account();
            create_Account.Show();
            this.Hide();
        }



        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
            this.Close();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showPasswordCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            EtxtBoxPassword.PasswordChar = showPasswordCheckBox1.Checked ? '\0' : '*';
        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }
    }
}
