namespace AlanCevreHesaplari
{
    public class Uygulamalar
    {
        private double _pi = 3.14159265358979323846;
        public double KureAlani(double sayi)
        {
            return 4 * _pi * sayi * sayi;
        }
        public double KureHacmi(double sayi)
        {
            return (4 * _pi * sayi * sayi * sayi) / 3;
        }
        public double DaireninAlani(double sayi)
        {
            return _pi * sayi * sayi;
        }
        public double DaireninCevresi(double sayi)
        {
            return _pi * sayi * 2;
        }
    }
}
