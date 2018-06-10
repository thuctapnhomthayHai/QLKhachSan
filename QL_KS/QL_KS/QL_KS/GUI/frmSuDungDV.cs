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
namespace QL_KS.GUI
{
    public partial class frmSuDungDV : Form
    {
        DataTable dt;
        private DAL_SuDungDichVu DAL_SuDung = new DAL_SuDungDichVu();
        private EC_SuDungDichVu EC_SuDung = new EC_SuDungDichVu();
       
        public frmSuDungDV()
        {
            InitializeComponent();
        }

       
    }
}
