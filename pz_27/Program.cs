namespace pz_27
{
    using System;

    struct ZNAK // Описываем структуру ZNAK
    {
        public string NAME; // Фамилия, имя
        public string ZODIAC; // Знак Зодиака
        public int[] BDAY; // День рождения (массив из трех чисел)
    }

    class Program
    {
        static void Main(string[] args)
        {
            ZNAK[] BOOK = new ZNAK[8]; // Создаем массив BOOK типа ZNAK на 8 элементов
            int i, j;
            ZNAK temp;

            // Вводим данные о людях
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите данные о человеке №{0}:", i + 1);
                Console.Write("Фамилия, имя: ");
                BOOK[i].NAME = Console.ReadLine();
                Console.Write("Знак Зодиака: ");
                BOOK[i].ZODIAC = Console.ReadLine();
                BOOK[i].BDAY = new int[3]; // Создаем массив из трех чисел
                Console.Write("День рождения (день): ");
                BOOK[i].BDAY[0] = int.Parse(Console.ReadLine());
                Console.Write("День рождения (месяц): ");
                BOOK[i].BDAY[1] = int.Parse(Console.ReadLine());
                Console.Write("День рождения (год): ");
                BOOK[i].BDAY[2] = int.Parse(Console.ReadLine());
            }

            // Сортируем записи по датам дней рождения
            for (i = 0; i < 7; i++)
            {
                for (j = i + 1; j < 8; j++)
                {
                    if (BOOK[i].BDAY[1] > BOOK[j].BDAY[1] ||
                        (BOOK[i].BDAY[1] == BOOK[j].BDAY[1] && BOOK[i].BDAY[0] > BOOK[j].BDAY[0]))
                    {
                        temp = BOOK[i];
                        BOOK[i] = BOOK[j];
                        BOOK[j] = temp;
                    }
                }
            }

            // Выводим информацию о людях, родившихся под заданным знаком Зодиака
            Console.Write("Введите знак Зодиака: ");
            string zodiac = Console.ReadLine();
            bool found = false; // Флаг для проверки наличия записей с заданным знаком Зодиака
            Console.WriteLine("Люди, родившиеся под знаком " + zodiac + ":");
            for (i = 0; i < 8; i++)
            {
                if (BOOK[i].ZODIAC == zodiac)
                {
                    Console.WriteLine("{0} ({1}.{2}.{3})", BOOK[i].NAME, BOOK[i].BDAY[0], BOOK[i].BDAY[1], BOOK[i].BDAY[2]);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Нет записей о людях, родившихся под заданным знаком Зодиака.");
            }

            Console.ReadKey();
        }
    }
}