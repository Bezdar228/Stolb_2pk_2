namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем несколько объектов класса Account
            Account account1 = new Account(1, "email1@mail.com", "l@gi121n1", "p@ss3214word", new DateTime(2000, 01, 01));
            Account account2 = new Account(2, "email2@mail.com", "l@gin1232", "p@sswo1231rd", new DateTime(2000, 01, 01));
            Account account3 = new Account(3, "email3@mail.com", "l@gi1231n3", "p@ssw1231ord", new DateTime(2000, 01, 01));

            // Выводим информацию о каждом объекте класса Account
            account1.PrintInfo();
            account2.PrintInfo();
            account3.PrintInfo();

            // Создаем несколько объектов класса DeletedAccount
            DeletedAccount deletedAccount1 = new DeletedAccount(4, "email4@mail.com", "l@g1234in4", "p@1234ssword", new DateTime(2000, 01, 01), "неактивный аккаунт");
            DeletedAccount deletedAccount2 = new DeletedAccount(5, "email5@mail.com", "l@g1234in5", "p@s13241sword", new DateTime(2000, 01, 01), "нарушение правил использования");
            DeletedAccount deletedAccount3 = new DeletedAccount(6, "email6@mail.com", "l@gin13246", "p@ssw2134ord", new DateTime(2000, 01, 01), "удаление по желанию пользователя");

            // Выводим информацию о каждом объекте класса DeletedAccount
            deletedAccount1.PrintInfo();
            deletedAccount2.PrintInfo();
            deletedAccount3.PrintInfo();
        }
    }
}
