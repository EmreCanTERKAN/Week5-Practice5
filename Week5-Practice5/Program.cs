bool kosul = false;

while (!kosul)
{
    try
    {
        Console.WriteLine("Bir sayı gir");
        int sayi = int.Parse(Console.ReadLine());
        Console.WriteLine("Sayının Karesi : " + sayi * sayi);
        kosul = true;


    }
    catch (Exception)
    {

        Console.WriteLine("Hata...Geçersiz Sayı Girdin. Lütfen Bir sayı giriniz");
    }

}

