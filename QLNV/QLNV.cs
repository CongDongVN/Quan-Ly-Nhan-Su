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

namespace QLNV
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonState(true, true, true, false, false, true);
            ToggleInputField(false);
            connectDatabase("select * from NHANVIEN ");
           
        }
        private string connectionString = "Data Source=DESKTOP-6U02GGD\\CONGDONG256;Initial Catalog=QLNvien;Integrated Security=True;";
        DataTable dt;
        string MaNV;
        private void connectDatabase(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= connectionString;
            con.Open();
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adt.SelectCommand.Parameters.AddWithValue("searchTerm", "%" +txtSearch.Text.Trim() + "%");
            adt.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void SetButtonState(bool addEnabled, bool updateEnabled, bool deleteEnabled, bool exitEenabled, bool okEnabled, bool offEnabled) {
            btnAdd.Enabled = addEnabled;
            btnUp.Enabled = updateEnabled;
            btnDel.Enabled = deleteEnabled;
            btnExit.Enabled = exitEenabled;
            btnOk.Enabled = okEnabled;
            btnOff.Enabled = offEnabled;
        }
        private void ToggleInputField(bool enable)
        {
            txtMaNV.ReadOnly = !enable;
            txtHoTen.ReadOnly = !enable;
            txtCCCD.ReadOnly = !enable;
            txtQueQuan.ReadOnly = !enable;
            txtNgaySinh.ReadOnly = !enable;
            rbtnNam.Enabled = enable;
            rbtnNu.Enabled = enable;
            txtSDT.ReadOnly = !enable;
            txtEmail.ReadOnly =  !enable;
            txtMaPB.ReadOnly = !enable;
            txtMaCV.ReadOnly =  !enable;
            txtMaTDHV.ReadOnly = !enable;
            txtBacLuong.ReadOnly = !enable;
        }
        private void ToggleForeignKeyFields(bool enable)
        {
            txtMaCV.Enabled = enable;
            txtMaPB.Enabled = enable;
            txtMaTDHV.Enabled = enable;
            txtBacLuong.Enabled= enable;
        }
        private void ClearInput()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtCCCD.Text = "";
            txtQueQuan.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtMaPB.Text = "";
            txtMaCV.Text = "";
            txtMaTDHV.Text = "";
            txtBacLuong.Text = "";
        }
        private void SetTextBoxesReadOnly(bool readOnly)
        {
            txtMaNV.ReadOnly = readOnly;
            txtHoTen.ReadOnly = readOnly;
            txtNgaySinh.ReadOnly = readOnly;
            txtCCCD.ReadOnly = readOnly;
            txtQueQuan.ReadOnly = readOnly;
            rbtnNam.Enabled = readOnly;
            rbtnNu.Enabled = readOnly;
            txtSDT.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtMaPB.ReadOnly = readOnly;
            txtMaCV.ReadOnly = readOnly;
            txtMaTDHV.ReadOnly = readOnly;
            txtBacLuong.ReadOnly = readOnly;
        }
        private bool IsEmailValid(string email)
        {
            // Kiểm tra nếu email có chứa ký tự @
            return email.Contains("@");
        }

        private bool checkInput()
        {
         return !(string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) ||
        string.IsNullOrWhiteSpace(txtNgaySinh.Text) || string.IsNullOrWhiteSpace(txtCCCD.Text) ||
        string.IsNullOrWhiteSpace(txtQueQuan.Text) ||
        (!rbtnNam.Checked && !rbtnNu.Checked) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtMaPB.Text) ||
        string.IsNullOrWhiteSpace(txtMaCV.Text) || string.IsNullOrWhiteSpace(txtMaTDHV.Text) ||
        string.IsNullOrWhiteSpace(txtBacLuong.Text));
        }
        private string GetNextEmloyeeID()
        {
            int maxID = 0;
            string query = "SELECT MAX(CAST(SUBSTRING(MaNV, 3, LEN(MaNV) - 2) AS INT)) AS MaxID FROM NHANVIEN";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy ID lớn nhất: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            maxID += 1;
            return maxID < 10 ? "NV0" + maxID : "NV" + maxID;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtMaNV.Text = GetNextEmloyeeID();
            ToggleInputField(true);
            txtMaNV.ReadOnly = true;
            SetButtonState(false, false, false, true, true, false);
            dataGridView1.Enabled = false;

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật.");
                return;
            }
            ToggleInputField(true);
            txtMaNV.ReadOnly = false;
           SetButtonState(false,false, false, true, true, false);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace (txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xoá.");
                return;
            }
            var confirmResult = MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Xác nhận xoá", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM [NHANVIEN] WHERE [MaNV] = @MaNV";
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá dữ liệu thành công.");
                    ClearInput();
                    connectDatabase("SELECT * FROM NHANVIEN");
                } catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             string email = txtEmail.Text;

    if (IsEmailValid(email))
    {
                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                connectDatabase("SELECT * FROM NHANVIEN");
    }
    else
    {
        MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        // Đặt lại focus vào ô nhập email
        txtEmail.Focus();
    }
            dataGridView1.Enabled = true;

            if (!checkInput())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";
            string query;
            bool isUpdating = !txtMaNV.ReadOnly;

            if (isUpdating)
            {
                query = "UPDATE [NHANVIEN] SET [MaNV] = @MaNV, [Hoten] = @Hoten, [Ngaysinh] = @Ngaysinh, [CCCD] = @CCCD, [Quequan] = @Quequan, [Gioitinh] = @Gioitinh, [Sdt] = @Sdt, [Email] = @Email, [MaPB] = @MaPB, [MaCV] = @MaCV, [MaTDHV] = @MaTDHV, [Bacluong] = @Bacluong WHERE [MaNV] = @OriginalMaNV";
            }
            else
            {
                query = "INSERT INTO [NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [CCCD], [Quequan], [Gioitinh], [Sdt], [Email], [MaPB], [MaCV], [MaTDHV], [Bacluong])" +
                        "VALUES (@MaNV, @Hoten, @Ngaysinh, @CCCD, @Quequan, @Gioitinh, @Sdt, @Email, @MaPB, @MaCV, @MaTDHV, @Bacluong)";
            }

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@Hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@Ngaysinh", txtNgaySinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@Quequan", txtQueQuan.Text);
                cmd.Parameters.AddWithValue("@Gioitinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
                cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text);
                cmd.Parameters.AddWithValue("@MaTDHV", txtMaTDHV.Text);
                cmd.Parameters.AddWithValue("@Bacluong", txtBacLuong.Text);

                if (isUpdating)
                {
                    cmd.Parameters.AddWithValue("@OriginalMaNV", txtMaNV.Text);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show(isUpdating ? "Cập nhật dữ liệu thành công." : "Thêm dữ liệu thành công.");
                ClearInput();
                connectDatabase("SELECT * from NHANVIEN");

                ToggleInputField(false);
                SetButtonState(true, true, true, false, false, true);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key violation error number in SQL Server
                {
                    MessageBox.Show("Lỗi: Mã CV, Mã PB, Bậc lương hoặc Mã TDHV không hợp lệ. Vui lòng kiểm tra lại.");
                    ToggleForeignKeyFields(true); // Re-enable foreign key fields for re-entry
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                con.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearInput();
            ToggleInputField(false);
            SetButtonState(true,true, true, false, false, true);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["Hoten"].Value.ToString();
                txtNgaySinh.Text = row.Cells["Ngaysinh"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtQueQuan.Text = row.Cells["Quequan"].Value.ToString();

                if (row.Cells["Gioitinh"].Value.ToString() == "Nam")
                {
                    rbtnNam.Checked = true;
                    rbtnNu.Checked = false;
                }
                else
                {
                    rbtnNam.Checked = false;
                    rbtnNu.Checked = true;
                }

                txtSDT.Text = row.Cells["Sdt"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMaPB.Text = row.Cells["MaPB"].Value.ToString();
                txtMaCV.Text = row.Cells["MaCV"].Value.ToString();
                txtMaTDHV.Text = row.Cells["MaTDHV"].Value.ToString();
                txtBacLuong.Text = row.Cells["Bacluong"].Value.ToString();

                
                SetTextBoxesReadOnly(true);
            }
        }

     
       

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string seachTerm = txtSearch.Text.Trim();
                string query = "";
                if(rbtnNV.Checked)
                {
                    query = "SELECT * FROM NHANVIEN WHERE MaNV like @searchTerm";
                }    
                else if(rebtnNameNV.Checked)
                {
                    query = "SELECT * FROM NHANVIEN WHERE Hoten like @searchTerm";
                } else if(rbtnAll.Checked)
                {
                    query = "SELECT * FROM NHANVIEN WHERE MaNV LIKE @searchTerm OR Hoten LIKE @searchTerm";
                }
                connectDatabase(query);
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        
    }
}
