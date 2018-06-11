using System;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KS.GUI
{
    public partial class frmThietBi : Form
    {
        private DAL_ThietBi dal_tb = new DAL_ThietBi();
        private EC_ThietBi ec = new EC_ThietBi();
        private DataTable tblThietBi = new DataTable();
        private bool themmoi;
        void SetNull()
        {
            cboMaPh.Text = "";
            txtThietBi.Text = "";
            txtSoLuong.Text = "";
            txtNhaSanXuat.Text = "";
        }
        private void KhoaDieuKhien()
        {
            cboMaPh.Enabled = false;
            txtThietBi.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtNhaSanXuat.ReadOnly = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void MoDieuKhien()
        {
            cboMaPh.Enabled = true;
            txtThietBi.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtNhaSanXuat.ReadOnly = false;
        }
        private void HienThi(string where)
        {
            dgvDanhSach.DataSource = dal_tb.TaoBang(where);
        }
        private void DoDLMaLop()
        {

            cboMaPh.DataSource = dal_tb.TruyVanRaMaPh("");
            cboMaPh.DisplayMember = "MaPh";
        }
        public frmThietBi()
        {
            InitializeComponent();
        }


        private void frmThietBi_Load(object sender, EventArgs e)
        {
            HienThi("");
            KhoaDieuKhien();
            DoDLMaLop();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                cboMaPh.Text = dgvDanhSach.Rows[dong].Cells[0].Value.ToString();
                txtThietBi.Text = dgvDanhSach.Rows[dong].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[dong].Cells[2].Value.ToString();
                txtNhaSanXuat.Text = dgvDanhSach.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            DataTable tbl = dal_tb.TaoBang("");
            dgvDanhSach.DataSource = tbl;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            MoDieuKhien();
            txtThietBi.ReadOnly = true;
            cboMaPh.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ec.MaPh = cboMaPh.Text;
                ec.ThietBi = txtThietBi.Text;
                if (dal_tb.XoaTTThietBi(ec) == 0)
                {

                    MessageBox.Show("Không thể xoá!!!", "Thông báo???", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    dal_tb.XoaTTThietBi(ec);
                    MessageBox.Show("Đã xóa thành công!");
                    btnCapNhap_Click(sender, e);
                    SetNull();

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtThietBi.Text == "" || txtSoLuong.Text == "" || txtNhaSanXuat.Text == "" || cboMaPh.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                KhoaDieuKhien();
                return;
            }
            else
            {
                if (themmoi == true)/*đang ở trang thái thêm mới*/
                {
                    try
                    {
                        ec.ThietBi = txtThietBi.Text;
                        ec.MaPh = cboMaPh.Text;
                        ec.SoLuong = int.Parse(txtSoLuong.Text);
                        ec.NhaSanXuat = txtNhaSanXuat.Text;

                        dal_tb.ThemThongTin(ec);
                        MessageBox.Show("Đã thêm mới thành công");/*dòng thông báo*/
                        btnCapNhap_Click(sender, e);
                        SetNull();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }

                }
                else
                {
                    try
                    {
                        ec.ThietBi = txtThietBi.Text;
                        ec.MaPh = cboMaPh.Text;
                        ec.SoLuong = int.Parse(txtSoLuong.Text);
                        ec.NhaSanXuat = txtNhaSanXuat.Text;
                        dal_tb.SuaThongTin(ec);
                        MessageBox.Show("Đã sửa thành công");
                        btnCapNhap_Click(sender, e);
                        SetNull();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                SetNull();
                KhoaDieuKhien();/*không cho thao tác*/
                HienThi("");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtThietBi.Focus();
            MoDieuKhien();
            SetNull();
            themmoi = true;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();

            fsave.Filter = "(Tất cả các tệp)|*.*|(các tệp excel)|*.xlsx";
            fsave.ShowDialog();

            if (fsave.FileName != "")
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook;
                COMExcel.Worksheet exSheet;
                COMExcel.Range exRange;

                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:B3"].Font.Size = 14;
                exRange.Range["A1:B3"].Font.Name = "Times new roman";
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời

                exRange.Range["A1:A1"].ColumnWidth = 7;

                exRange.Range["B1:B1"].ColumnWidth = 15;

                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Quản lý khách sạn";

                exRange.Range["A1: A100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["D1: D100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["F1: F100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["G1: G100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["H1: H100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Thiết bị phòng";

                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["C2:E2"].Font.Size = 16;
                exRange.Range["C2:E2"].Font.Name = "Times new roman";
                exRange.Range["C2:E2"].Font.Bold = true;
                exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C2:E2"].MergeCells = true;
                exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:E2"].Value = "Danh Sách Thiết Bị Phòng";

                exRange.Range["A5"].ColumnWidth = 15;
                exRange.Range["B5"].ColumnWidth = 25;
                exRange.Range["C5"].ColumnWidth = 15;
                exRange.Range["D5"].ColumnWidth = 15;
                exRange.Range["E5"].ColumnWidth = 30;
                exRange.Range["F5"].ColumnWidth = 15;
                exRange.Range["G5"].ColumnWidth = 15;
                exRange.Range["H5"].ColumnWidth = 15;


                exRange.Range["A5:I5"].Font.Size = 14;
                exRange.Range["A5:I5"].Font.Bold = true;
                exRange.Range["A5:I5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                //Lấy tên cột dữ liệu
                for (int i = 0; i < dgvDanhSach.ColumnCount; i++)
                {
                    exSheet.Cells[5, i + 1] = dgvDanhSach.Columns[i].HeaderText;
                }
                //Đổ dữ liệu vào sheet
                for (int i = 0; i < dgvDanhSach.RowCount; i++)
                {
                    for (int j = 0; j < dgvDanhSach.ColumnCount; j++)
                    {
                        exSheet.Cells[i + 6, j + 1] = dgvDanhSach.Rows[i].Cells[j].Value;
                    }
                }

                DateTime d = DateTime.Now;
                exRange.Range["C3:E3"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["C3:E3"].MergeCells = true;
                exRange.Range["C3:E3"].Font.Italic = true;
                exRange.Range["C3:E3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;


                exApp.Visible = true;

                exBook.SaveAs(fsave.FileName);
            }
            else
            {
                MessageBox.Show("Bạn phải nhập tên!");
            }
        }

        private void txttentb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cbMaph_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtsl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtnsx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
