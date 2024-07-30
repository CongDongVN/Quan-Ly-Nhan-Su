using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-6U02GGD\\CONGDONG256;Initial Catalog=QLNvien;Integrated Security=True;";
        DataTable dt;
        string Mapb;
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
            connectDatabase("SELECT * FROM PhongBan");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM  PhongBan WHERE MaPB = @MaPB";
            var parameters = new Dictionary<string, object>
            {
                {"@MaPB", tbMaPB.Text }
            };
            connectDatabase(sql,parameters);
            if (dt.Rows.Count > 0)
            {
               MessageBox.Show("Mã phòng ban đã tồn tại");
                connectDatabase("SELECT * FROM PhongBan");
            }
            else
            {
                string insert = "INSERT INTO PhongBan (MaPB,TenPB,Sodtpb) VALUES (@MaPB, @TenPB, @Sodtpb)";
                var inserParameters = new Dictionary<string, object>
                {
                    {"@MaPB",tbMaPB.Text},
                    {"@TenPB",tbTenPB.Text},
                    {"@Sodtpb",tbSDTPB.Text}
                };
                executeCommmand(insert, inserParameters);
                connectDatabase("SELECT * FROM PhongBan");
            } 
                

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tbMaPB.Text == Mapb)
            {
                // If MaPB is unchanged, directly update the record
                string update = "UPDATE PhongBan SET TenPB = @TenPB, Sodtpb = @Sodtpb WHERE MaPB = @MaPB";
                var updateParameters = new Dictionary<string, object>
                {
                    {"@MaPB", tbMaPB.Text},
                    {"@TenPB", tbTenPB.Text},
                    {"@Sodtpb", tbSDTPB.Text}
                };
                executeCommmand(update, updateParameters);
                connectDatabase("SELECT * FROM PhongBan");
            }
            else
            {
                // If MaPB is changed, check if the new MaPB already exists
                string sql = "SELECT * FROM PhongBan WHERE MaPB = @MaPB";
                var parameters = new Dictionary<string, object>
                {
                    {"@MaPB", tbMaPB.Text }
                };
                connectDatabase(sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại");
                    connectDatabase("SELECT * FROM PhongBan");
                }
                else
                {
                    string update = "UPDATE PhongBan SET MaPB = @MaPB, TenPB = @TenPB, Sodtpb = @Sodtpb WHERE MaPB = @OldMaPB";
                    var updateParameters = new Dictionary<string, object>
                    {
                        {"@MaPB", tbMaPB.Text},
                        {"@TenPB", tbTenPB.Text},
                        {"@Sodtpb", tbSDTPB.Text},
                        {"@OldMaPB", Mapb}
                    };
                    executeCommmand(update, updateParameters);
                    connectDatabase("SELECT * FROM PhongBan");
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            tbMaPB.Text= dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbTenPB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbSDTPB.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            Mapb = tbMaPB.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM PhongBan WHERE MaPB = @MaPB";
            var deletePara = new Dictionary<string, object>
            {
                 {"@MaPB", tbMaPB.Text }
            };
            executeCommmand(delete, deletePara);
            connectDatabase("SELECT * FROM PhongBan");
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string search = tbTimkiem.Text.Trim();
            string sql = "SELECT * FROM PhongBan WHERE MaPB LIKE @MaPB OR TenPB LIKE @TenPB OR Sodtpb LIKE @Sodtpb";
            var parameters = new Dictionary<string, object>
            {
                {"@MaPB", "%" + search + "%" },
                {"@TenPB", "%" + search + "%" },
                {"@Sodtpb", "%" + search + "%" }
            };
            connectDatabase(sql, parameters);
        }
    }
}
