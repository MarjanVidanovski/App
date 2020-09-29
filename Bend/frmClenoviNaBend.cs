using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bend
{
    public partial class frmClenoviNaBend : Form
    {
        public frmClenoviNaBend()
        {
            InitializeComponent();
        }
        public frmClenoviNaBend(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private BendoviDataContext bend = new BendoviDataContext();

        private void frmClenoviNaBend_Load(object sender, EventArgs e)
        {
            clenoviNaBendBindingSource.DataSource =
                from clenovinabend in bend.ClenoviNaBends
                orderby clenovinabend.ClenID
                select clenovinabend;
        }

        private void clenoviNaBendBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            clenoviNaBendBindingSource.EndEdit();
            try
            {
                bend.SubmitChanges();
                MessageBox.Show("SNIMENO!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Probavte da vnesite bend so bendID koj vekje postoi!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
