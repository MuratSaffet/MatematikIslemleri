using AlanCevreHesaplari;
using OrtakYapilar;

List<string> menu = new();
menu.Add("Aşağıdaki geometrik şekiller ile ilgili işlemler yapılabilmektedir");
menu.Add("1-Kürenin alanını hesaplama");
menu.Add("2-Kürenin hacmini hesaplama");
menu.Add("3-Dairenin alanını hesaplama");
menu.Add("4-Dairenin çevresini hesaplama");
menu.Add("Yapmak istediğiniz işlemin sıra numarasını giriniz: ");

Uygulamalar uygulamalar = new();
string secim = string.Empty;

try
{
    while (true)
    {
        Console.Clear();
        foreach (var item in menu.GetRange(0, menu.Count - 1))
        {
            Console.WriteLine(item);
        }
        Console.Write(menu[^1]);
        secim = Console.ReadLine();

        Console.Clear();
        if (secim.Equals("1"))
        {
            VeriGirisleri.VeriAlDouble(out double yaricap, "Kürenin yarıçapını giriniz: ");
            Console.WriteLine($"Kürenin alanı: {uygulamalar.KureAlani(yaricap)}");
        }
        else if (secim.Equals("2"))
        {
            VeriGirisleri.VeriAlDouble(out double yaricap, "Kürenin yarıçapını giriniz: ");
            Console.WriteLine($"Kürenin hacmi: {uygulamalar.KureHacmi(yaricap)}");
        }
        else if (secim.Equals("3"))
        {
            VeriGirisleri.VeriAlDouble(out double yaricap, "Dairenin yarıçapını giriniz: ");
            Console.WriteLine($"Dairenin alanı: {uygulamalar.DaireninAlani(yaricap)}");
        }
        else if (secim.Equals("4"))
        {
            VeriGirisleri.VeriAlDouble(out double yaricap, "Dairenin yarıçapını giriniz: ");
            Console.WriteLine($"Dairenin çevresi: {uygulamalar.DaireninCevresi(yaricap)}");
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