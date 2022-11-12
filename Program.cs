namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decimal sayi1 = 26, sayi2 = 32;
            //decimal sayi1 = 32, sayi2 = 26;
            //decimal sonuc = sayi1 - sayi2;

            //decimal sayi6 = Abs(sonuc);
            //Abs(sonuc);

            //decimal sayi5 = Math.Abs(sonuc);
            //Console.WriteLine();

            //Console.ReadLine();

            //EksiKontrol(sonuc);

            //Topla(2, 17);
            //Topla();

            //int sayi1 = 0;
            ////int sayi3 = 0;

            //if(sayi1 == 3)
            //{
            //    int sayi3 = 0;
            //    //int sayi3 = 0;
            //}

            //for (int i = 0; i < 30; i++)
            //{

            //    //int sayi3 = i;
            //}

            //int sonuc = Topla(2, 17);
            //int sonuc2 = Topla(21, 5);

            //Merhaba();
            //Merhaba(2);

            //int sonuc = Merhaba2();
            //int sonuc2 = Merhaba2(3);

            IsimYaz("Ahmet");
            Kare(20);
            Toplam(10, 20);

            //"Merhaba Ahmet. Yaşınız: 20";
            IsimVeYasYaz("Ahmet", 20);

            //"Merhaba Ahmet Yaşınız 30" 
            //3 boşluk var

            BoslukSay1("Merhaba Ahmet Yaşınız 30");
            BoslukSay2("Merhaba Ahmet Yaşınız 30");
        }

        static void BoslukSay1(string deger)
        {
            int bosluk = 0;
            foreach (var karakter in deger)
            {
                if (karakter == ' ')
                    bosluk++;
            }

            Console.WriteLine(bosluk + " boşluk var");
        }

        static void BoslukSay2(string deger)
        {
            var sonuc = deger.Split(' ');
            Console.WriteLine((sonuc.Length -1) + " boşluk var");
        }

        static void IsimVeYasYaz(string isim, int yas)
        {
            Console.WriteLine("Merhaba " + isim + ". Yaşınız: " + yas);
        }

        static void IsimYaz(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static void Kare(int sayi)
        {
            Console.WriteLine(sayi * sayi);
        }

        static void Toplam(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        static void Merhaba()
        {
            //kodlar
        }

        static void Merhaba(int sayi1)
        {
            //kodlar
        }

        static int Merhaba2()
        {
            return 1;
        }

        static int Merhaba2(int sayi1)
        {
            return sayi1 * 2;
        }

        //static void EksiKontrol(decimal sonuc)
        //{
        //    //if (sonuc < 0)
        //    //    Console.WriteLine(sonuc * -1);
        //    ////else if (sonuc == 0)
        //    ////    Console.WriteLine("jaskdja");
        //    //else
        //        Console.WriteLine(sonuc);
        //}

        //static void Abs(decimal sayi)
        //{
        //    Console.WriteLine(sayi < 0 ? (sayi * -1) : sayi);
        //}

        //static void Topla()
        //{
        //    int sayi1 = 0, sayi2 = 0;
        //    sayi1 = Convert.ToInt32(Console.ReadLine());
        //    sayi2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(sayi1 + sayi2);
        //}

        //static int Topla(int sayi1, int sayi2)
        //{
        //    //Console.WriteLine(sayi1 + sayi2);
        //    return sayi1 + sayi2;
        //}
    }
}