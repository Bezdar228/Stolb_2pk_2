namespace pz_21._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(
                id: 228,
                username: "Tomas Shelby",
                email: "Bebra.1132.@mai.ru",
                password: "154331trwqsaf12356236",
                registrationDate: DateTime.Now);

            Console.WriteLine($"Account Id: {account.Id}");
            Console.WriteLine($"Username: {account.Username}");
            Console.WriteLine($"Email: {account.Email}");
            Console.WriteLine($"Password: {account.Password}");
            Console.WriteLine($"Registration Date: {account.RegistrationDate}");

        }
    }
}