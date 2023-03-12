namespace Ekok
{
    public class Uygulamalar
    {
        public uint Ekok(List<uint> sayilar)
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

            #region ekok hesaplama
            uint ekok = 1;
            bool bolduMu = false;
            List<uint> yedekDizi = new List<uint>(sayilar);
            for (uint i = 2; i <= sayilar[^1];)
            {
                bolduMu = false;

                for (int j = 0; j < yedekDizi.Count; j++)
                {
                    if (yedekDizi[j] % i == 0)
                    {
                        bolduMu = true;
                        yedekDizi[j] = yedekDizi[j] / i;
                    }
                }
                if (bolduMu)
                {
                    ekok *= i;
                }
                else
                {
                    //Dizideki hicbir elemanın bolunmedigi durum
                    i++;
                }
            }
            #endregion
            return ekok;
        }
    }
}
