/****** Örnek - 1 *********
int sayi1, sayi2, toplam;
Console.WriteLine("Birinci sayıyı giriniz : ");
sayi1 = Convert.ToInt32(Console.ReadLine());
//Convert.ToInt32: ifadesi alınan verinin sayı olarak kullanılabilmesi için gereklidir.
//Int32,Int64 vs. neye göre kullanıyoruz peki?
// Onları da alacağımız verinin bulunduğu yer belirliyor.
Console.WriteLine("İkinci  sayıyı giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());
toplam = sayi1 + sayi2;
Console.WriteLine("Toplam : " + toplam);
*/
/****** Örnek - 2 *********
int sayi1, sayi2, toplam, carpim, cıkarma, bolum;
Console.WriteLine("BİRİNCİ SAYIYI GİRİNİZ : ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İKİNCİ SAYIYI GİRİNİZ : ");
sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("********* 4 - İŞLEM **********");
Console.WriteLine();
toplam = sayi1 + sayi2;
carpim = sayi1 * sayi2;
bolum = sayi1 / sayi2;
cıkarma = sayi1 - sayi2;
Console.WriteLine("TOPLAM : " + toplam);
Console.WriteLine("ÇIKARMA : " + cıkarma);
Console.WriteLine("ÇARPMA : " + carpim);
Console.WriteLine("BÖLÜM : " + bolum);
//Bölümde yalnızca tam kısmı çıktı olarak verecektir çünkü ondalıklı ifadeler int değişkeninde bu şekilde ifade edilir.
Console.Read();
*/
/****** Örnek - 3 *********
int kenar, karecevre, karealan;
Console.Write("Karenin bir kenar uzunluğunu giriniz : ");
kenar = Convert.ToInt32(Console.ReadLine());
Console.Clear();//Estetik için sadece sonucu görmek istiyorsak verileri aldığımız son satırın altına yazarız.
karecevre = kenar * 4;
karealan = kenar * kenar;
Console.WriteLine("\n************ Karenin Alan ve Çevresini Bulan Program ****************\n\nKarenin alanı : {0}\nKarenin çevresi : {1} ", karealan,karecevre);
*/
/****** Örnek - 4 *********
int kısakenar, uzunkenar, alan, cevre;
Console.Write("\nKısa kenarı giriniz : ");
kısakenar = Convert.ToInt32(Console.ReadLine());
Console.Write("\nUzun kenarı giriniz : ");
uzunkenar = Convert.ToInt32(Console.ReadLine());
Console.Clear();
alan = uzunkenar * kısakenar;
cevre = (kısakenar + uzunkenar) * 2;
Console.WriteLine("\n************ Dikdörtgenin Alan ve Çevresini Bulan Program ****************\n\nDikdörtgenin alanı : {0}\nDikdörtgenin çevresi : {1} ", alan, cevre);
*/