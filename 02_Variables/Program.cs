using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("****** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatePrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatePrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("---- Elma birim fiyatı: ₺" + applePrice);
            //Console.WriteLine("---- Portakal birim fiyatı: ₺" + orangePrice);
            //Console.WriteLine("---- Çilek birim fiyatı: ₺" + strawberryPrice);
            //Console.WriteLine("---- Patates birim fiyatı: ₺" + potatoPrice);
            //Console.WriteLine("---- Domates birim fiyatı: ₺" + tomatePrice);

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomateGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomateGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomateTotalPrice = tomateGram * tomatePrice;

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Alınan ürün: Elma -- " + "Birim fiyat: ₺" + applePrice + 
            //    " -- Gramaj: " + appleGram + " -- Toplam tutar: ₺" + appleTotalPrice);

            //Console.WriteLine("Alınan ürün: Portakal -- " + "Birim fiyat: ₺" + orangePrice +
            //    " -- Gramaj: " + orangeGram + " -- Toplam tutar: ₺" + orangeTotalPrice);

            //Console.WriteLine("Alınan ürün: Çilek -- " + "Birim fiyat: ₺" + strawberryPrice +
            //    " -- Gramaj: " + strawberryGram + " -- Toplam tutar: ₺" + strawberryTotalPrice);

            //Console.WriteLine("Alınan ürün: Patates -- " + "Birim fiyat: ₺" + potatoPrice +
            //    " -- Gramaj: " + potatoGram + " -- Toplam tutar: ₺" + potatoTotalPrice);

            //Console.WriteLine("Alınan ürün: Domates -- " + "Birim fiyat: ₺" + tomatePrice +
            //    " -- Gramaj: " + tomateGram + " -- Toplam tutar: ₺" + tomateTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomateTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: ₺"+shoppingTotalPrice);

            #endregion

            #region Char Değişkenler

            //ABCDEFGH (TÜRKÇE KARAKTER YOK)
            //DEF.....
            //TOPLANTI SAAT 20:00'DE
            // char değişkenler '' arasında tanımlanır.

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " +
            //    passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC120

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairPrice * chairCount + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: ₺"+totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double examOne, examTwo, examThree, result;

            //Console.Write("Lütfen 1. sınav notunu girin: ");
            //examOne = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu girin: ");
            //examTwo = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu girin: ");
            //examThree = double.Parse(Console.ReadLine());

            //result = (examOne + examTwo + examThree) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
