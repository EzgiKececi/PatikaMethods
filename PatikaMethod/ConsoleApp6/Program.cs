//1.Uygulama
void Lyric()
{
    Console.WriteLine("Lyric=Each time the wind blows, I hear your voice.");
}

Lyric(); 

//2.Uygulama

int IkiyeBolum()
{
    Random rastgele = new Random();

    int sayi = rastgele.Next();
    Console.WriteLine("Üretilen sayı:" + sayi);

    int kalan = sayi % 2;
    Console.WriteLine("Üretilen sayının 2'ye bölümünden kalan:" + kalan); // Kontrol etmek için konsola yazdırdım.
    return kalan;


}

IkiyeBolum(); 

//3.Uygulama

int Carpim(int sayi1, int sayi2)
{
    int carpim = sayi1 * sayi2;
    Console.WriteLine(carpim);
    return carpim;
}

Console.Write("Lütfen bir sayı giriniz: ");
int s1=Convert.ToInt32(Console.ReadLine());

Console.Write("Lütfen bir sayı giriniz: ");
int s2 = Convert.ToInt32(Console.ReadLine());

Carpim(s1, s2);

//4.Uygulama

void HosGeldiniz(string isim, string soyisim)
{
    Console.WriteLine($"Hoşgeldiniz {isim} {soyisim}");
}
Console.Write("Adınızı giriniz: ");
string kullaniciAdi= Console.ReadLine();
Console.Write("Soyadınızı giriniz: ");
string kullaniciSoyadi = Console.ReadLine();    
HosGeldiniz(kullaniciAdi, kullaniciSoyadi); 