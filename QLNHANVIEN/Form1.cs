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

namespace QLNHANVIEN
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-6U02GGD\\CONGDONG256;Initial Catalog=QLNvien;Integrated Security=True;";
        DataTable dt;
        string BL;
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
                        bangluong.DataSource = dt;
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
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM  LUONG WHERE Bacluong = @Bacluong";
            var parameters = new Dictionary<string, object>
            {
                {"@Bacluong", Tbbacluong.Text }
            };
            connectDatabase(sql, parameters);
            if (dt.Rows.Count >0 )
            {
                MessageBox.Show("Mã nhân viên đã tồn tại ");
                connectDatabase("SELECT * FROM LUONG");
            }
            else
            {
                string insert = "INSERT INTO LUONG (Bacluong, Luongcb, Hsoluong, HSPC) VALUES (@Bacluong, @Luongcb, @Hsoluong, @HSPC)";
                var inserParameters = new Dictionary<string, object>
                {
                    {"@Bacluong", Tbbacluong.Text},
                    {"@Luongcb", Tbluongcoban.Text },
                    {"@Hsoluong", Tbhesoluong.Text},
                    {"@HSPC", Tbhesophucap.Text}
                   
                };
                executeCommmand(insert, inserParameters);
                connectDatabase("SELECT *FROM LUONG");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectDatabase("SELECT *FROM LUONG");
        }

        private void bangluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = bangluong.CurrentRow.Index;
            Tbbacluong.Text = bangluong.Rows[i].Cells[0].Value.ToString();
            Tbluongcoban.Text = bangluong.Rows[i].Cells[1].Value.ToString();
            Tbhesoluong.Text = bangluong.Rows[i].Cells[2].Value.ToString();
            Tbhesophucap.Text = bangluong.Rows[i].Cells[3].Value.ToString();
            BL = Tbbacluong.Text;
        }
     
        
        private void nuttimkiem_Click(object sender, EventArgs e)
        {
            string search = tbtimkiem.Text.Trim();
            string sql = "SELECT * FROM LUONG WHERE Bacluong LIKE @BAcluong OR Luongcb LIKE @Luongcb OR Hsoluong LIKE @Hsoluong OR HSPC LIKE @HSPC OR MaNV LIKE @MaNV";
            var parameters = new Dictionary<string, object>
            {
                {"@Bacluong", "%" + search + "%" },
                {"@Luongcb", "%" + search + "%" },
                {"@Hsoluong", "%" + search + "%" },
                {"@HSPC", "%" + search + "%" }
               
            };
            connectDatabase(sql, parameters);
        }

        private void nutsua_Click(object sender, EventArgs e)
        {
            if (Tbbacluong.Text == BL)
            {
                string update = "UPDATE LUONG SET Luongcb = @Luongcb, Hsoluong = @Hsoluong, HSPC = @HSPC WHERE Bacluong = @Bacluong";
                var updateParameters = new Dictionary<string, object>
                {
                    {"@Bacluong", Tbbacluong.Text},
                    {"@Luongcb", Tbluongcoban.Text },
                    {"@Hsoluong", Tbhesoluong.Text},
                    {"@HSPC", Tbhesophucap.Text}
                   
                };
                executeCommmand(update, updateParameters);
                connectDatabase("SELECT *FROM LUONG");
            }
            else
            {
                string sql = "SELECT * FROM  LUONG WHERE Bacluong = @Bacluong";
                var parameters = new Dictionary<string, object>
                {
                    {"@Bacluong", Tbbacluong.Text }
                };
                connectDatabase(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                    connectDatabase("SELECT * FROM LUONG");
                }
                else
                {
                    string update = "UPDATE LUONG SET Luongcb = @Luongcb, Hsoluong = @Hsoluong, HSPC = @HSPC WHERE Bacluong = @Bacluong";
                    var updateParameters = new Dictionary<string, object>
                    {
                    {"@Bacluong", Tbbacluong.Text},
                    {"@Luongcb", Tbluongcoban.Text },
                    {"@Hsoluong", Tbhesoluong.Text},
                    {"@HSPC", Tbhesophucap.Text},
                    {"@OldBacluong", BL}

                    };
                    executeCommmand(update, updateParameters);
                    connectDatabase("SELECT *FROM LUONG");
                }

            }
        }

        private void nutxoa_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM LUONG WHERE Bacluong = @Bacluong";
            var deletePara = new Dictionary<string, object>
            {
                    {"@Bacluong", Tbbacluong.Text }
            };
            executeCommmand(delete, deletePara);
            connectDatabase("SELECT *FROM LUONG");

        }
    }
}
