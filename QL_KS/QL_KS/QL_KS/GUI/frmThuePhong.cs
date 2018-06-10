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
    public partial class frmThuePhong : Form
    {
        DAL_Phong dalPh = new DAL_Phong();
        KetNoiData cn = new KetNoiData();
        EC_PhieuThue ecPT = new EC_PhieuThue();
        EC_HoaDon ecHD = new EC_HoaDon();
        DAL_HoaDon dalHD = new DAL_HoaDon();
        private string _Gia;
        private bool _load;
        public frmThuePhong()
        {
            InitializeComponent();
        }
      
    }
}
