namespace telefonrehberi
{
    public class Kaydetmeİşlemi : KayıtlıNumaralar
    {
        public static void Kaydet()
        {
            Console.WriteLine("Lütfen İsim Giriniz            :");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz         :");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen Telefon Numarası Giriniz:");
            string no = Console.ReadLine();


            Rehber kişi = new Rehber();
            kişi.isim=ad;
            kişi.soyisim=soyad;
            kişi.numara=no;

            KayıtlıNumaralar.telefonRehberim.Add(kişi);
        }
    }
}