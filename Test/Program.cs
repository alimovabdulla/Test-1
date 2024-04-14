using System.Net.Http.Headers;
using System.Threading.Channels;
#region 1-100 kimi cut sayilar.
//int count = 0;
//for (int i = 0; i <= 100; i++)
//{

//    if (i%2 == 0)
//    {
//        Console.WriteLine(i);
//    }



//}
#endregion
#region 50-340 arasi regemlerden 15se bolunenler.
//for (int i = 50;i <= 340; i++)
//{

//    if ((i% 15) == 0) { Console.WriteLine(i); }



//}
#endregion
#region int arraydeki regemleri tersine yazdir.

//int[] arr = { 5, 7, 9, 1, 3, 5 };
//Array.Reverse(arr);
//foreach (int i in arr)
//{

//    Console.Write(i);


//}
#endregion
#region yazilan metinde 'a' herflerinin sayin ekrana yazdir.
//Console.WriteLine("yazi yazin:");
//string metin = Console.ReadLine();
//var count = 0;
//char[] con = metin.ToCharArray();
//for (int i = 0; i < con.Length; i++)
//{

// if (con[i] == 'a')
//    {
//        count ++;   
//    }

//}
//Console.WriteLine(count);
#endregion
#region int arrayin icinden en boyuk  regemi tap.

//int[] arr = {3,6,74, 7, 8};
//int maxnumber = Max(arr);
//Console.WriteLine("En boyuk sayi: " + maxnumber);


// int Max(int[] arr)
// {
//    int max = arr[0];

//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }

//    return max;
// }
#endregion
#region 50-100 arasi regemlerin toplam cemi.
//int a = 0;
//for (int i = 50; i <= 100; i++)
//{
//    a += i;


//}

//Console.WriteLine(a);
#endregion
#region yazilan sayi nece defe bolune bilir.
//Console.Write("Regem yazin: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int bolunmesayi = Sayinitap(sayi);
//Console.WriteLine(bolunmesayi + " "+"defe bolunur");
//int Sayinitap(int sayi)
//{
//    int bolunmesayi = 0;

//    for (int i = 1; i <= sayi; i++)
//    {
//        if (sayi % i == 0)
//        {
//            bolunmesayi++;
//        }
//    }

//    return bolunmesayi;

//}
#endregion
#region int tipinde gebul edir nece regemli(basamagli) ildugunu gosterir.
//Console.WriteLine("REgeminizi yazin:");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//int netice = Basamagsayi(sayi1);
//Console.WriteLine(netice);

//static int Basamagsayi(int sayi1)
//{
//    int sayi2 = 0;

//    while (sayi1 != 0)
//    {

//        sayi1 /= 10;

//        sayi2++;


//    }

//    return sayi2;
//}
#endregion

/*1) Console.WriteLine metodunun return tipi voiddir.
 2) OOP nin 4 prinsipi var: Abstraction,Polimorphism, Encapsulation, Inheritance.
3) Inheritancenin izahi: demeli iki eded class var mesel ucun biri BAse class yeni miras veren Biri derived yeni miras alan
"MyClass" Base classdir (YourClass) Derived classdir MyClassin inide olan her bir sey YourClassa Inherit olur yeni
miras verilir. MyClass uzerinde ede bileceyimiz her bir emeliyyati YourClass uzerinden ede bilirik. Miras nece alinir?
":" iki nogte isaresi ile (miras alan) YourClass:MyClass(miras veren).
4) Tipler iki yere bolunur referance ve value tip. Ramin iki hissesi var stack ve heap. Value tipler ramin stackinda yerlesir meselen:
int a = 100; stackda: a =100 . Referance tipler ise heapda yerlesir amma nece demeli bir tip yaradaq , string a = "salam", a'ya stackda
bir unva verilir meselen , a=786 , heapde ise 786= "salam " bu sekilde.
5) for ve while. while de sadece ser werilir eyer sert Trudursa dongu ise dusur amma for'da  ilk once baslangic deyeri verilir sonra
Emeliyyatin hara geder olacagi ve son olaraqda hansi emeliyyati edeceyi deyilir, bu sertler yerine yetirildikden sonra
dongu dayanir.
6)Access modifiers elcatanligi belirleyir. onalar 4 ddur Private , Public, Internal, Protected
public her yerden el catandi, private sadece oz classinin icinde, Protecden sadece miras verdiyi classsin icinde, internal
sadece oz Proektinin icinde. Classin defaultu(yeni sistemin avtomatik olaraq qoydugu) Internaldir , propertinin Ise Privatedir.
7)Mutable ve Immutable. Yeni degistirilebilen ve bilmeyen. meselen string tipler immutabledir yaradildigdan sonra degistirile bilmez
meselen yartdigimiz stringe a'ya Toupper metodunu icra ettik string a deyismir ancaq basqa bir string b yaradib   a'ni b'ye
ToUpper olaraq gondere bilerik a oldugu kimi qalacaq.*/