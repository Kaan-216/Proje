using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6SigmaileSınavSistemi_MehmetKaanALTUN_
{
    public partial class formsonuclar : Form
    {
        public formsonuclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrencianaekran yeniforma = new ogrencianaekran();
            yeniforma.Show();
            this.Hide();
        }
    }
}
