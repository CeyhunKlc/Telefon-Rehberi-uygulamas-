namespace telefonrehberi
{
    public class KayıtlıNumaralar
    {
        public static List<Rehber> _telefonrehberim;

        static KayıtlıNumaralar()
        {
            _telefonrehberim = new List<Rehber>()
            { 
                new Rehber{isim= "Ceyhun", soyisim ="Kılıc",numara = "01234567891"},
                new Rehber{isim= "Abdullah", soyisim ="Kılıc",numara = "01234567892"},
                new Rehber{isim= "Ali", soyisim ="Yılmaz",numara = "01234567893"},
                new Rehber{isim= "Ahmet", soyisim ="Adan",numara = "01234567894"},
                new Rehber{isim= "Mehmet", soyisim ="Demir",numara = "01234567895"},
            };
        }

        public static List<Rehber> telefonRehberim
        {
            get { return _telefonrehberim; }
        }
        public static void RehberYazdır()
        {
            foreach (var item in telefonRehberim)
            {
                Console.WriteLine(item.isim+" " +item.soyisim+" "+item.numara);
            }
        }

    }
}             