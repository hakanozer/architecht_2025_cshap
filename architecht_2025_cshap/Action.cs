using System.Security.Cryptography;

namespace architecht_2025_cshap
{
    public class Action
    {
        public void Call1()
        {
            int a = 10;
            Console.WriteLine(a);
        }
        private void Call2()
        {

        }
        
        public int Sum()
        {
            int sm = 10;
            return sm + sm;
        }
        public int Sum1()
        {
            int sm = 10;
            int smx = sm + sm;
            return smx;
        }

        public int CallSum(int a, int b)
        {
            int sm = a + b;
            return sm;
        }

        public bool Login(string email, string password)
        {
            if (email == "ali@mail.com" && password == "12345")
            {
                return true;
            }
            return false;
        }

        public EAge Contact(int age)
        {
            EAge eAge = EAge.Person;
            if (age > 10 && age < 18)
            {
                eAge = EAge.Normal;
            }
            else if (age > 16 && age < 40)
            {
                eAge = EAge.Silver;
            }
            else if (age > 40 && age < 50)
            {
                eAge = EAge.Gold;
            }
            return eAge;
        }

        public void EMailSend(EAge eAge)
        {
            Console.WriteLine("Send Email:" + eAge);
        }

        public void AddressLine(params string[] lines)
        {
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}