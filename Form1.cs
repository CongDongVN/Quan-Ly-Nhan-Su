using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trinhdohocvan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-6U02GGD\\CONGDONG256;Initial Catalog=QLNvien;Integrated Security=True;";
        DataTable dt;
        string HV;
        private void connectDatabase(string sql, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        adt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void executeCommmand(string sql, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    cmd.ExecuteNonQuery(); // Thực hiện truy vấn SQL từ câu lệnh cmd.CommandText = sql
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            connectDatabase("SELECT * FROM TRINHDOHOCVAN");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM  TRINHDOHOCVAN WHERE MaTDHV = @MaTDHV";
            var deletePara = new Dictionary<string, object>
            {
                    {"@MaTDHV", txtMatrinhdo.Text}
            };
            executeCommmand(delete, deletePara);
            connectDatabase("SELECT *FROM TRINHDOHOCVAN");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string search = txtTimkiem.Text.Trim();
            string sql = "SELECT * FROM TRINHDOHOCVAN WHERE MaTDHV LIKE @MaTDHV OR TTDHV LIKE @TTDHV OR CNGANH LIKE @CNGANH ";
            var parameters = new Dictionary<string, object>
            {
                {"@MaTDHV", "%" + search + "%" },
                {"@TTDHV", "%" + search + "%" },
                {"@CNGANH", "%" + search + "%" },

            };
            connectDatabase(sql, parameters);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM  TRINHDOHOCVAN WHERE MaTDHV = @MaTDHV";
            var parameters = new Dictionary<string, object>
            {
                {"@MaTDHV", txtMatrinhdo.Text }
            };
            connectDatabase(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã TDHV đã tồn tại ");
                connectDatabase("SELECT * FROM TRINHDOHOCVAN");
            }
            else
            {
                string insert = "INSERT INTO TRINHDOHOCVAN (MaTDHV, TTDHV, CNGANH) VALUES (@MaTDHV, @TTDHV, @CNGANH)";
                var inserParameters = new Dictionary<string, object>
                {
                    { "@MaTDHV", txtMatrinhdo.Text },
                    { "@TTDHV", txtTentrinhdo.Text },
                    { "@CNGANH", txtTenchuyennganh.Text },

                };
                executeCommmand(insert, inserParameters);
                connectDatabase("SELECT *FROM TRINHDOHOCVAN");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMatrinhdo.Text == HV)
            {
                string update = "UPDATE TRINHDOHOCVAN SET TTDHV = @TTDHV, CNGANH = @CNGANH WHERE MaTDHV = @MaTDHV";
                var updateParameters = new Dictionary<string, object>
                {
                    {"@MaTDHV", txtMatrinhdo.Text},
                    {"@TTDHV", txtTentrinhdo.Text},
                    {"@CNGANH", txtTenchuyennganh.Text}
                };
                executeCommmand(update, updateParameters);
                connectDatabase("SELECT *FROM TRINHDOHOCVAN");
            }
            else
            {
                string sql = "SELECT * FROM  TRINHDOHOCVAN WHERE MaTDHV = @MaTDHV";
                var parameters = new Dictionary<string, object>
                {
                    {"@MaTDHV", txtMatrinhdo.Text}
                };
                connectDatabase(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã TDHV đã tồn tại");
                    connectDatabase("SELECT * FROM TRINHDOHOCVAN");
                }
                else
                {
                    string update = "UPDATE TRINHDOHOCVAN SET MaTDHV = @MaTDHV,TTDHV = @TTDHV, CNGANH = @CNGANH WHERE MaTDHV = @OldMaTDHV";
                    var updateParameters = new Dictionary<string, object>
                    {
                    {"@MaTDHV", txtMatrinhdo.Text},
                    {"@TTDHV", txtTentrinhdo.Text},
                    {"@CNGANH", txtTenchuyennganh.Text},
                    {"@OldMaTDHV", HV }
                    };
                    executeCommmand(update, updateParameters);
                    connectDatabase("SELECT *FROM TRINHDOHOCVAN");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMatrinhdo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenchuyennganh.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTentrinhdo.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            HV = txtMatrinhdo.Text;
        }
    }
}
