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
    public partial class frmThietBi : Form
    {
        private DAL_ThietBi dal_tb = new DAL_ThietBi();
        private EC_ThietBi ec = new EC_ThietBi();
        private DataTable tblThietBi = new DataTable();
        private bool themmoi;
       
        public frmThietBi()
        {
            InitializeComponent();
        }


       
    }
}
