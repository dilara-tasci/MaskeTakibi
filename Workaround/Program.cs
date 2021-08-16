using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vatandas vatandas = new Vatandas();
            SelamVer();
            SelamVer("Dilara");
            int sonuc = Topla(3, 5);
            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        static void SelamVer(string name = "Yeni Kullanıcı")
        {
            Console.WriteLine("Merhaba " + name);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam = " + sonuc);
            return sonuc;
        }
    }

    class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
