using System;

namespace MyApplication
{
    interface UserName
    {
        void AdSoyad();


        class Name : UserName
        {
            public void AdSoyad()
            {
                string name;
                Console.WriteLine("Adınızı Giriniz:");
                name = Console.ReadLine();
                Console.WriteLine("Merhaba " + " " + name);
                Console.WriteLine("Devam Etmek İçin 'Enter' tuşuna basınız");
                Console.ReadKey();
            }
        }
        class FoodName : Name
        {
            public void foodname()
            {
                string foodname;
                Console.WriteLine("Yemeğin Adını Giriniz :");
                foodname = Console.ReadLine();
                Console.WriteLine("Yapılacak Yemeğin Adı: " + foodname);

            }
        }    

        class Program
        {
            static void Main(string[] args)
            {
                string matarial;

                Name name = new Name();
                name.AdSoyad();

                FoodName foodname = new FoodName();
                foodname.foodname();

                Console.WriteLine();
                Console.WriteLine("lütfen malzemeleri yazarken araya virgül koyunuz");
                Console.WriteLine();

                Console.WriteLine("Malzemeleri Giriniz :");
                matarial = Console.ReadLine();



                Console.WriteLine("Yemek İçin Gerekli malzemeler: " + matarial);
                Console.ReadLine();
                Console.ReadKey();

            }
        }
    }
}