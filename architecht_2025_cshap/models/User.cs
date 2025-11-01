namespace architecht_2025_cshap
{
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Age: {Age}";
        }
    }
}