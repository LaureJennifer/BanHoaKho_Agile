namespace App_QuanLiDuAn_Agile
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login.checkLogin = true;
            Login login = new Login();
            
            login.ShowDialog();
            
        }

        private void btnKhach_Click_1(object sender, EventArgs e)
        {
            Login.checkLogin = false;
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
