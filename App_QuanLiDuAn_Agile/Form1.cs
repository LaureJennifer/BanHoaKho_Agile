

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;

namespace App_QuanLiDuAn_Agile
{

    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=PHẠM-TIẾN-DŨNG;Initial Catalog=QLBH;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from SANPHAM";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dvg.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

//"F:\học tập\Xưởng\App_QuanLiDuAn_Agile"