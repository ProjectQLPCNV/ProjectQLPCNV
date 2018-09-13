using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.APIS;
using QLNV.Model;

namespace QLNV.View
{
    public partial class FormThem : Form
    {
        public CanBo canBoInfo
        {
            get { return canBoBindingSource.Current as CanBo; }
        }
        public FormThem(CanBo obj)
        {
            InitializeComponent();
            canBoBindingSource.DataSource = obj;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormThem_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            canBoBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
