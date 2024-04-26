using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace method2;

class Program
{
    class Ogrenci
    {
        public string Isim { get; set; } // get set araştır 
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public int Numara { get; set; }
        public DateTime Dogumtarihi { get; set; }
        public string Cinsiyet { get; set; }


        // public TYPE Type { get; set; }   // prop yazınca böyle yapıyor
    }


    static string Sor(string soru)
    {
        Console.Write(soru);
        return Console.ReadLine();
    }


    static void Main(string[] args)
    {
        // Console.WriteLine("Yaşınızı Giriniz: ");
        // int yas = 0;
        //
        // if (int.TryParse(Console.ReadLine(), out yas) == false)
        // {
        //     Console.WriteLine("Rakam Girmelisin");
        // }
        


        // Console.WriteLine("Yaşınızı Giriniz: ");
        // int yas = 0;
        //
        // bool veriRakaMi = int.TryParse(Console.ReadLine(), out yas); // try parse ve out araştır 
        //
        // if (!veriRakaMi)  // ! folse diye sorar
        // {
        //     Console.WriteLine("Rakam Girmelisin Yoksa Olmaz");
        // }


        // Ogrenci ogrenci = new Ogrenci();
        // ogrenci.Isim = "Mehmet";
        // ogrenci.Soyad = "İyiyazıcı";
        // ogrenci.Yas = 21;
        //
        // Console.WriteLine(ogrenci.Isim);
        // Console.WriteLine(ogrenci.Soyad);
        // Console.WriteLine(ogrenci.Yas);


        List<Ogrenci> ogrenciler = new List<Ogrenci>();


        while (true)
        {
            Console.Clear();
            Console.WriteLine("Hoş Geldiniz");
            Console.WriteLine("1-Öğrencileri Listele");
            Console.WriteLine("2-Öğrenci Ekle");
            Console.WriteLine("3-Öğrenci Ara");
            Console.WriteLine("4-Öğrenci Düzenleme");
            Console.WriteLine("5-Öğrenci Silme");
            Console.WriteLine("6-Çıkış");

            int inputSecim = int.Parse(Sor("Seçimniz: "));


            if (inputSecim == 1)
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Listesi");
                foreach (Ogrenci ogrenci in ogrenciler)
                {
                    Console.WriteLine(
                        $" {ogrenci.Isim} {ogrenci.Soyad} - {ogrenci.Yas} - {ogrenci.Cinsiyet} - {ogrenci.Numara} - {ogrenci.Dogumtarihi}");
                }

                string inputFiltreleme = Sor("Cinsiyet Filtreleme: ");

                foreach (var ogrenci in ogrenciler)
                {
                    if (ogrenci.Cinsiyet.ToLower() == inputFiltreleme.ToLower())
                    {
                        Console.WriteLine(
                            $"{ogrenci.Isim} {ogrenci.Soyad} - {ogrenci.Yas} - {ogrenci.Cinsiyet} - {ogrenci.Numara} - {ogrenci.Dogumtarihi}");
                    }
                }

                Sor("Devam Etmek İçin Enter Bas");
            }
            else if (inputSecim == 3)
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Ara");
                string inputArananOgrenci = Sor("Adı: ");
                int inputArananOgrenciNo = int.Parse(Sor("Numarası: "));

                Ogrenci? arananOgrenci = null;
                foreach (var ogrenci in ogrenciler)
                {
                    if (inputArananOgrenci == ogrenci.Isim || inputArananOgrenciNo == ogrenci.Numara)
                    {
                        arananOgrenci = ogrenci;
                        break;
                    }
                }

                if (arananOgrenci != null)
                {
                    // ogrenciler.Remove(arananOgrenci); // silmek istiyorsam bu alanda bu kodu kullanmalıyım
                    Console.WriteLine("Öğrenciyi Buldum");
                    Console.WriteLine($"{arananOgrenci.Isim} {arananOgrenci.Soyad} {arananOgrenci.Yas} - {arananOgrenci.Cinsiyet} - {arananOgrenci.Numara} - {arananOgrenci.Dogumtarihi} ");
                }
                else
                {
                    Console.WriteLine("Böyle Bir Öğrenci Yok");
                }

                Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın");
                Console.ReadKey();
            }
            else if (inputSecim == 4)
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Düzenle");

                int inputDuzenle = int.Parse(Sor("Numarası: "));

                Ogrenci? duzenlenenOgrenci = null;


                foreach (var ogrenci in ogrenciler)
                {
                    if (inputDuzenle == ogrenci.Numara)
                    {
                        duzenlenenOgrenci = ogrenci;
                        break;
                    }
                }

                if (duzenlenenOgrenci != null)
                {
                    ogrenciler.Remove(duzenlenenOgrenci);
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Isim = Sor("Adınız: ");
                    ogrenci.Soyad = Sor("Soyadınız: ");
                    ogrenci.Yas = int.Parse(Sor("Yaşınız: "));
                    ogrenci.Cinsiyet = Sor("Cinsiyetiniz: ");
                    ogrenci.Numara = int.Parse(Sor("Numaranız: "));
                    ogrenci.Dogumtarihi = DateTime.Parse(Sor("Doğum Tarihi:  "));

                    ogrenciler.Add(ogrenci);
                }
                else
                {
                    Console.WriteLine("Öğrenci Bulunamadı");
                }

                Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın");
                Console.ReadKey();
            }
            else if (inputSecim == 5)
            {
                Console.WriteLine("Öğrenci Silme");

                int ogrenciSilme = int.Parse(Sor("Silmek İstediğiniz Kişinin Numarası: "));

                foreach (var ogrenci in ogrenciler)
                {
                    if (ogrenciSilme == ogrenci.Numara)
                    {
                        ogrenciler.Remove(ogrenci);
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Öğrenci Bulunamadı");
                    }

                    Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın");
                    Console.ReadKey();
                }
            }

            else if (inputSecim == 6)
            {
                break;
            }
            else
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Isim = Sor("Adın: ");
                ogrenci.Soyad = Sor("Soyadın: ");
                ogrenci.Yas = int.Parse(Sor("Yaşın: "));
                ogrenci.Numara = int.Parse(Sor("Numaran: "));
                ogrenci.Dogumtarihi = DateTime.Parse(Sor("Doğum Tarihiniz: "));
                ogrenci.Cinsiyet = Sor("Cinsiyetiniz: ");

                ogrenciler.Add(ogrenci);
            }
        }
    }
}