

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlTypes;

namespace App_QuanLiDuAn_Agile
{

    public partial class Form1 : Form
    {
        List<SanPham> _lstSP=new();
        private SqlConnection _connection;
        void loaddata()
        {
            _connection.Open();
            String query = "select * from SANPHAM";
            SqlCommand cmd = new SqlCommand(query, _connection);
            DataTable tableData = new DataTable();
            tableData.Load(cmd.ExecuteReader());
            //dvg.DataSource = tableData;
            foreach (DataRow row in tableData.Rows)
            {
                SanPham sanPham = new SanPham()
                {
                    idSP = (string)row["IDSanPham"],
                    nameSP = (string)row["TEN"],
                    Gia = (decimal)row["GIANHAP"],
                    Soluong = (int)row["SLNHAP"]
                };
                _lstSP.Add(sanPham);
            }
            dvg.DataSource = _lstSP;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"Data Source=trang;Initial Catalog=QLBH_agile;Integrated Security=True";
            _connection = new SqlConnection(path);
            loaddata();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ResetFormBtn_Click(object sender, EventArgs e)
        {
            IdTxt.Clear();
            NameTxt.Clear();
            PriceTxt.Clear();
            QuantityTxt.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //xóa
        }

        private void SortByPriceBtn_Click(object sender, EventArgs e)
        {

            var lstSpOrderByPrice=_lstSP.OrderByDescending(x => x.Gia).ToList();
            dvg.DataSource = lstSpOrderByPrice;
            
        }
    }
}

//"F:\học tập\Xưởng\App_QuanLiDuAn_Agile"