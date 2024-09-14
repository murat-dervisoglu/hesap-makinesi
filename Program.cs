using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiCevreAlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            baslangic:

            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1-Hesap makinesi \n2-Alan / çevre hesaplama");
            int islem = Convert.ToInt32(Console.ReadLine());
            if (islem == 1)
            {
                Console.Write("Sayıyı girin: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("işleminizi girin (+,-,*,/,karekök, üs)");
                string islem2 = Convert.ToString(Console.ReadLine());
                if (islem2 == "+")
                {
                    Console.Write("ikinci sayınızı girin: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());
                    int sonuc = sayi1 + sayi2;
                    Console.WriteLine($"İşlemin sonucu: {sayi1} + {sayi2} = {sonuc}");
                }

                else if (islem2 == "-")
                {
                    Console.Write("ikinci sayınızı girin: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());
                    int sonuc = sayi1 - sayi2;
                    Console.WriteLine($"İşlemin sonucu: {sayi1} - {sayi2} = {sonuc}");
                }

                else if (islem2 == "*")
                {
                    Console.Write("ikinci sayınızı girin: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());
                    int sonuc = sayi1 * sayi2;
                    Console.WriteLine($"işlemizin sonucu: {sayi1} * {sayi2} = {sonuc}");
                }

                else if (islem2 == "/")
                {
                    Console.Write("ikinci sayınızı girin: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());
                    int sonuc = sayi1 / sayi2;
                    Console.WriteLine($"işlemizin sonucu: {sayi1} / {sayi2}  =  {sonuc}");
                }

                else if (islem2 == "karekök")
                {
                    double sonuc = Math.Sqrt(sayi1);
                    Console.WriteLine($"işlemizin sonucu = {sonuc}");
                }

                else if (islem2 == "üs")
                {
                    Console.Write("Üs değerini girin: ");
                    double us = Convert.ToDouble(Console.ReadLine());
                    double sonuc = Math.Pow(sayi1, us);
                    Console.WriteLine($"işlemizin sonucu = {sonuc}");
                }
                else
                {
                    Console.WriteLine("hatalı değer girdiniz.");
                    goto baslangic;
                }
            }

            else if (islem == 2)
            {
                Console.WriteLine("işlem yapmak istediğiniz geometrik şeklin numarasını girin");
                Console.WriteLine("1- Daire / 2- Üçgen / 3- Kare / 4- Dikdortgen / 5- Yamuk / 6- Paralel kenar");
                int sekil = Convert.ToInt32(Console.ReadLine());
                if (sekil == 1)
                {
                    Console.WriteLine("bulmak istediğiniz sonucu girin");
                    Console.WriteLine("1- Çevre / 2 - Alan");
                    int istenen = Convert.ToInt32(Console.ReadLine());
                    if (istenen == 1)
                    {
                        Console.Write("yarıçapı girin: ");
                        int r = Convert.ToInt32(Console.ReadLine());
                        Double sonuc = 2 * pi * r;
                        Console.WriteLine($"işlemin sonucu 2 * {pi} * {r} = {sonuc}");
                    }
                    else if (istenen == 2)
                    {
                        Console.Write("yarıçapı girin: ");
                        int r = Convert.ToInt32(Console.ReadLine());
                        Double sonuc = pi * r * r;
                        Console.WriteLine($"işlemin sonucu: {pi} * {r} ** 2 = {sonuc}");
                    }

                }
                else if (sekil == 2)
                {
                    Console.WriteLine("bulmak istediğiniz sonucu girin");
                    Console.WriteLine("1- Çevre / 2 - Alan");
                    int istenen = Convert.ToInt32(Console.ReadLine());
                    if (istenen == 1)
                    {
                        Console.Write("ilk kenarı girin: ");
                        int kenar1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("ikinci kenarı girin: ");
                        int kenar2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("üçüncü kenarı girin: ");
                        int kenar3 = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = kenar1 + kenar2 + kenar3;
                        Console.WriteLine($"işlemin sonucu {kenar1} + {kenar2} + {kenar3} = {sonuc}");
                    }
                    else if (istenen == 2)
                    {
                        Console.Write("Taban alanını girin: ");
                        int taban = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Yüksekliği girin: ");
                        int yukseklik = Convert.ToInt32(Console.ReadLine());
                        Double sonuc = (taban * yukseklik) / 2;
                        Console.WriteLine($"işlemin sonucu: {taban} * {yukseklik} / 2 = {sonuc}");
                    }
                }

                else if (sekil == 3)
                {
                    Console.WriteLine("bulmak istediğiniz sonucu girin");
                    Console.WriteLine("1- Çevre / 2 - Alan");
                    int istenen = Convert.ToInt32(Console.ReadLine());
                    if (istenen == 1)
                    {
                        Console.Write("bir kenarı girin: ");
                        int kenar = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = kenar * 4;
                        Console.WriteLine($"işlemin sonucu {kenar} * 4 = {sonuc}");
                    }
                    else if (istenen == 2)
                    {
                        Console.Write("bir kenarı girin: ");
                        int kenar = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = kenar * kenar;
                        Console.WriteLine($"işlemin sonucu {kenar} * {kenar} = {sonuc}");
                    }
                }

                else if (sekil == 4)
                {
                    Console.WriteLine("bulmak istediğiniz sonucu girin");
                    Console.WriteLine("1- Çevre / 2 - Alan");
                    int istenen = Convert.ToInt32(Console.ReadLine());
                    if (istenen == 1)
                    {
                        Console.Write("ilk kenarı girin: ");
                        int kenar1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("ikinci kenarı girin: ");
                        int kenar2 = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = (kenar1 * 2) + (kenar2 * 2);
                        Console.WriteLine($"işlemin sonucu ({kenar1} * 2) + ({kenar2} * 2) = {sonuc}");
                    }
                    else if (istenen == 2)
                    {
                        Console.Write("ilk kenarı girin: ");
                        int kenar1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("ikinci kenarı girin: ");
                        int kenar2 = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = (kenar1 * kenar2);
                        Console.WriteLine($"işlemin sonucu ({kenar1} * {kenar2} = {sonuc}");
                    }

                }

                else if (sekil == 5)
                {
                    Console.WriteLine("bulmak istediğiniz sonucu girin");
                    Console.WriteLine("1- Çevre / 2 - Alan");
                    int istenen = Convert.ToInt32(Console.ReadLine());
                    if (istenen == 1)
                    {
                        Console.Write("ilk kenarı girin: ");
                        int kenar1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("ikinci kenarı girin: ");
                        int kenar2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("üçüncü kenarı girin: ");
                        int kenar3 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("dördüncü kenarı girin: ");
                        int kenar4 = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = kenar1 + kenar2 + kenar3 + kenar4;
                        Console.WriteLine($"işlemin sonucu {kenar1} + {kenar2} + {kenar3} + {kenar4} = {sonuc}");
                    }
                    else if (istenen == 2)
                    {
                        Console.Write("alt tabanı girin: ");
                        int alt = Convert.ToInt32(Console.ReadLine());

                        Console.Write("üst tabanı girin: ");
                        int ust = Convert.ToInt32(Console.ReadLine());

                        Console.Write("yüksekliği girin: ");
                        int h = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = (alt + ust) * h / 2;
                        Console.WriteLine($"işlemin sonucu ({alt} + {ust}) * {h} / 2 = {sonuc}");
                    }
                }

                else if (sekil == 6)
                {
                    Console.WriteLine("bulmak istediğiniz sonucu girin");
                    Console.WriteLine("1- Çevre / 2 - Alan");
                    int istenen = Convert.ToInt32(Console.ReadLine());
                    if (istenen == 1)
                    {
                        Console.Write("ilk kenarı girin: ");
                        int kenar1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("ikinci kenarı girin: ");
                        int kenar2 = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = (kenar1 * 2) + (kenar2 * 2);
                        Console.WriteLine($"işlemin sonucu ({kenar1} * 2) + ({kenar2} * 2) = {sonuc}");
                    }
                    else if (istenen == 2)
                    {
                        Console.Write("bir kenar uzunluğu girin girin: ");
                        int kenar = Convert.ToInt32(Console.ReadLine());

                        Console.Write("girdiğiniz kenara ait yüksekliği girin: ");
                        int h = Convert.ToInt32(Console.ReadLine());

                        Double sonuc = kenar * h;
                        Console.WriteLine($"işlemin sonucu: {kenar} * {h} = {sonuc}");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("başka bir işlem yapmak istiyor musunuz? ");
            Console.WriteLine("1- Evet \n2- Hayır");
            string cevap = Console.ReadLine();
            if (cevap == "1")
            {
                goto baslangic;
            }
            else if (cevap == "2") 
            {
                Console.ReadLine();
            }
            
        }
    }
}
