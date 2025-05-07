
Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

Console.Write("T.C. Kimlik Numarası: ");
string kimlikno = Console.ReadLine(); // Kimlik numarası matematiksel bir işlemde kullanılmayacağı için ve int için uzun olduğundan string kullandım.

Console.Write("Adı: ");
string ad = Console.ReadLine();

Console.Write("Soyadı: ");
string soyad = Console.ReadLine();

Console.Write("Telefon Numarası: ");
string telno = Console.ReadLine(); // Telefon nosu matematiksel bir işlemde kullanılmayacağından ve başına 0 gelebileceği için string kullandım.

Console.Write("Yaş: ");
int yas = Convert.ToInt32(Console.ReadLine());

Console.Write("İlk aldığı ürünün fiyatı: ");
double fiyat1 = Convert.ToDouble(Console.ReadLine());  //ürün fiyatı ondalık sayı olarak girilebileceğinden double kullandım. 

Console.Write("İkinci aldığı ürünün fiyatı: ");
double fiyat2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.WriteLine($"{kimlikno} TC Numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{telno} telefon numarasına bildirim mesajı gönderilmiştir.");
double toplam = fiyat1 + fiyat2;
double puan = toplam / 10;
Console.WriteLine($"{toplam} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {puan} TL'dir.");







