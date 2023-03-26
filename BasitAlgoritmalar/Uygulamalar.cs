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
                if (i % 2 != 0)
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
        public List<ulong> SayiyaKadarMukemmelSayilar(ulong pozitifSayi)
        {
            List<ulong> mukemmelSayilar = new();
            for (ulong sayi = 1; sayi < pozitifSayi; sayi++)
            {
                ulong toplam = 0;
                for (ulong j = 1; j < sayi; j++)
                {
                    if (sayi % j == 0)
                        toplam += j;
                }
                if (toplam == sayi)
                    mukemmelSayilar.Add(sayi);
            }
            return mukemmelSayilar;
        }

        /// <summary>
        /// Sayının rakamları toplamını bulma
        /// </summary>
        /// <param name="sayi">Bir tam sayı</param>
        /// <returns>Sayının rakamları toplamı</returns>
        public long SayininRakamlariToplaminiBulma(int sayi)
        {
            if (sayi < 0)
                sayi *= (-1);

            long toplam = default;
            while (sayi > 0)
            {
                toplam += sayi % 10;
                sayi = sayi / 10;
            }
            return toplam;
        }

        /// <summary>
        /// Sayının rakamlarını tersine çevirme
        /// </summary>
        /// <param name="sayi">Bir tam sayı</param>
        /// <returns>Sayının rakamlarının tersine çevrilmiş hali</returns>
        public int SayininRakamlariniTersineCevirme(int sayi)
        {
            int sonuc = default;
            bool pozitif = true;

            if (sayi < 0)
            {
                pozitif = false;
                sayi *= (-1);
            }

            while (sayi > 0)
            {
                sonuc = ((sonuc * 10) + (sayi % 10));
                sayi /= 10;
            }

            if (!pozitif)
                sonuc *= (-1);

            return sonuc;
        }
    
        /// <summary>
        /// Alınan sayi dizisindeki en büyük sayıyı bulma
        /// </summary>
        /// <param name="sayiList">Sayi dizisi</param>
        /// <returns>Büyük sayi</returns>
        public int BuyukSayiyiBulma(List<int> sayiList)
        {
            int buyuk = sayiList[0];
            foreach (var sayi in sayiList.GetRange(1,sayiList.Count-1))
            {
                if (sayi > buyuk)
                    buyuk = sayi;
            }
            return buyuk;
        }
    }
}
