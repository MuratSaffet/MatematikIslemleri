using BasitAlgoritmalar;
using OrtakYapilar;
using System.Security;

List<string> menu = new();
menu.Add("Basit Algoritmalar");
menu.Add("1-Artık Yıl Hesaplama");
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
        else if (secim.Equals("4"))
        {

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

