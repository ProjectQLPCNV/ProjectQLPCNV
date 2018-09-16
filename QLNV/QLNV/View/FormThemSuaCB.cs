using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.Model;
using QLNV.APIS;

namespace QLNV.View
{
    public partial class FormThemSuaCB : Form
    {
        public FormThemSuaCB(CanBo obj)
        {
            InitializeComponent();
            canBoBindingSource.DataSource = obj;
        }
        public CanBo canBoInfo
        {
            get { return canBoBindingSource.Current as CanBo; }
        }
        private void FormThemSua_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            canBoBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
