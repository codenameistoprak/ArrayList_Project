using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D2.ArrayListOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerlerListesi = new ArrayList();

            do
            {
                Console.Clear();
                Console.WriteLine("MENÜ");
                Console.WriteLine("***********************");
                Console.WriteLine("1- Değer Ekle");
                Console.WriteLine("2- Değer listele");
                Console.WriteLine("3- Değer Ara");
                Console.WriteLine("4- Değer Düzenle");
                Console.WriteLine("5- Değer Sil");
                Console.WriteLine("6- Uygulama Çıkış");
                Console.WriteLine("***********************");
                Console.Write("Seçiniz:");

                kullaniciSecim = Console.ReadLine();
               
                switch (kullaniciSecim)
                {
                    case "1":
                        Console.WriteLine("Eklemek istediğiniz değeri giriniz:");
                        string kullaniciDeger = Console.ReadLine();
                        degerlerListesi.Add(kullaniciDeger);
                        Console.WriteLine("Eklemek istediğiniz değer başarılı bir şekilde girildi.");
                        System.Threading.Thread.Sleep(500);

                        break;

                    case "2":
                        for (int i = 0; i < degerlerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Deger = {1}", i, degerlerListesi[i]);

                        }
                        Console.WriteLine("devam etmek için tuşa basınız");
                        Console.ReadLine();
                        
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz: ");
                        string aranandeger = Console.ReadLine();
                        bool kontrol = degerlerListesi.Contains(aranandeger);
                        if (kontrol)
                        {
                            Console.WriteLine("listede bulunmaktadır");
                            int bulunanIndex = degerlerListesi.IndexOf(aranandeger);
                            string bulunanDeger = degerlerListesi[bulunanIndex].ToString();
                            Console.WriteLine("Index sırası : {0}  Deger: {1}", bulunanIndex, bulunanDeger);

                        }
                        else
                        {
                            Console.WriteLine("Listede bulunmamaktadır.Listeye ekleyelim mi?(cevabınız evet ise e'ye" +
                                " \n tıklayınız değilse " +
                                "herhangi bir tuşa basınız.)");
                            string cevap = Console.ReadLine();
                            if (cevap == "e")
                            {
                                degerlerListesi.Add(aranandeger);
                                Console.WriteLine("Listeye eklendi.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız.");
                        Console.ReadLine();

                        break;
                    case "4":
                        Console.WriteLine("Düzenlemek istediğiniz değeri giriniz:");
                        string degerD = Console.ReadLine();
                       
                        if (degerlerListesi.Contains(degerD))
                        {
                            Console.WriteLine("Yeni değeri giriniz: ");
                            string yeniDeger = Console.ReadLine();
                            int IndexDegeri = degerlerListesi.IndexOf(degerD);
                            degerlerListesi[IndexDegeri] = yeniDeger;
                            Console.WriteLine("İşlem gerçekleştirildi.");
                        }
                        else
                        {
                            Console.WriteLine("Listede bu değer bulunmamaktadır.");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "5":
                       Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz? (E/H)");
                        string cevap1 = Console.ReadLine();
                        if (cevap1.ToUpper() == "E")
                        {
                            degerlerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediğiniz değeri giriniz:");
                            string silinen = Console.ReadLine();

                            if (degerlerListesi.Contains(silinen))
                            {
                                degerlerListesi.Remove(silinen);
                                Console.WriteLine("İşlem başarı ile gerçekleştirildi.");

                            }
                            else
                            {
                                Console.WriteLine("Listede bulunmamaktadır.");
                            }
                            
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "6":

                        break;

                    default:
                        break;
                        
                }
            } while (kullaniciSecim != "6");


            }

        }
    }

