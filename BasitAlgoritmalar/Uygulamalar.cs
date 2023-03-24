namespace BasitAlgoritmalar
{
    public class Uygulamalar
    {
        /// <summary>
        /// Bir yılın artık yıl olup olmadığını bulan fonksiyon
        /// </summary>
        /// <param name="yil">Yıl Bilgisi</param>
        /// <returns></returns>
        public bool ArtikYilMi(uint yil)
        {
            if ((yil % 4 == 0) && (yil % 100 != 0) || (yil % 400 == 0))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parametre olarak aldığı pozitif tam sayıya(dahil) kadar olan sayıların toplamını hesaplama
        /// </summary>
        /// <param name="pozitifSayi">Pozitif bir tam sayı</param>
        /// <returns>Sayiların toplamı</returns>
        public uint SayiyaKadarToplam(uint pozitifSayi)
        {
            uint toplam = 0;
            for (uint i = 0; i <= pozitifSayi; i++)
            {
                toplam += i;
            }
            return toplam;
        }

        /// <summary>
        /// Parametre olarak aldığı pozitif tam sayıya(dahil) kadar olan TEK sayıların toplamını hesaplama
        /// </summary>
        /// <param name="pozitifSayi">Pozitif bir tam sayı</param>
        /// <returns>Tek sayıların toplamı</returns>
        public uint SayiyaKadarTekToplam(uint pozitifSayi)
        {
            uint toplamTek = 0;
            for (uint i = 1; i <= pozitifSayi; i++)
            {
                if(i%2!=0)
                    toplamTek += i;
            }
            return toplamTek;
        }

        /// <summary>
        /// Parametre olarak aldığı pozitif tam sayıya(dahil) kadar olan ÇİFT sayıların toplamını hesaplama
        /// </summary>
        /// <param name="pozitifSayi">Pozitif bir tam sayı</param>
        /// <returns>Çift sayıların toplamı</returns>
        public uint SayiyaKadarCiftToplam(uint pozitifSayi)
        {
            uint toplamCift = 0;
            for (uint i = 1; i <= pozitifSayi; i++)
            {
                if (i % 2 == 0)
                    toplamCift += i;
            }
            return toplamCift;
        }

        /// <summary>
        /// Parametre olarak aldığı pozitif tam sayıya(dahil) kadar olan Mükemmel Sayıları bulma
        /// </summary>
        /// <param name="pozitifSayi">Pozitif bir tam sayı</param>
        /// <returns>Bulunan mükemmel sayıların listesi</returns>
        public List<uint> SayiyaKadarMukemmelSayilar(uint pozitifSayi)
        {
            List<uint> mukemmelSayilar = new();
            for (uint sayi = 1; sayi < pozitifSayi; sayi++)
            {
                uint toplam = 0;
                for (uint j = 1; j < sayi; j++)
                {
                    if (sayi % j == 0)
                        toplam += j;
                }
                if (toplam == sayi)
                    mukemmelSayilar.Add(sayi);
            }
            return mukemmelSayilar;
        }
    }
}
