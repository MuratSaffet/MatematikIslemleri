using Ebob;
using OrtakYapilar;

List<string> menu = new();
menu.Add("Ebob Hesaplama");
menu.Add("1-Açıklamayı göster");
menu.Add("2-1. yönteme göre ebob hesaplama");
menu.Add("3-2. yönteme göre ebob hesaplama");
menu.Add("4-3. yönteme göre ebob hesaplama");
menu.Add("Yapmak istediğiniz işlemin sıra numarasını giriniz: ");

uint ebob = default;
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
            Console.WriteLine(Aciklamalar.ebobUygulamasi);
        }
        else if (secim.Equals("2"))
        {
            VeriGirisleri.VerilerAlUint(out List<uint> sayilar);
            ebob = uygulamalar.BirinciYontem(sayilar);
            Console.WriteLine("Girilen Sayılar:");
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Sayılarının ebobu : {ebob}");
        }
        else if (secim.Equals("3"))
        {
            VeriGirisleri.VeriAlUint(out uint sayi1, "Birinci pozitif tam sayıyı giriniz: ");
            VeriGirisleri.VeriAlUint(out uint sayi2, "İkinci pozitif tam sayıyı giriniz: ");
            uint buyuk = sayi1 < sayi2 ? sayi2 : sayi1;
            uint kucuk = sayi1 < sayi2 ? sayi1 : sayi2;

            ebob = uygulamalar.IkinciYontem(buyuk, kucuk);
            Console.WriteLine($"{buyuk} ve {kucuk} sayılarının ebobu : {ebob}");
        }
        else if (secim.Equals("4"))
        {
            VeriGirisleri.VeriAlUint(out uint sayi1, "Birinci pozitif tam sayıyı giriniz: ");
            VeriGirisleri.VeriAlUint(out uint sayi2, "İkinci pozitif tam sayıyı giriniz: ");
            uint buyuk = sayi1 < sayi2 ? sayi2 : sayi1;
            uint kucuk = sayi1 < sayi2 ? sayi1 : sayi2;
            ebob = uygulamalar.UcuncuYontem(buyuk, kucuk);
            Console.WriteLine($"{buyuk} ve {kucuk} sayılarının ebobu : {ebob}");
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

