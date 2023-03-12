namespace Ebob
{
    public class Uygulamalar
    {
        /// <summary>
        /// ebob hesaplamak için asal çarpanları metodunu kullanır
        /// </summary>
        /// <param name="sayilar"></param>
        /// <returns></returns>
        public uint BirinciYontem(List<uint> sayilar)
        {
            #region Sayilar küçükten büyüğe doğrulanması
            uint gecici = default;
            for (int i = 0; i < sayilar.Count; i++)
            {
                for (int j = 0; j < sayilar.Count; j++)
                {
                    if (sayilar[i] < sayilar[j])
                    {
                        gecici = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                }
            }
            #endregion

            #region ebob hesaplama
            uint ebob = 1;
            short sayac = 0;
            List<uint> yedekDizi = new List<uint>(sayilar);
            for (uint i = 2; i <= sayilar[0];)
            {
                sayac = 0;
                for (int j = 0; j < yedekDizi.Count; j++)
                {
                    if (yedekDizi[j] % i == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == yedekDizi.Count)
                {
                    ebob *= i;
                    for (int j = 0; j < yedekDizi.Count; j++)
                    {
                        if (yedekDizi[j] % i == 0)
                        {
                            yedekDizi[j] = yedekDizi[j] / i;
                        }
                    }
                }
                else
                {
                    //Dizideki hicbir elemanın bolunmedigi durum
                    i++;
                }
            }
            #endregion

            return ebob;
        }

        // Oklid yontemi;
        // b==0 için ebob(a,b)=a;
        // b!=0 için ebob(a,b)=ebob(b,(a mod b)); 
        /// <summary>
        /// ebob hesaplamak için Öklid yöntemi kullanır. (Özyinemeli)
        /// </summary>
        /// <param name="buyukSayi"></param>
        /// <param name="kucukSayi"></param>
        /// <returns></returns>
        public uint IkinciYontem(uint buyukSayi, uint kucukSayi)
        {
            if (kucukSayi == 0)
                return buyukSayi;
            else
            {
                return IkinciYontem(kucukSayi, buyukSayi % kucukSayi);
            }
        }

        /// <summary>
        /// ebob hesaplamak için Öklid yöntemi kullanır. (İteratif)
        /// </summary>
        /// <param name="buyukSayi"></param>
        /// <param name="kucukSayi"></param>
        /// <returns></returns>
        public uint UcuncuYontem(uint buyukSayi, uint kucukSayi)
        {
            uint gecicisayi;
            while (kucukSayi != 0)
            {
                gecicisayi = buyukSayi % kucukSayi;
                buyukSayi = kucukSayi;
                kucukSayi = gecicisayi;
            }
            return buyukSayi;
        }
    }
}
