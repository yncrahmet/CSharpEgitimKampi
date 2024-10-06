using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd") {
            //    Console.WriteLine("Şifre Doğru");
            //} else {
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkanti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı!");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi!");
            //}

            //int number;

            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else {
            //    Console.WriteLine("Sayı hatalı.");
            //}

            //int examOne, examTwo, examThree, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //examOne = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //examTwo = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //examThree = int.Parse(Console.ReadLine());

            //average = (examOne + examTwo + examThree) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat.";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta.";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi.";
            //}
            //if (average > 84)
            //{
            //    result = "Çok iyi.";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapın: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil.");    
            //}

            //Console.Write("Lütfen kullanıcı adını girin: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez.");
            //} else
            //{
            //    Console.Write("hoşgeldiniz.");
            //}

            #endregion

            #region Mod işlemleri 

            //int number;

            //number = 26;

            //// number'ın 5'e bölümünden kalan
            //int result = number % 5;

            //Console.Write(result);

            //Console.Write("Lütfen bir sayı girin: ");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı girin: ");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int result = numberOne % numberTwo;

            //Console.Write(numberOne + " sayısının " + numberTwo + " sayısına bölümünden kalan: "+result); 

            //Console.Write("Lütfen sayıyı girin: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir.");
            //} else
            //{
            //    Console.Write("sayı tektir.");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları

            //Console.Write("Takımın baş harfini girin: ");
            //char team = char.Parse(Console.ReadLine());

            //if (team == 'H' | team == 'h')
            //{
            //    Console.Write("Hatayspor");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team == 'B' | team == 'b')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 'T' | team == 't')
            //{
            //    Console.Write("Trabzonspor");
            //}
            //else
            //{
            //    Console.Write("Böyle bir takım bulunamadı.");
            //}

            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("----------------------------------------");

            //string menuItem;

            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Köri Soslu Tavuk");
            //    Console.WriteLine("2 - Kızartma Tabağı");
            //    Console.WriteLine("3 - Fasulye Pilav");
            //    Console.WriteLine("4 - Fırında Somon");
            //    Console.WriteLine("5 - Patlıcan Musakka");
            //    Console.WriteLine("------------ Ana Yemekler ------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Mercimek Çorbası");
            //    Console.WriteLine("2 - Ezogelin Çorba");
            //    Console.WriteLine("------------ Çorbalar ------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Akdeniz Pizza");
            //    Console.WriteLine("2 - Margaritha");
            //    Console.WriteLine("3 - Tavuklu Pizza");
            //    Console.WriteLine("------------ Pizzalar ------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("3 - Su");
            //    Console.WriteLine("------------ İçecekler ------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Triliçe");
            //    Console.WriteLine("2 - Kazandibi");
            //    Console.WriteLine("3 - Sütlaç");
            //    Console.WriteLine("------------ Tatlılar ------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:
            //        Console.Write("Hatalı veri girişi!");
            //        break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int numberOne, numberTwo, result;
            //char symbol;

            //Console.Write("Birinci sayıyı girin: ");
            //numberOne = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı girin: ");
            //numberTwo = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi girin: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = numberOne + numberTwo;
            //        Console.WriteLine("Toplam: "+result);
            //    break;

            //    case '-':
            //        result = numberOne - numberTwo;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = numberOne * numberTwo;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = numberOne / numberTwo;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //    default:
            //        Console.WriteLine("Geçersiz işlem seçildi!");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
