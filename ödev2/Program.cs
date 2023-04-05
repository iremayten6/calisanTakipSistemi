// See https://aka.ms/new-console-template for more information
//İlgili bilgileri kullanıcıdan girmesini istedim.

using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

string ad, soyad, cinsiyet;
int numara, dogumtarihi;

Console.WriteLine("İsminizi Giriniz: ");
ad = Console.ReadLine();

Console.WriteLine("Soyadınızı Giriniz: ");
soyad = Console.ReadLine();

Console.WriteLine("Cinsiyetinizi Giriniz: ");
cinsiyet = Console.ReadLine();

Console.WriteLine("Numaranızı Giriniz: ");
numara = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Doğum Tarihinizi Giriniz:");
dogumtarihi = Convert.ToInt16(Console.ReadLine());


int yas = 2023 - dogumtarihi;
Console.WriteLine();
Console.WriteLine("Yaşınız: " + yas);
Console.WriteLine();

if (yas >= 20) //tam 20 yaşındaysa bile 21 yaşından gün almış olur.
{
    Console.WriteLine("aylar 5 haftadan oluşmaktadır.");
    for (int i = 1; i <= 5; i++) //21 yaşından gün almış olduğu için aylar 5 haftadan oluşuyor,bu haftaları döngü içine alarak yazdırdım.
    {
        Console.WriteLine(i + ".hafta ");

    }
}

else
{
    Console.WriteLine("aylar 6 haftadan oluşmaktadır."); //21 yaşından gün almadığı için aylar 6 haftadan oluşuyor, bu haftaları döngü içine alarak yazdırdım.

    for (int j = 1; j <= 6; j++)
    {
        Console.WriteLine(j + ".hafta ");
    }
}


if (cinsiyet == "kadın")
{
    Console.WriteLine();
    Console.WriteLine("hafta 6 günden oluşmaktadır."); //Girilen cinsiyet kadın olduğu için haftalar 6 günden oluşuyor,bu günleri döngü içine alarak yazdırdım.
    for (int i = 1; i <= 6; i++)
    {
        Console.WriteLine(i + ".gün ");
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("hafta 8 günden oluşmaktadır.");//Girilen cinsiyet erkek olduğu için haftalar 8 günden oluşuyor,bu günleri döngü içine alarak yazdırdım.
    for (int j = 1; j <= 8; j++)
    {
        Console.WriteLine(j + ".gün ");
    }
}
Console.WriteLine();
if (cinsiyet == "kadın" && yas >= 20) //Kontrol yapısı kullanarak çalışılacak gün sayısını hesapladım.
{
    Console.WriteLine("1 ayda çalışacağınız gün sayısı:30 ");
}
else if (cinsiyet == "kadın" && yas < 20)
{
    Console.WriteLine("1 ayda alışacağınız gün sayısı:36 ");
}
else if (cinsiyet != "kadın" && yas >= 20)
{
    Console.WriteLine("1 ayda calışacağınız gün sayısı:40");
}
else
{
    Console.WriteLine("1 ayda calışacağınız gün sayısı:48");
}
Console.WriteLine();

DateTime tarih = new DateTime(2023, 3, 13);
Console.WriteLine(tarih.DayOfWeek);
string tarihTurkce = "";

switch (tarih.DayOfWeek) //Switch-case yapısıyla bugünün hangi gün olduğunu kontrol ettim.
{

    case DayOfWeek.Sunday: tarihTurkce = "Pazar"; break;
    case DayOfWeek.Monday: tarihTurkce = "Pazartesi"; break;
    case DayOfWeek.Tuesday: tarihTurkce = "Salı"; break;
    case DayOfWeek.Wednesday: tarihTurkce = "Çarşamba"; break;
    case DayOfWeek.Thursday: tarihTurkce = "Perşembe"; break;
    case DayOfWeek.Friday: tarihTurkce = "Cuma"; break;
    case DayOfWeek.Saturday: tarihTurkce = "Cumartesi"; break;
    default: break;
}
Console.WriteLine(tarihTurkce);

Console.WriteLine("Bugünün tarihi ve saati: " + DateTime.Now);
Console.WriteLine();
Console.WriteLine("İsminiz: " + ad + " Soyisminiz: " + soyad + " Doğum Tarihiniz: " + dogumtarihi + " Yaşınız: " + yas + " Numaranız: " + numara + " Cinsiyetiniz: " + cinsiyet);

Console.WriteLine();
Console.ReadKey();
  

