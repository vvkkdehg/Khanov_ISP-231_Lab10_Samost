public class Teacher : IPerson
{
    public string name { get; set; }
    public string predmet { get; set; }
    public string kafedra { get; set; }

    public Teacher(string name, string predmet, string kafedra)
    {
        this.name = name;
        this.predmet = predmet;
        this.kafedra = kafedra;
    }
    public void GetDescription() 
    {
        Console.WriteLine($"Имя: {name}, Предмет: {predmet}, Кафедра: {kafedra}");
    }
}
