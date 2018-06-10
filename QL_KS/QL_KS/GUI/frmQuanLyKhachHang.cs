using System;
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
    public partial class frmQuanLyKhachHang : Form
    {
        DAL_KhachHang KhachHang = new DAL_KhachHang();
        EC_KhachHang customer = new EC_KhachHang();
        DataTable dt = new DataTable();
        bool themmoi = false;
       
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

    }
}
