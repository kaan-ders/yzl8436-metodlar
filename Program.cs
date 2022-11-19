namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                //if (item == "-h")
                //{
                //    Console.WriteLine("Yarım çağır");
                //}
                Console.WriteLine(item);
            }

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

            //IsimYaz("Ahmet");
            //Kare(20);
            //Toplam(10, 20);

            ////"Merhaba Ahmet. Yaşınız: 20";
            //IsimVeYasYaz("Ahmet", 20);

            ////"Merhaba Ahmet Yaşınız 30" 
            ////3 boşluk var

            //BoslukSay1("Merhaba Ahmet Yaşınız 30");
            //BoslukSay2("Merhaba Ahmet Yaşınız 30");

            //TekCiftSayiSayar(27563);


            //string yazi = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\n";
            //100
            //"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lore..."

            //string kisaYazi = KarakterKisaltma(yazi, 50);
            //Console.WriteLine(kisaYazi);

            //"Ahmet" -> Sesli harfler: 2, diğer karakterler: 3
            //SesliHarfSayaci1("Ahmet");
            //SesliHarfSayaci2("Ahmet");

            //3, 2 -> 9
            //8, 4

            //20
            //0 2 4 6 8 10 12 14 16 18 20
            //var sonuc = CiftSayilar(200);
            //Console.WriteLine(sonuc);

            //merhaba bugün nasılsınız? umarım iyisinizdir
            //5

            //int kelime = KelimeSayaci1("merhaba bugün nasılsınız? umarım iyisinizdir");
            //kelime = KelimeSayaci2("merhaba bugün nasılsınız? umarım iyisinizdir");

            //email örnekleri
            //---------------------

            //ahmet@bilgeadam.com
            //bilgeadam.com

            //string domain = MailDomain1("ahmet@bilgeadam.com");
            //domain = MailDomain2("ahmet@bilgeadam.com");

            //1456
            //4

            //var sonuc = BasamakSayisi(256748494);

            //celcius to fahrenheit
            //30 -> 128

            //var f = CelciusToFahrenHeit(20);

            //ahmet@gmail.com -> true
            //ahmet.gmail -> false

            //true, false
            //var sonuc = CheckMailAddress("ahmet@gmail.com");
            //sonuc = CheckMailAddress("ahmet.gmail");

            //13.11.2022 -> Pazar

            //TarihinGunu(new DateTime(1989, 8, 15));

            //13.11.2022 - 08.11.2020 -> 545

            //IkiTarihFarki(DateTime.Now.AddYears(1), DateTime.Now);

            //30 -> bugünden 30 gün sonrası Pazartesi
            //XGunSonrasi(30);

            //AHmet mandıralı
            //ahmet.mandirali

            //EmaileUydurma("Aümeş mandıralı");
            ////EmaileUydurma("Fatımş üşÖÇÇÇ");
            //EmaileUydurma("Fatımş üşÖÇÇÇ", new string[] {"i", "ö"});
            //EmaileUydurma(3);

            //string yazi = "asdasdasd";
            //int sonuc = SonucUret(out yazi);

            //int sonuc = 0;
            //bool cevirilebilirMi = int.TryParse("12314", out sonuc);
            //int sayi = int.Parse("asdasdasdas");

            //int degisken = 3;
            //SonucUret(ref degisken);

            //Console.WriteLine(degisken);

            //SonucUret(new string[] { "a", "1", "dsf", "dvgsx" });
            //SonucUret("a", "1", "dsf", "dvgsx", "asdas", "dsfsdgfg", "dfhgdf");
        }

        //static void SonucUret(string[] parametreler)
        //{
        //    foreach (var item in parametreler)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        static void SonucUret(params string[] parametreler)
        {
            foreach (var item in parametreler)
            {
                Console.WriteLine(item);
            }
        }

        static void SonucUret(int param)
        {
            param = 123;
        }

        static void SonucUret(ref int param)
        {
            param = 123;
        }

        static int SonucUret(out string yazi)
        {
            int sonuc = 0;
            yazi = "asdasdasd";

            return sonuc;
        }

        static string EmaileUydurma(string uydurulacakString)
        {
            string email = uydurulacakString;

            email = email.ToLower();

            //foreach (var item in email)
            //{
            //    if (item == ' ')
            //        item = '.';
            //}

            //foreach (var item in email)
            //{
            //    if (item == 'ş')
            //        item = 's';
            //}

            //foreach (var item in email)
            //{
            //    if (item == 'ö')
            //        item = 'o';
            //}

            //foreach (var item in email)
            //{
            //    if (item == ' ')
            //        item = '.';
            //}

            email = email.Replace(" ", ".");
            email = email.Replace("ş", "s");
            email = email.Replace("ı", "i");
            email = email.Replace("ü", "u");
            //deger = deger.Replace("ö", "o");

            return email;
        }

        static string EmaileUydurma(int param)
        {
            return "";
        }

        static string EmaileUydurma(string deger, string[] izinVerilenKarakterler)
        {
            return "";
        }

        //static int EmaileUydurma(string deger, string[] izinVerilenKarakterler)
        //{
        //    return 0;
        //}

        static void XGunSonrasi(int gun)
        {
            string xGunSonrasi = TarihinGunu(DateTime.Now.AddDays(gun));
            Console.WriteLine("Bugünden " + gun + " gün sonrası " + xGunSonrasi);
        }

        static void IkiTarihFarki(DateTime tarih1, DateTime tarih2)
        {
            var sonuc = tarih1.Subtract(tarih2);
            Console.WriteLine("İki tarih arasındaki fark: " + Math.Abs(sonuc.TotalDays));
        }

        static string TarihinGunu(DateTime tarih)
        {
            return tarih.ToString("dddd");
        }

        static bool CheckMailAddress(string mail)
        {
            if (mail.Contains("@") && mail.Contains("."))
                return true;
            else
                return false;
        }

        static int CelciusToFahrenHeit(int c)
        {
            var f = c * 18 / 10 + 32;
            return f;
        }

        static int BasamakSayisi(int sayi)
        {
            return sayi.ToString().Length;
        }

        static string MailDomain1(string mailadresi)
        {
            string[] sonuc = mailadresi.Split("@");
            return sonuc[1];
        }

        static string MailDomain2(string mailadresi)
        {
            return mailadresi.Substring(mailadresi.IndexOf('@') + 1);
        }

        static int KelimeSayaci2(string yazi)
        {
            return yazi.Split(' ').Length;
        }

        static int KelimeSayaci1(string yazi)
        {
            //string.IsNullOrEmpty(yazi);

            int kelimeSayisi = 0;
            foreach (var karakter in yazi)
            {
                if (karakter == ' ')
                    kelimeSayisi++;
            }

            return kelimeSayisi;
        }

        static string CiftSayilar(int max)
        {
            string yazi = "";
            for (int i = 1; i <= max; i++)
            {
                if(i % 2 == 0)
                    yazi += i + " ";
            }

            return yazi.TrimEnd();
        }

        static double UsselCarpim2(int sayi, int us)
        {
            return Math.Pow(sayi, us);
        }

        static int UsselCarpim1(int sayi, int us)
        {
            int sonuc = sayi;
            for (int i = 0; i < us; i++)
            {
                sonuc *= sayi;
            }

            return sonuc;
        }

        static void SesliHarfSayaci2(string yazi)
        {
            char[] karakterler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int sesliHarfler = 0, digerKarakter = 0;
            yazi = yazi.ToLower();

            for (int i = 0; i < yazi.Length; i++)
            {
                if (karakterler.Contains(yazi[i]))
                    sesliHarfler++;
                else
                    digerKarakter++;
            }

            Console.WriteLine("Sesli harfler: " + sesliHarfler + ", diğer karakterler: " + digerKarakter);
        }

        static void SesliHarfSayaci1(string yazi)
        {
            yazi = yazi.ToLower();
            int sesliHarfler = 0, digerKarakter = 0;
            foreach (var karakter in yazi)
            {
                switch (karakter)
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü':
                        sesliHarfler++;
                        break;
                    default:
                        digerKarakter++;
                        break;
                }
            }

            Console.WriteLine("Sesli harfler: " + sesliHarfler + ", diğer karakterler: " + digerKarakter);
        }

        static string KarakterKisaltma(string yazi, int karakterSayisi)
        {
            return yazi.Substring(0, karakterSayisi) + "...";
        }

        static void TekCiftSayiSayar(int sayi)
        {
            int tekSayilar = 0, ciftSayilar = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                    ciftSayilar++;
                else
                    tekSayilar++;
            }

            Console.WriteLine("Çift sayı adedi: " + ciftSayilar + ", Tek sayı adedi: " + tekSayilar);
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
            Console.WriteLine((sonuc.Length - 1) + " boşluk var");
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