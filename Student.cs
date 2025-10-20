public class Student : IPerson
{
    public string name { get; set; }
    public int age { get; set; }
    public string group { get; set; }

    public Student(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
    }

    public void GetDescription()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Группа: {group}");
    }
}