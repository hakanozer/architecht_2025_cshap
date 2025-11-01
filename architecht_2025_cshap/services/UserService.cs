using System.Collections.Generic;

namespace architecht_2025_cshap
{
    public class UserService
    {
        public User SingleUser()
        {
            User user = new();
            user.Name = "Ali Bilmem";
            user.Age = 30;
            user.Email = "ali@mail.com";
            user.Password = "12345";
            return user;
        }

        public User[] AllUser()
        {
            User u1 = new();
            u1.Name = "Kemal Bil";
            u1.Age = 25;
            u1.Email = "kemal@mail.com";
            u1.Password = "12345";

            User u2 = new();
            u2.Name = "Zehra Bilirim";
            u2.Age = 22;
            u2.Email = "zehra@mail.com";
            u2.Password = "12345";

            User u3 = new();
            u3.Name = "Mehmet Bilsin";
            u3.Age = 35;
            u3.Email = "mehmet@mail.com";
            u3.Password = "12345";

            User[] users = [u1, u2, u3];
            return users;
        }

        public void CallList()
        {
            Action.Number = 50;
            List<string> values = new();
            values.Add("Ali");
            values.Add("Erkan");
            values.Add("Serkan");
            values.Add("Zehra");
            Console.WriteLine(values.Count);

            values.RemoveAt(0);
            Console.WriteLine(values.Count);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            User u1 = new();
            u1.Name = "Kemal Bil";
            u1.Age = 25;
            u1.Email = "kemal@mail.com";
            u1.Password = "12345";

            User u2 = new();
            u2.Name = "Zehra Bilirim";
            u2.Age = 22;
            u2.Email = "zehra@mail.com";
            u2.Password = "12345";

            User u3 = new();
            u3.Name = "Mehmet Bilsin";
            u3.Age = 35;
            u3.Email = "mehmet@mail.com";
            u3.Password = "12345";

            List<User> users = new();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Remove(u1);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

        }
        
        public void ListControl()
        {
            Console.WriteLine("======================");
            List<User> users = new();

            for(; ; )
            {
                Console.WriteLine("Durma için: end, Devam için Enter!");
                string status = Console.ReadLine();
                if (status == "end")
                {
                    break;
                }

                User u = new();
                Console.WriteLine("Müşteri Adı?");
                string name = Console.ReadLine();
                u.Name = name;
                Console.WriteLine("Müşteri Email?");
                string email = Console.ReadLine();
                u.Email = email;
                Console.WriteLine("Müşteri Şifre?");
                string password = Console.ReadLine();
                u.Password = password;
                Console.WriteLine("Müşteri Yaşı?");
                int age = Convert.ToInt32( Console.ReadLine() );
                u.Age = age;

                users.Add(u);

            }

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        }


    }
}