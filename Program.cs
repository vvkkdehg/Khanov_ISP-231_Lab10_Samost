namespace Khanov_ISP_231_Lab10_Samost
{
    internal class Program
    {
        static async Task<List<Student>> LoadStudentsAsync()
        {
            Console.WriteLine("Загрузка данных о студентах...");
            await Task.Delay(3000);
            Console.WriteLine("Загрузка завершена.");

            return new List<Student>
            {
                new Student("Вадим", 18, "ИСП-231"),
                new Student("Тимофей", 19, "ИСП-233")
            };
            
        }
        static void Main(string[] args)
        {
            //Задание 1
            var student = new { name = "Влад", age = 18, group = "ИСП-231" };
            Console.WriteLine($"Имя: {student.name}, Возраст: {student.age}, Группа: {student.group}");

            var students = new[]
            {
                new {name = "Женя", age = 17, group = "ИСП-231"},
                new {name = "Тимофей", age = 19, group = "ИСП-233"},
                new {name = "Настя", age = 17, group = "ИСП-232"},
                new {name = "Вадим", age = 18, group = "ИСП-231"},
                new {name = "Лариса", age = 19, group = "ИСП-235"}
            };
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("|       Имя       |   Возраст   |       Группа       |");
            Console.WriteLine("______________________________________________________");
            for (var i = 1; i < students.Length; i++)
            {
                Console.WriteLine($"|{students[i].name}{new string(' ', 17 - students[i].name.Length)}|{students[i].age}{new string(' ', 13 - students[i].age.ToString().Length)}|{students[i].group}{new string(' ', 20 - students[i].group.Length)}|");
                Console.WriteLine("______________________________________________________");
            }
            Console.WriteLine();
            //Задание 2
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            List<int> chetn = numbers.FindAll(x => x % 2 == 0);

            List<int> krat3 = numbers.FindAll(x => x % 3 == 0);

            Console.Write("Все числа: ");
            for (var i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1)
                    Console.Write($"{numbers[i]}, ");
                else
                    Console.Write(numbers[i]);
            }
            Console.WriteLine();

            Console.Write("Четные числа: ");
            for (var i = 0; i < chetn.Count; i++)
            {
                if (i < chetn.Count - 1)
                    Console.Write($"{chetn[i]}, ");
                else
                    Console.Write(chetn[i]);
            }
            Console.WriteLine();

            Console.Write("Числа, кратные 3: ");
            for (var i = 0; i < krat3.Count; i++)
            {
                if (i < krat3.Count - 1)
                    Console.Write($"{krat3[i]}, ");
                else
                    Console.Write(krat3[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Задание 3
            Book book = new Book("Горе от ума", "Тургенев", 1833);
            Magazine mag = new Magazine("Forbes", "Бизнес", 1000);
            book.PrintInfo();
            mag.PrintInfo();

            Console.WriteLine();
            //Задание 4
            string[] goroda = {
            "Волжский", "Волгоград", "Москва", "Ленинск", "Киров",
            "Казань", "Краснодар", "Владивосток", "Калининград",
            "Сочи", "Красноярск", "Астрахань", "Саратов"};

            var gorNaK = goroda.Where(gor => gor.StartsWith("К"));
            Console.WriteLine("Города на 'К': ");
            foreach (var i in gorNaK)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            var poDline = goroda.OrderBy(gor => gor.Length);
            Console.WriteLine("Города, отсортированные по длине: ");
            foreach (var i in poDline)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Города, длинной более 6 символов: ");
            var bol6 = goroda.Where(gor => gor.Length > 6);
            foreach (var i in bol6)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Задание 6
            Student std = new Student("Влад", 18, "ИСП-231");
            Teacher tch = new Teacher("Иванов Виктор Петрович", "Численные методы", "Математики");
            std.GetDescription();
            tch.GetDescription();
            var studs = new List<Student>
            {
                new Student("Женя", 17, "ИСП-251"),
                new Student("Ваня", 22, "ИСП-221"),
                new Student("Артем", 21, "ИСП-233"),
                new Student("Тимур", 24, "ИСП-235"),
                new Student("Вадим", 19, "ИСП-231")
            };
            var teachs = new List<Teacher>
            {
                new Teacher("Ольга Викторовна Топтыгина", "Дискретная математика", "Математики"),
                new Teacher("Виктор Константинович Маресьев", "История России", "Истории"),
                new Teacher("Константин Викторович Булкин", "Уголовное право", "Юриспруденции"),
                new Teacher("Элеанора Владимировна Исаева", "История Древнего мира", "Истории"),
                new Teacher("Булат Елисеевич Добрынин", "Высшая математика", "Математики"),
            };
            Console.WriteLine();
            var stud20 = studs.Where(s => s.age > 20);
            Console.WriteLine("Студенты старше 20 лет:");
            foreach (var i in stud20)
            {
                i.GetDescription();
            }
            Console.WriteLine();
            var teachKaf = teachs.Where(t => t.kafedra == "Математики");
            Console.WriteLine("Преподаватели кафедры Математики:");
            foreach (var i in teachKaf)
            {
                i.GetDescription();
            }
            Console.WriteLine();

            var zagruz = LoadStudentsAsync().GetAwaiter().GetResult();
            foreach (var i in zagruz)
            {
                i.GetDescription();
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка");
            var sortStud = studs.OrderBy(s => s.name);
            var sortTeach = teachs.OrderBy(t => t.name);
            foreach (var i in sortStud)
            {
                i.GetDescription();
            }
            Console.WriteLine();
            foreach (var i in sortTeach)
            {
                i.GetDescription();
            }
        }
    }
}
