namespace telefonrehberi
{ 
    public class Silmeİşlemi:KayıtlıNumaralar
    { 
        public static void Silme()
        { 
            Console.WriteLine("Lütfen Silmek İstediğiniz kişinin adını veya soyadını giriniz:");
            string input = Console.ReadLine();

            foreach (var item in telefonRehberim.ToList())
            {
                if(input == item.isim || input == item.soyisim)
                { 
                    Console.WriteLine(item.isim+ " " +item.soyisim + "isimli kişi rehberden silinmek üzere onaylıyormusunuz? (y/n)");
                    string input1= Console.ReadLine();
                    if(input1== "y")
                    { 
                        telefonRehberim.Remove(item);
                    }
                    else
                    { 
                        Console.WriteLine("Çıkış yapılıyor.");
                        break;
                    }
                    break;
                }
                else
                { 
                    Console.WriteLine(" Rehberde Aradığınız kriterlere uygun veri bulunamadı. Lütfen seçim yapınız");
                    Console.WriteLine("*Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("Yeniden denemek için (2)");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    if(input2 == 1)
                    { 
                        Console.WriteLine("İşlem Sonlandırıldı.");
                        break;
                    }
                    else
                    { 
                        Silmeİşlemi.Silme();
                    }
                    break;

                }
                
            }
        }
            
    }
}