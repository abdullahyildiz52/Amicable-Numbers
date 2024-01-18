//Kullanicidan alinan iki sayi bagdasik mi kontrol eden kod
Console.WriteLine("lutfen sayi giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("LUTFEN İKİNCİ SAYİ GİRİNİZ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
bool bulalim = bagdasikmi(sayi1, sayi2);
if (bulalim == true)
{
    Console.WriteLine("sayılar bağdaşık sayı");
}
else
{
    Console.WriteLine("sayilar bagdasik degildir");
}

static bool bagdasikmi(int sayi1, int sayi2)
{
    int toplam1 = 0; int toplam2 = 0;
    bool durum = false;
    for (int i = 1; i <= sayi1 / 2; i++)
    {
        if (sayi1 % i == 0)
        {
            toplam1 += i;
        }
    }
    for (int j = 1; j <= sayi2 / 2; j++)
    {
        if (sayi2 % j == 0)
        {
            toplam2 += j;
        }
    }
    if (sayi1 == toplam2 && sayi2 == toplam1)
    {
        durum = true;
    }
    else
    {
        durum = false;
    }
    return durum;
}
