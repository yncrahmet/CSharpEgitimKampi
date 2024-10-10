using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü
            //Döngüler 1+2+3+4+5+6
            // 3 + 3 = 6 + 4 = 10 + 5 = 15 + 6 = 21

            // For(baslangic deger, bitis degeri, artis ya da azalis

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <=50 ; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adeti giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşacın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);

            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }   
            //}

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //while(şart)
            //{
            //    işlemler
            //}

            //int i = 1;

            //while(i <= 10)
            //{
            //    Console.WriteLine("Merhaba döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu 

            // Klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan
            // kodu yazınız.

            //Console.Write("Üç basamaklı sayı giriniz: ");
            //int enteredNumber = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds, sum;

            //ones = enteredNumber % 10;
            //tens = (enteredNumber % 100) / 10;
            //hundreds = enteredNumber / 100; //4.56 -> 4


            //Console.WriteLine(ones + " - " + tens + " - " + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);

            #endregion

            Console.Read();

        }
    }
}
