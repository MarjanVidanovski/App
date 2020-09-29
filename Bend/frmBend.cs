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
    public partial class frmBend : Form
    {
        public frmBend()
        {
            InitializeComponent();
        }
        public frmBend(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private BendoviDataContext bend = new BendoviDataContext();

        private void frmBend_Load(object sender, EventArgs e)
        {
            bendoviBindingSource.DataSource =
                from bendovi in bend.Bendovis
                orderby bendovi.BendID
                select bendovi;
        }

        private void bendoviBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            bendoviBindingSource.EndEdit();
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
