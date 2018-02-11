using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sinema salon;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(tBoxSalon.Text, Convert.ToInt32(tBoxKoltukSayisi.Text));
                lblSonuc.Text = "Salon Oluşturuldu. Koltuk sayısı : " + salon.BosKoltukOgren();
            }
            catch
            {
                lblSonuc.Text = "Salon Oluşturulamadı. Bilgileri kontrol edin.";
            }
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            salon.BiletSat(cBoxOgrenci.Checked);
            lblSonuc.Text = "Bilet satıldı. Kalan koltuk sayısı : " + salon.BosKoltukOgren();
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(cBoxOgrenci.Checked);
            lblSonuc.Text = "Bilet iptal edildi. Kalan koltuk sayısı : " + salon.BosKoltukOgren();
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "Şu anki bakiye " + salon.BakiyeOgren() + " TL";
        }

        private void btnBosKoltuk_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "Boş koltuk sayısı " + salon.BosKoltukOgren();
        }
    }
}
