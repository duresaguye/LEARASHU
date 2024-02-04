using System;
using System.Linq;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class mainPage : Form
    {
        private string text;
        private int len = 0;
        public mainPage()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(len < text.Length)
            {
                lblWelcomeTxt.Text = lblWelcomeTxt.Text + text.ElementAt(len);
                len++;
            }
            else
                welcomeTextTimer.Stop();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            text = lblWelcomeTxt.Text;
            lblWelcomeTxt.Text = "";
            welcomeTextTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_page Login_Page = new Login_page();
            Farmer_Login_Form farmer_Login_Form = new Farmer_Login_Form();
            if(comboBox1.SelectedIndex == 1)
            {
                Login_Page.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                farmer_Login_Form.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
