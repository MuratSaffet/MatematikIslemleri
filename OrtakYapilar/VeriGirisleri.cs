namespace OrtakYapilar
{
    public static class VeriGirisleri
    {
        /// <summary>
        /// Bir tam sayı almak için kullanılmaktadır. Kullanıcı tam sayı girmezse hata verir.
        /// </summary>
        /// <param name="sayi">Kullanıcıdan alınacak tam sayı</param>
        /// <param name="mesaj">Kullanıcıya gösterilecek mesaj</param>
        public static void VeriAlInt(out int sayi, string mesaj= "Bir tam sayı giriniz: ")
        {
            try
            {
                sayi = default;
                Console.Write(mesaj);
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(OrtakYapilarMesajlar.ConvertToInt32Hatasi);
                throw;
            }
        }

        /// <summary>
        /// Bir pozitif tam sayı almak için kullanılmaktadır. Kullanıcı pozitif tam sayı girmezse hata verir.
        /// </summary>
        /// <param name="sayi">Kullanıcıdan alınacak pozitif tam sayı</param>
        /// <param name="mesaj">Kullanıcıya gösterilecek mesaj</param>
        public static void VeriAlUint(out uint sayi, string mesaj = "Bir pozitif tam sayı giriniz: ")
        {
            try
            {
                sayi = default;
                Console.Write(mesaj);
                sayi = Convert.ToUInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(OrtakYapilarMesajlar.ConvertToUInt32Hatasi);
                throw;
            }
        }

        public static void VerilerAlUint(out List<uint> sayilar, string mesaj="Pozitif bir tam sayı giriniz:")
        {
            sayilar = new();
            try
            {
                Console.WriteLine("Bir pozitif tam sayı girilmediğinde veri alma bırakılacaktır...");
                while (true)
                {
                    Console.Write(mesaj);
                    sayilar.Add(Convert.ToUInt32(Console.ReadLine()));

                }
            }
            catch (Exception)
            {
                if(sayilar.Any())
                    Console.WriteLine(OrtakYapilarMesajlar.VeriGirisiTamam);
                else
                {
                    Console.WriteLine(OrtakYapilarMesajlar.ConvertToUInt32Hatasi);
                    throw;
                }
            }
        }
    }
}
