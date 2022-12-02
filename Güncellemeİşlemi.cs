namespace telefonrehberi
{
    public class Güncellemeİşlemi : KayıtlıNumaralar
    {
        public static void Güncelleme()
        {


            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını yada soyadını giriniz");
            string input = Console.ReadLine();

            foreach (var item in telefonRehberim.ToList())
            {
                if (input == item.isim || input== item.soyisim)
                {
                    Console.WriteLine("Lütfen yeni numara giriniz:");
                    string input1= Console.ReadLine();
                    item.numara = input1;
                    break;
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.Lütfen seçim yapınız:");
                Console.WriteLine("*Güncellemeyi sonlandırmak için (1)");
                Console.WriteLine("*yeniden denemek için (2)");
                int input2= Convert.ToInt32(Console.ReadLine());

                if(input2 == 1)
                { 
                    Console.WriteLine("işlem sonlandırıldı.");
                    break;
                }
                else
                { 
                    Güncellemeİşlemi.Güncelleme();
                }
                break;
                }
            }
        }
    }

}
