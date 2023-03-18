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
    }
}
