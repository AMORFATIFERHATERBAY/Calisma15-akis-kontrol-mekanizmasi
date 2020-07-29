using System;

namespace deneme_7_akıs_kontrol_mek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ıf else deyimi
            int a=5;
            int b=7;
            if (a<b)
                  Console.WriteLine("1.deyim");
              else
                  Console.WriteLine("2.deyim"); 

            if (a<b)
            {   
                a++;
                  Console.WriteLine("1.deyim");
                  Console.WriteLine(a);
            }
              else
              { 
                b--;  
                  Console.WriteLine("2.deyim");    
              }  

              int not;
              Console.Write("Notunuzu giriniz (0-100)......");
              not=Convert.ToInt32(Console.ReadLine());
              if (not<0 || not>100)
                     Console.WriteLine("Yanlış Not Girdiniz...");
                else if (not>=85)
                     Console.WriteLine("Notunuz : A");
                else if (not>=70)
                     Console.WriteLine("Notunuz : B");
                else if (not>=55)
                     Console.WriteLine("Notunuz : C");
                else if (not>=45)
                     Console.WriteLine("Notunuz : D");

                     
                else 
                     Console.WriteLine("Dersi Geçemediniz...");


            int sayi1,sayi2;
            string islem;

            Console.Write("Birinci sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTOPLAMA --> t");
            Console.WriteLine("\nÇIKARNA --> c");
            Console.WriteLine("\nÇARPMA  --> m");
            Console.WriteLine("\nBÖLME   --> d");

            Console.WriteLine("\nişleminizi seçiniz...: ");
            islem = Console.ReadLine();
              
              if (islem == "d" || islem=="b")
                if (sayi2 != 0)
                {
                    float sonuc = (float)sayi1/(float)sayi2;
                    Console.WriteLine($"\nSonuç...: {sonuc}");
                }
                else
                    Console.WriteLine("BÖLEN SIFIR OLAMAZ...");
              else if (islem == "t")
                    Console.WriteLine("\nSonuç ...: {0}",sayi1+sayi2);
              else if (islem == "c")
                    Console.WriteLine("\nSonuç ...: {0}",sayi1-sayi2);
              else if (islem == "m")
                    Console.WriteLine("\nSonuç ...: {0}",sayi1*sayi2); 

            // switch deyimi
            //int sayi1,sayi2;
            //string islem;   

            Console.Write("Birinci sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine("\nTOPLAMA --> t");
            Console.WriteLine("\nÇIKARNA --> c");
            Console.WriteLine("\nÇARPMA  --> m");
            Console.WriteLine("\nBÖLME   --> d");

            Console.Write("\nişleminizi seçiniz...: ");
            islem = Console.ReadLine();

            switch (islem)
            {
                case "t":
                      Console.WriteLine("Sonuç.....: {0}",sayi1+sayi2); break;
                case "c":
                      Console.WriteLine("Sonuç.....: {0}",sayi1-sayi2); break;
                case "m":
                      Console.WriteLine("Sonuç.....: {0}",sayi1*sayi2); break;      
                case "d":
                    switch(sayi2)
                    {
                        case 0 :
                        Console.WriteLine("Bölen sıfır olamaz..."); break;
                        default :
                        float sonuc = (float)sayi1/(float)sayi2;
                        Console.WriteLine("Sonuç.... : {0}", sonuc); break;
                    }      
                    break;



            }



            // döngü yapıları
            // for döngüleri
            int toplam = 0;
            for (int i=1; i<=3; i++)
                {
                     toplam = toplam+i;
                Console.WriteLine("Toplam... : {0}",toplam);
                }
                Console.WriteLine();
            
            int k=0;
            for (;k<10;++k)  
                Console.Write(k);
                Console.WriteLine();
            int x=0;
            for (;x<10;)  
                {
                    Console.Write(x); ++x;
                }
                Console.WriteLine();
            
            // for (;;) sonsuz döngüye girer.
            // for deyimi ile ilgili uygulamalar;
            int toplam1=0, adet=0;
            for (int s=1; s<=1000; s++)
            {
              if ((s%5==0) && (s%7!=0))
              {
              toplam1+=s;
              adet++;
              }
            }  

            Console.WriteLine("\n{0} adet sayı bulundu...",adet);
            Console.WriteLine("\nToplamları = {0}",toplam1);

            int adet1 = 0;
            for (int d=0; d<=100; d+=5)
            {
                if (adet1%6==0)
                    Console.WriteLine();
                    adet1++;
                    Console.Write("{0,4}",d);

            
                
            }
            Console.WriteLine();


            int satir,sutun;
            //int adt = 0;
            Console.Write("Satır sayısı..: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısı..: ");
            sutun = Convert.ToInt32(Console.ReadLine());

            for (int y=1; y<=satir; y++)
            {
                for (int j=1; j<=sutun; j++ )
                Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();



           /*for (int y=1; y<=satir*sutun; y++)
            {
                if (adt%sutun==0)
                Console.WriteLine();
                Console.Write("*");
                adt++;
            }
            Console.WriteLine();*/



            //kullanıcının ekrandan girdiği byte türündem sayının bitlerini ekrana yazdıracak program
           byte bsayi;
           Console.Write("sayıyı giriniz  :");
           bsayi=Convert.ToByte(Console.ReadLine());
            
              for ( byte z=8; z>=6; z--)
                {
                  byte and=1;

                  for ( byte v=1; v<=z-1; v++)
                      and*=2;

                  byte bit = (byte)((bsayi&and)>>z-1);     
 
                  Console.Write(bit);
                  Console.Write(and);

                
                 }
            Console.WriteLine();

             //0 ile 100 arası girilen 10 notun max ve min bulan ve not ort yazan prog

           int min=100, max=0, total=0;
           int piece=10;
           int point;
              
              for (int p=1; p<=piece; )

                {
                    Console.Write($"{p}. Enter Note : ");
                    point=Convert.ToInt32(Console.ReadLine());
                     if (point<0||point>100)
                        Console.WriteLine("mistaken note...");
                     else
                      {
                         if (point>max) 
                             max=point;
                             else if (point<min)
                                    min=point;
                         total+=point;
                         p++;

                      }

                }
                Console.WriteLine();
            Console.WriteLine("max note       : {0}",max);    
            Console.WriteLine("mix note       : {0}",min); 
            float ave =(float)total/(float)piece;
            Console.WriteLine("average notes  :{0}",ave);

           // string islem ;
            Console.Write("\nişleminizi seçiniz...: ");
            islem = Console.ReadLine();


            // **** (while) DÖNGÜ *****
            int w=1;
            while (w<=20)
                  {
                      Console.Write(w);
                      w++;
                  }
                  Console.WriteLine();

            for (int fw =1; fw <=20;)
             {
                 Console.Write(fw);
                 fw++;
             }
             Console.WriteLine();
             ///////////////

             int n=0;
             int ttl=0;

             while(n<=8)
               {
                  ttl+=n; // -> ttl=ttl+n; 
                  n+=2; // --> n=n+2;
               }
              Console.WriteLine("0' dan 100'e kadar olan çift sayıların toplamı = {0}",ttl); 

              // do while döngüsü*********

              string yazii;
              do
                {
                    Console.Write("Şifreyi giriniz...: ");
                    yazii=Console.ReadLine();

                } while(yazii!="sifre");
                  Console.WriteLine("sifreyi bildiniz");
 
            char ch;
            do  
               {
                   Console.Write("bir karakter giriniz :");
                   ch = Convert.ToChar(Console.ReadLine());
                   if (ch =='q' || ch == 'Q')
                   break;
                    else
                     Console.WriteLine("döngüye devam...");
               } while (true);  /* ch!='z'while böyle bir şart yazdığımız da z yazınca döngü dışına çıkılması sağlanır 
                               "true" ise sonsuz döngüye devam etmeyi sağlar taki 'q ve Q ' yazana kadır, 
                               bunlardan biride yazılırsa break komutundan dolayı yine döngüden çıkılır.*/

               Console.WriteLine("döngü dışı...");

            int num;
            int tplm=0;
            int bironcekisayi=0;
               
                for (;;)
                 {
                     Console.Write("bir sayı giriniz..: ");
                     num=Convert.ToInt32(Console.ReadLine());
                     
                     if (num==0)
                       break;
                       if (num==bironcekisayi)
                       {
                           Console.WriteLine("Farklı sayı giriniz...");
                           continue;
                       } 
                      tplm+=num;
                      Console.WriteLine("Toplman = {0}",tplm);
                      bironcekisayi=num;

                 }
                    int exttotal=0;
                 for (int den =1; den<=3; den++)
                 {
                       exttotal+=den;
                       Console.WriteLine("exttoplam = {0}",exttotal);
                 }
                 Console.WriteLine();


                 int time;
                 Console.Write("Please enter time...:");
                 time=Convert.ToInt32(Console.ReadLine());
                 if (time <10)
                 {
                     Console.WriteLine("Good morning..");
                 }
                 else if (time<20)
                 {
                     Console.WriteLine("Good day...");
                 }
                 else
                 {
                     Console.WriteLine("Good evening...");
                 }
                    ///// değ tur =(şart) ? "ifade" : "ifade";
                 int tm;
                 Console.Write("Please enter time...:");
                 tm=Convert.ToInt32(Console.ReadLine());

                     string result = (tm<18) ? "Good day..." : "Good evening...";
                     Console.WriteLine(result);

                //////// switch /////
                int day;
                Console.Write("Enter week's days ...(1-7):");
                day=Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case 1:
                     Console.WriteLine("Monday");
                     break;
                    case 2:
                     Console.WriteLine("Tuesday");
                     break;
                    case 3:
                     Console.WriteLine("Wednesday");
                     break;
                    case 4:
                     Console.WriteLine("Thursday");
                     break;
                    case 5:
                     Console.WriteLine("Friday");
                     break;
                    case 6:
                     Console.WriteLine("Saturday");
                     break;
                    case 7:
                     Console.WriteLine("Sunday");
                     break;
                     default:
                     Console.WriteLine("please enter 1 or 7...");
                     break;      
                } 

                ///// " while() {} "

                int whl=0;
                while(whl<5)
                  {
                      Console.Write(whl);
                      whl++;
                  }
                  Console.WriteLine();

                string[] cars ={"mercedes","mazda","ford","audi","bmw","toyota","vw"};
                foreach (string fs in cars)
                  {
                      Console.WriteLine(fs);
                  } 
                    
                
                















           
           





           



                    
                           
        }
    }
}
