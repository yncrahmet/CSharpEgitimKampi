using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // () bir yapının metot olmasını parantezlerden anlarız.
            // Geriye değer döndürmeyen metotlar
            // Customer -> Listele, ekle, sil, güncelle
            // Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ahmet Yeniçeri");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Ahmet","Yeniçeri");
            //CustomerCard("Mehmet","Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int numberOne, int numberTwo, int numberThree)
            //{
            //    int result = numberOne + numberTwo + numberThree;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Ahmet Yeniçeri";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ahmet";
            //    string surName = "Yeniçeri";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCart());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " -- Başkent: " + capital + " -- Bayrak rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int numberOne, int numberTwo)
            //{
            //    int result = numberOne + numberTwo;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(45,32));
            //Console.WriteLine(Sum(23,74));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int examOne, int examTwo, int examThree)
            {
                int result = (examOne + examTwo + examThree) / 3;
                
                if(result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti. "+" Ortalama: "+result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi. " + " Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ahmet",87,65,76));
            Console.WriteLine(ExamResult("Ali",67,45,36));

            #endregion

            Console.Read();
        }
    }
}
