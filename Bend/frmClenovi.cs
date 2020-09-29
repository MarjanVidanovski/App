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
    public partial class frmClenovi : Form
    {
        public frmClenovi()
        {
            InitializeComponent();
        }
        public frmClenovi(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private BendoviDataContext bend = new BendoviDataContext();

        private void frmClenovi_Load(object sender, EventArgs e)
        {
            clenoviBindingSource.DataSource =
                from clenovi in bend.Clenovis
                orderby clenovi.ClenoviID
                select clenovi;
        }

        private void clenoviBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            clenoviBindingSource.EndEdit();
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
