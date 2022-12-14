using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basla --      1 ile girilen değer arasında sayı üretilir ve sayı tahmin oyunu başlar.

            Console.WriteLine("!!!  SAYI TAHMİN OYUNU   !!!");
            Console.WriteLine("lütfen 0 ile hangi değerler arasında sayı üretilmesini istediğinizi yazınız:");

            //Hangi değerler arasında aldığımızı yazma
            string aa = Console.ReadLine();
            string uretilenSayi = aa;

            //sayı mı kontrolü
            int numericValue;
            bool sayimi = int.TryParse(uretilenSayi, out numericValue);

            //eğer sayıysa değeri inte çevir
            int uretilenSayiINT = int.Parse(uretilenSayi);

            Console.WriteLine("İpucu istemek için 'E' yazabilirsiniz.");

            //sayı isimli değişkene random sayı atama
            Random random = new Random();
            int sayi = random.Next(1, (uretilenSayiINT + 1));


            // sayac olusturuldu
            int sayac = 0;

            // eğer sayı == 1 ise oyunu bitir
            if (sayi==1)
            {
                Console.WriteLine("sayı 1 olduğu için oyun bitti! (Hadi ama bu kolaydı)");
            }

            else
            {
                while (true)
                {
                    //oyun basladı
                    //tahmin girme
                    Console.Write("Bir sayı giriniz: ");
                    string tahminSTR = Console.ReadLine();

                    //girilen deger sayı mı
                    int numericValue2;
                    bool tahminKONTROL = int.TryParse(tahminSTR, out numericValue2);


                    //eğer sayıysa ===>
                    if (tahminKONTROL)
                    {

                        //sayıyı int e çevir
                        int tahminINT = int.Parse(tahminSTR);

                        if (tahminINT > sayi)           //tahmin sayıdan büyükse yazdır, ve sayaca bir ekle
                        {
                            Console.WriteLine("Sayıyı küçültün   <");
                            sayac++;

                        }
                        else if (tahminINT < sayi)      //tahmin sayıdan küçükse yazdır, ve sayaca bir ekle
                        {
                            Console.WriteLine("Sayıyı büyültün   >");
                            sayac++;

                        }
                        else if (tahminINT == sayi)     //tahmin sayıya eşitse
                        {
                            sayac++;
                            Console.WriteLine($"Tebrikler! Oyunu {sayac} 'inci denemede kazandınız.");
                            break;
                        }

                    }

                    //eğer sayı değilse ===>
                    else if (tahminSTR == "E")
                    {
                        if (sayi % 2 == 0)
                        {
                            Console.WriteLine("Sayı 2 rakamına tam bölünür");
                        }
                        if (sayi % 3 == 0)
                        {
                            Console.WriteLine("Sayı 3 rakamına tam bölünür");
                        }
                        if (sayi % 5 == 0)
                        {
                            Console.WriteLine("Sayı 5 rakamına tam bölünür");
                        }
                        if (sayi % 7 == 0)
                        {
                            Console.WriteLine("Sayı 5 rakamına tam bölünür");
                        }

                        //asal sayıysa
                        int sayacx = 0;

                        for (int i = 2; i < sayi; i++)
                        {
                            if (sayi % i == 0)
                            {
                                sayacx++;
                            }
                        }

                        if (sayacx == 0)
                        {
                            Console.WriteLine("sayı asal sayıdır!");
                        }
                    }

                }

            }





            //bitti
            Console.ReadLine();
        }
    }
}
