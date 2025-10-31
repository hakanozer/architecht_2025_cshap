namespace architecht_2025_cshap
{
    public class Variables
    {
        string name = "Erkan";
        public void VariablesCall()
        {
            // değişkenler
            // string - karakter katarı
            string name = "Ali";
            string surname = "Bilmem";
            Console.WriteLine(this.name + " " + surname);
            Console.WriteLine(name + " " + surname);

            // int - tam sayı
            int num1 = 40;
            int num2 = 99;
            int sumInt = num1 + num2;
            //int div = num1 / 0;
            Console.WriteLine(sumInt);

            // double - ondalıklı sayı
            double d1 = 66.6;
            double d2 = 44.2;
            double minDouble = d2 - d1;
            Console.WriteLine(minDouble);

            // boolean = true - false
            bool status = true;

        }

        public void IfCall()
        {
            int a = 10;
            int b = 11;

            // a, b'den büyük mü?
            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else
            {
                Console.WriteLine("koşul sağlanmadı!");
            }
            // a < b
            // a == b
            // a != b

            // bugün günlerden ne?
            string day = "Çarşamba";
            switch (day)
            {
                case "Pazartesi":
                    Console.WriteLine("Pazartesi");
                    break;
                case "Salı":
                    Console.WriteLine("Salı");
                    break;
                case "Cuma":
                    Console.WriteLine("Cuma");
                    break;
                default:
                    Console.WriteLine("Gün Yok!");
                    break;
            }
        }

        public void ArrayCall()
        {
            // Array - Diziler
            // Bir değişken altında birden fazla değeri tutmak
            string[] Cities = ["İstanbul", "Ankara", "İzmir", "Bursa", "Trabzon", "Gaziantep"];
            string[] Plakas = ["34", "06", "35", "16", "61", "27"];
            // index -> 0 dan başlar, n... gider.
            Console.WriteLine(Cities[5] + " " + Plakas[5]);
            Console.WriteLine(Cities.Length);

            // loop - döngü
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("for call");
            }

            for (int i = 0; i < Cities.Length; i++)
            {
                if (i == 2)
                {
                    //int a = i / 0;
                    continue;
                }
                Console.WriteLine(Cities[i]);
            }

            Console.WriteLine("=============================");
            foreach (var item in Cities)
            {
                Console.WriteLine(item);
            }

        }

    }
}