double secim, adet, toplam = 0;
double hesap = 0;

Console.WriteLine("****             A.Y.A. RESTORANINA HOŞGELDİNİZ             ****");
Console.WriteLine("****************************************************************");
Console.WriteLine("**                             **                             **");
Console.WriteLine("**          Yemekler           **         İçeçekler           **");
Console.WriteLine("**                             **                             **");
Console.WriteLine("**    1-Et Döner      7.00 TL  **     7-Ayran   1.00 TL       **");
Console.WriteLine("**                             **                             **");
Console.WriteLine("**    2-Tavuk Döner   5.00 TL  **     8-Kola    3.00 TL       **");
Console.WriteLine("**                             **                             **");
Console.WriteLine("**    3-Çorbalar      4.00 TL  **     9-Su      0.50 TL       **");
Console.WriteLine("**                             **                             **");
Console.WriteLine("**    4-Salatalar     2.50 TL  **     10-Çay    0.75 TL       **");
Console.WriteLine("**                             **                             **");
Console.WriteLine("**    5-Kuru/Pilav    6.00 TL  **     11-Fanta  2.00 TL       **");
Console.WriteLine("**                             **                             **");
Console.WriteLine("**    6-Pide          6.50 TL  **     12-Soda   1.00 TL       **");
Console.WriteLine("**                             **                             **");
Console.WriteLine("****************************************************************");

for (int i = 1; i < 100; i++)
{
    Console.WriteLine("");
    Console.WriteLine("Alacağınız Ürünün Numarası: ");
    secim = Convert.ToDouble(Console.ReadLine());
    if (secim ==1)
    {
        Console.Write("Kaç Porsiyon Et Döner: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 7;
        hesap = hesap + toplam;
    }
    else if(secim==2)
    {
        Console.WriteLine("Kaç Porsiyon Tavuk Döner: ");
        adet=Convert.ToDouble(Console.ReadLine());
        toplam = adet * 5;
        hesap = hesap + toplam;
    }
    else if (secim == 3)
    {
        Console.WriteLine("Kaç Tabak Çorba: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 4;
        hesap = hesap + toplam;
    }
    else if (secim == 4)
    {
        Console.WriteLine("Kaç Porsiyon Salata: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 2.50;
        hesap = hesap + toplam;
    }
    else if (secim == 5)
    {
        Console.WriteLine("Kaç Porsiyon Kuru Pilav: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet *6;
        hesap = hesap + toplam;
    }
    else if (secim == 6)
    {
        Console.WriteLine("Kaç Porsiyon Pide: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 6.50;
        hesap = hesap + toplam;
    }
    else if (secim == 7)
    {
        Console.WriteLine("Kaç Tane Ayran: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 1;
        hesap = hesap + toplam;
    }
    else if (secim == 8)
    {
        Console.WriteLine("Kaç Tane Kola: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 3;
        hesap = hesap + toplam;
    }
    else if (secim == 9)
    {
        Console.WriteLine("Kaç Tane Su: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 0.50;
        hesap = hesap + toplam;
    }
    else if (secim == 10)
    {
        Console.WriteLine("Kaç Tane Çay: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 0.75;
        hesap = hesap + toplam;
    }
    else if (secim == 11)
    {
        Console.WriteLine("Kaç Tane Fanta: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 2;
        hesap = hesap + toplam;
    }
    else if (secim == 12)
    {
        Console.WriteLine("Kaç Tane Soda: ");
        adet = Convert.ToDouble(Console.ReadLine());
        toplam = adet * 1;
        hesap = hesap + toplam;
    }
    else
        Console.WriteLine("Böyle Bir Ürün Yok");
    Console.WriteLine();
    Console.WriteLine("Başka İsteğiniz Var Mı?");
    string cevap = Console.ReadLine();
    if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "HAYIR" || cevap == "hayır")
        break;


}
Console.WriteLine("Toplam Tutar: " + hesap);


Console.Read();