using BasitAlgoritmalar;
using OrtakYapilar;
using System.Diagnostics.Contracts;
using System.Security;

List<string> menu = new();
menu.Add("Basit Algoritmalar");
menu.Add("1-Artık Yıl Hesaplama");
menu.Add("2-Girilen pozitif tam sayıya(dahil) kadar olan sayıların toplamını bulma");
menu.Add("3-Girilen pozitif tam sayıya(dahil) kadar olan TEK sayıların toplamını bulma");
menu.Add("4-Girilen pozitif tam sayıya(dahil) kadar olan ÇİFT sayıların toplamını bulma");
menu.Add("5-Girilen pozitif tam sayıya(dahil) kadar olan mükemmel sayıları bulma");
menu.Add("Yapmak istediğiniz işlemin sıra numarasını giriniz: ");

string secim = string.Empty;
Uygulamalar uygulamalar = new();

try
{
    while (true)
    {
        Console.Clear();//Konsolu temizlemek icin kullanilacak
        foreach (var item in menu.GetRange(0, menu.Count - 1))
        {
            Console.WriteLine(item);
        }
        Console.Write(menu[^1]);

        secim = Console.ReadLine();

        Console.Clear();
        if (secim.Equals("1"))
        {

            VeriGirisleri.VeriAlUint(out uint yil, "Bir yıl giriniz: ");
            string mesaj = uygulamalar.ArtikYilMi(yil) ? "Artık Yıldır" : "Artık Yıl Değildir.";
            Console.WriteLine($"Girilen {yil} yılı bir {mesaj}");
        }
        else if (secim.Equals("2"))
        {
            VeriGirisleri.VeriAlUint(out uint pozitifSayi, "Bir pozitif tam sayı giriniz: ");
            Console.WriteLine($"Girilen {pozitifSayi} kadar olan sayıların toplamı : {uygulamalar.SayiyaKadarToplam(pozitifSayi)}");

        }
        else if (secim.Equals("3"))
        {
            VeriGirisleri.VeriAlUint(out uint pozitifSayi, "Bir pozitif tam sayı giriniz: ");
            Console.WriteLine($"Girilen {pozitifSayi} kadar olan TEK sayıların toplamı : {uygulamalar.SayiyaKadarTekToplam(pozitifSayi)}");
        }
        else if (secim.Equals("4"))
        {
            VeriGirisleri.VeriAlUint(out uint pozitifSayi, "Bir pozitif tam sayı giriniz: ");
            Console.WriteLine($"Girilen {pozitifSayi} kadar olan ÇİFT sayıların toplamı : {uygulamalar.SayiyaKadarCiftToplam(pozitifSayi)}");
        }
        else if (secim.Equals("5"))
        {
            Console.WriteLine(Aciklamalar.mukemmelSayi);
            Console.WriteLine();
            VeriGirisleri.VeriAlUlong(out ulong pozitifSayi, "Bir pozitif tam sayı giriniz: ");
            List<ulong> mukemmelSayilar = uygulamalar.SayiyaKadarMukemmelSayilar(pozitifSayi);
            Console.WriteLine($"Girilen {pozitifSayi} kadar olan mükemmel sayılar aşağıdadır:");
            if (mukemmelSayilar.Any())
            {
                foreach (var sayi in mukemmelSayilar)
                {
                    Console.WriteLine(sayi);
                }
            }
            else
            {
                Console.WriteLine("Mükemmel sayı bulunamadı!");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz bir tuşa bastınız!\nHerhangi bir işlem yapılamadı...");
        }

        Console.Write("Menuye dönmek ister misiniz(e/E):");
        secim = Console.ReadLine();
        if (!(secim.Equals("e") || secim.Equals("E")))
        {
            throw new Exception();
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Program sonlandırılıyor...");
}

