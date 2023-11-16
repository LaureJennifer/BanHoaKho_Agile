

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
        List<SanPham> _lstSP = new();
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
            lstDgrid.DataSource = _lstSP;
            _connection.Close();
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

        private void ResetFormBtn_Click(object sender, EventArgs e)
        {
            IdTxt.Clear();
            NameTxt.Clear();
            PriceTxt.Clear();
            QuantityTxt.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SortByPriceBtn_Click(object sender, EventArgs e)
        {

            var lstSpOrderByPrice = _lstSP.OrderByDescending(x => x.Gia).ToList();
            lstDgrid.DataSource = lstSpOrderByPrice;

        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            if (CheckExit(IdTxt.Text))
            {

                MessageBox.Show("Id đã tồn tại ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection SqlConnection = new SqlConnection("Data Source=trang;Initial Catalog=QLBH_agile;Integrated Security=True");
                SqlConnection.Open();
                var query = $"Insert into SANPHAM (IDSanPham, TEN , GIANHAP , SLNHAP)" +
                    $"VALUES ('{IdTxt.Text}','{NameTxt.Text}','{PriceTxt.Text}','{QuantityTxt.Text}')";
                SqlCommand command = new SqlCommand(query, SqlConnection);
                command.ExecuteNonQuery();

                SqlConnection.Close();
                
            }
            
        }
        private bool CheckExit(string ma)
        {
            _connection.Open();
            string query = $"select * from SANPHAM where IDSanPham = '{ma}'";
            SqlCommand sqlCommand = new SqlCommand(query, _connection);
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlCommand.ExecuteReader());
            _connection.Close();
            return dataTable.Rows.Count > 0;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _connection.Open();
            var query = $"UPDATE SANPHAM SET TEN = '{NameTxt.Text}', GIANHAP = '{PriceTxt.Text}', SLNHAP = '{QuantityTxt.Text}' WHERE IDSanPham = '{IdTxt.Text}'";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.ExecuteNonQuery();

            _connection.Close();
        }

        private void HienthiBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void lstDgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            IdTxt.Text = lstDgrid.Rows[d].Cells[0].Value.ToString();
            NameTxt.Text = lstDgrid.Rows[d].Cells[1].Value.ToString();
            PriceTxt.Text = lstDgrid.Rows[d].Cells[2].Value.ToString();
            QuantityTxt.Text = lstDgrid.Rows[d].Cells[3].Value.ToString();
        }
    }
}

//"F:\học tập\Xưởng\App_QuanLiDuAn_Agile"