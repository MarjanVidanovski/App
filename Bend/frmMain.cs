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
    public partial class frmMain : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public frmMain()
        {
            InitializeComponent();

            player.SoundLocation = "music.wav";
        }

        private void mnuBend_Click(object sender, EventArgs e)
        {
            frmBend f = new frmBend();
            f.Show();
        }

        private void mnuClenovi_Click(object sender, EventArgs e)
        {
            frmClenovi f = new frmClenovi();
            f.Show();
        }

        private void mnuCLenoviNaBend_Click(object sender, EventArgs e)
        {
            frmClenoviNaBend f = new frmClenoviNaBend();
            f.Show();
        }

        private void mnuIzlez_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Play();
        }

    }
}
