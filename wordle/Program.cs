class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>
        {
            "kuyumcu", "araba", "kamera", "kalem", "kedi", "karpuz", "kırmızı", "kıyafet", "kütüphane", "kış"
        };
         

        Console.WriteLine("Oyuna Başla");
        string cevap = list[new Random().Next(list.Count)];
        Console.WriteLine("1-Başlamak İçin");
        string girilenDeger = Console.ReadLine();
        int girilenSayi = int.Parse(girilenDeger);
        Console.Clear();
        if (girilenSayi == 1)
        {
            string tahmin = " ";
            
            while (tahmin != cevap)
            {
                Console.WriteLine("\nTahmin Girin");
                tahmin = Console.ReadLine();
                string sonuc = "";
                for (int i = 0; i < tahmin.Length; i++)
                {
                    
                    if (cevap.Contains(tahmin[i]))
                    {
                        if (cevap[i] == tahmin[i])
                        {
                            sonuc += $"\u001b[32m{tahmin[i]}\u001b[0m"; 
                        }
                        else
                        {
                            sonuc += $"\u001b[33m{tahmin[i]}\u001b[0m"; 
                        }
                    }
                    else
                    {
                        sonuc += "_";
                    }

                }
                Console.WriteLine(sonuc);
                
            } 
        }
    }
}