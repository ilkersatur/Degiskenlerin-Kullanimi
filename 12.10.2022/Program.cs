int a = 20;
long l = 23233;
short s = 232;
double d = 23.4;
decimal dc = 34.5m;
float f = 234.4f;
byte byt = 234;

bool bl = true;
char c = 'a';

string str = "İlker";
object obj = 2324;

/*Console.WriteLine(int.MaxValue);
Console.WriteLine(long.MaxValue);*/

int ogr_id = 23;
string ogr_adsyd = "İlker Şatur";
byte ogr_yas = 22;
bool gender = true;
double not_ort = 65.7;

Console.WriteLine("öğrenci");
    Console.Write("id = ");
    int ogrenci_id = Convert.ToInt16(Console.ReadLine());
    Console.Write("Ad Soyad = ");
    string ogrenci_ad_soyad = (Console.ReadLine());
    Console.Write("Yaş = ");
    byte ogrenci_yas = Convert.ToByte(Console.ReadLine());
    Console.Write("Doğum tarihi gün ay yıl = ");
    //doğum tarihi sene ekleme
    //console.writeline(dogumtarihi.addyears(10));
    DateTime dogumtarihi = DateTime.Parse(Console.ReadLine());
    Console.Write("Cinsiyet K ya da E  ");
    char cinsiyet = Convert.ToChar(Console.ReadLine());
    if (cinsiyet == 'K') ;
    {
        Console.WriteLine("KADIN"); }
    if (cinsiyet == 'E') ;
    {
        Console.WriteLine("ERKEK");
    }
    Console.WriteLine("not ortolaması ");
    Console.WriteLine("vize ");
    int vize = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("final ");
    int final = Convert.ToInt16(Console.ReadLine());
    int ortalama = (vize + final) / 2;
    Console.WriteLine("ortalama " + ortalama);