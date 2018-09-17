using QLNV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV.View
{
    public partial class FormSuaYeuCau : Form
    {
        public FormSuaYeuCau(YeuCau obj )
        {
            InitializeComponent();
            yeuCauBindingSource.DataSource = obj;
        }
        public YeuCau InfoYeCau
        {
            get { return yeuCauBindingSource.Current as YeuCau; }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            yeuCauBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void FormSuaYeuCau_Load(object sender, EventArgs e)
        {

        }
    }
}
