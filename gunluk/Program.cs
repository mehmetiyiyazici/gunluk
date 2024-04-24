namespace gunluk;

class Gunluk
{
    
    public string Gunluke { get; set; }
    public DateTime Tarih { get; set; }
    static string Sor(string soru)
    {
        Console.Write(soru);
        return Console.ReadLine();
    }
    
    
    static void Main(string[] args)
    {
        List<Gunluk> gunluk = new List<Gunluk>();
        
        while (true)
        {
            string[] kullanicilar = ["Mehmet81"];
            string[] sifreler = ["Mehmet123"];
        
            Console.WriteLine("Günlüğe Hoşgeldiniz");

            string inputKullaniciAdi = Sor("Kullanıcı Adınızı Giriniz: ");
            string inputSifre = Sor("Şifrenizi Giriniz: ");
            

            bool kullaniciVarMi = false;
            string bulunanKullaniciAdi = "";

            for (int i = 0; i < kullanicilar.Length; i++)
            {
                if (kullanicilar[i] == inputKullaniciAdi && sifreler[i] == inputSifre)
                {
                    kullaniciVarMi = true;
                    bulunanKullaniciAdi = kullanicilar[i];
                    break;
                }
            }
            if (kullaniciVarMi)
            {
                Console.WriteLine($"Hoş geldiniz {bulunanKullaniciAdi}");
            }
            else
            {
                Console.WriteLine("Kullanıcı Bulunamadı");
            }

            if (kullaniciVarMi)
            {
                while (true)
                {
                    Console.WriteLine("1-Günlüğe Ekleme Yap");
                    Console.WriteLine("2-Günlüğü Görüntüle");
                    Console.WriteLine("3-Çıkış");

                    int inputSecim = int.Parse(Sor("Seçimniz: "));
            

                    if (inputSecim == 1)
                    {
                        Gunluk yazı = new Gunluk();
                    
                        yazı.Tarih = DateTime.Now;
                        yazı.Gunluke = Sor("Ekleme Yapın: ");
                
                        gunluk.Add(yazı);
                    }
                    else if (inputSecim == 3)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        foreach (var yazı in gunluk)
                        {
                            Console.WriteLine($"{yazı.Tarih} \n{yazı.Gunluke}");
                        }
                    }
                    Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın");
                    Console.ReadKey();
                }
            }
        }
    }
}