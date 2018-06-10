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
    public partial class frmQuanLyDV : Form
    {
        private DAL_DichVu DAL_DV = new DAL_DichVu();
        private EC_DichVu EC_DV = new EC_DichVu();
        private bool _them = false;
        public frmQuanLyDV()
        {
            InitializeComponent();
        }
       
    }
}
