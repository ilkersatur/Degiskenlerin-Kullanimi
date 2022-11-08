Console.WriteLine("personel");
Console.Write("id = ");
int personel_id = Convert.ToInt16(Console.ReadLine());
Console.Write("Ad Soyad = ");
string personel_ad_soyad = (Console.ReadLine());
Console.Write("Yaş = ");
byte yas = Convert.ToByte(Console.ReadLine());
Console.Write("Maaş = ");
double maas = Convert.ToDouble(Console.ReadLine());
Console.Write("zam oranı %");
double zam = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("zam oranı %");

double yeni_maas = maas + ((maas * zam) / 100);
Console.WriteLine(personel_ad_soyad + " Zammı maaş " + yeni_maas + " TL");

static double Zamyap(double maas, double zam)      //metod yapma
{
    return maas + maas * zam / 100;
}
double zamlımaas = Zamyap(maas, 20);


//tip bilemiyorsak var kullanırız 
var metin = "ilker";
var sayi = 123;


string nesne = "Telefon";
string marka = "Samsung";
string renk = "Mavi";
DateTime cikis_yili = DateTime.Parse("12.01.2022");
double android_surumu = 12.1;
byte ram = 8;
bool parmak_izi = true;
int batarya_Mah = 4300;
decimal fiyat = 8200;

Console.WriteLine("yaş gir");
string yas2 = Console.ReadLine();
byte yeniyas = byte.Parse(yas2);
Console.WriteLine(yeniyas);

x:
try { 
Console.WriteLine("yaş gir");
string age = Console.ReadLine();
byte new_age = byte.Parse(age); //convert.to ile .parse aynı işlemi yapıyor
Console.WriteLine(new_age);}
catch
{
    Console.WriteLine("!!!!!sayi gir!!!!!");
}
goto x;