namespace architecht_2025_cshap
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // Nesne üretimi - object
            Variables variables = new();
            variables.VariablesCall();
            variables.IfCall();
            variables.ArrayCall();

            Action action = new();
            action.Call1();
            int sm = action.Sum(); // 20
            Console.WriteLine(sm);
            if (sm > 20)
            {
                
            }

            Console.WriteLine(action.Sum());
            if (action.Sum() > 20)
            {

            }

            int sm1 = action.CallSum(100, 50);
            Console.WriteLine(sm1);

            int sm2 = action.CallSum(75, 44);
            Console.WriteLine(sm2);

            bool loginStatus = action.Login("", "");
            EAge eAge = action.Contact(17);
            Console.WriteLine(eAge);
            action.EMailSend(eAge);

            action.AddressLine("Adress -1", "Adress -2", "Adress -3");
        }

    }


}