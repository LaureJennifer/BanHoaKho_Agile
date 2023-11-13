using Microsoft.IdentityModel.Tokens;

namespace App_QuanLiDuAn_Agile
{
    public partial class Login : Form
    {
        public static bool checkLogin { get; set; } 
        public Login()
        {
            InitializeComponent();
        }
        private bool KiemTraNhapLieu()
        {
            
            bool check =false;
            if (string.IsNullOrEmpty(UserNameTxt.Text) || string.IsNullOrEmpty(PassWordTxt.Text))
            {
                check = false;
                MessageBox.Show("Chua nhap du lieu!", "Thong bao!");
            }
            else if (checkLogin==true)
            {
                if (!UserNameTxt.Text.Contains("@admin"))
                {
                    check = false;
                    MessageBox.Show("Chua nhap dung du lieu!", "Thong bao!");
                }
                else check = true;
            }         
            else
               if (checkLogin ==false)
                {
                    if (!UserNameTxt.Text.Contains("@admin"))
                    {
                        check  = true; 
                    }
                    else
                    {
                        check = false;
                        MessageBox.Show("Chua nhap dung du lieu!", "Thong bao!");
                    }
                }
                
            
            return check;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}
