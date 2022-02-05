/************* Örnek - 1 *************
// string: metinsel ifadeleri tutmaya yarayan değişkendir.
string sehir;
sehir = "Gaziantep";
Console.WriteLine(sehir);
Console.Read();
*/
/************* Örnek - 2 **************
string isim;
isim = "Nur";
Console.Write(isim);
Console.Read();
*/
/************* Örnek - 3 **************
string isim;
Console.WriteLine("Adınızı giriniz: ");
isim = Console.ReadLine();// Console.ReadLine(); ifadesi dışarıdan veri almamızı sağlar.
Console.WriteLine("Hoşgeldin " + isim);
Console.Read();
*/
/************* Örnek - 4 **************
string ad, soyad, yas, meslek, sehir;
Console.WriteLine("Sırayla ad,soyad,yaş,meslek ve şehrinizi giriniz: ");
ad = Console.ReadLine();
soyad = Console.ReadLine();
yas = Console.ReadLine();
meslek = Console.ReadLine();
sehir = Console.ReadLine();
Console.WriteLine("AD " + ad);
Console.WriteLine("SOYAD "+soyad);
Console.WriteLine("Yaş " + yas);
Console.WriteLine("Meslek " + meslek);
Console.WriteLine("ŞEHİR " + sehir);
Console.Read();
*/
/************* Örnek - 5 **************
string ad;
Console.WriteLine("Lütfen adınızı giriniz: ");
ad = Console.ReadLine();
Console.WriteLine("Merhaba {0} ", ad); // Böyle yazmamızın sebebi kod tasarrufudur.
Console.Read();
*/
/************* Örnek - 5 **************
string ad, soyad, sehir;
Console.WriteLine("AD ");
ad = Console.ReadLine();
Console.WriteLine("SOYAD ");
soyad = Console.ReadLine();
Console.WriteLine("ŞEHİR ");
sehir = Console.ReadLine();
Console.WriteLine("AD : {0} SOYAD : {1} ŞEHİR : {2}",ad,soyad,sehir);
Console.ReadLine();
*/