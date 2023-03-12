using Ekok;
using OrtakYapilar;

List<string> menu = new();
menu.Add("Ekok hesaplama uygulaması");

Uygulamalar uygulamalar = new();
string secim = string.Empty;

try
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine(menu[0]);

        VeriGirisleri.VerilerAlUint(out List<uint> sayilar);
        
        Console.WriteLine("Girilen Sayılar:");
        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Sayılarının ekoku : {uygulamalar.Ekok(sayilar)}");

        Console.Write("Uygulamadan çıkmak ister misiniz(e/E):");
        secim = Console.ReadLine();
        if (secim.Equals("e") || secim.Equals("E"))
        {
            throw new Exception();
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Program sonlandırılıyor...");
}