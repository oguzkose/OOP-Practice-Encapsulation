using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEtiketOlustur_Click(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = new Ayakkabi();

            ayakkabi.marka = txtMarka.Text;
            ayakkabi.renk = txtRenk.Text;
            ayakkabi.numara = Convert.ToInt32(txtNumara.Text);
            ayakkabi.fiyat =Convert.ToDecimal( txtFiyat.Text);

            txtEtiketMarka.Text = ayakkabi.marka;
            txtEtiketRenk.Text = ayakkabi.renk;
            txtEtiketNumara.Text = ayakkabi.numara.ToString();
            txtEtiketFiyat.Text = ayakkabi.KDVdahil.ToString();
        }
    }
}
