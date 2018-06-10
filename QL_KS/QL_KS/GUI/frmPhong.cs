using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KS;
using System.Data.SqlClient;
namespace QL_KS.GUI
{
    public partial class frmPhong : Form
    {
        private DAL_Phong dal_Ph = new DAL_Phong();
        private EC_Phong ec_Ph = new EC_Phong();
        private DataTable tblPhong = new DataTable();
        private bool themmoi;
        DataTable dt;

       
        public frmPhong()
        {
            InitializeComponent();
        }
        
    }
}
