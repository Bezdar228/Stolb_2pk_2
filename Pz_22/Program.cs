


namespace Pz_22

{
    class Program
    {
        static void Main(string[] args)
        {
            pz_22.Account account = new pz_22.Account(
                id: 1,
                username: "JohnDoe",
                email: "john.doe@example.com",
                password: "password123",
                registrationDate: DateTime.Now,
                isAdmin: false
            );

            Console.WriteLine($"Account Id: {account.Id}");
            Console.WriteLine($"Username: {account.Username}");
            Console.WriteLine($"Email: {account.Email}");
            Console.WriteLine($"Password: {account.Password}");
            Console.WriteLine($"Registration Date: {account.RegistrationDate}");
            Console.WriteLine($"Is Admin: {account.IsAdmin}");
        }
    }
}