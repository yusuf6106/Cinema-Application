using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApplication
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;

        const double TAM = 20;
        const double OGRENCI = 15;

        public Sinema(string salonn, int koltuksayi) //Kurucu Metot
        {
            toplamKoltukSayisi = koltuksayi;
            salonNo = salonn;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;

        }

        public void BiletSat(bool ogrenci) //Bilet Satış
        {
            bosKoltukSayisi--;
            if (ogrenci)
                bakiye += OGRENCI;
            else
                bakiye += TAM;
        }

        public void BiletIptal(bool ogrenci) //Bilet İade
        {
            bosKoltukSayisi++;
            if (ogrenci)
                bakiye -= OGRENCI;
            else
                bakiye -= TAM;
        }

        public int BosKoltukOgren() //Boş koltuk Sayısı
        {
            return bosKoltukSayisi;
        }

        public double BakiyeOgren() //Bakiye Öğren
        {
            return bakiye;
        }
    }
}
