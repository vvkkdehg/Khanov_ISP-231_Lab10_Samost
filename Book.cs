public class Book : IPrintable
{
    public string name { get; set; }
    public string avtor { get; set; }
    public int year { get; set; }

    public Book(string name, string avtor, int year)
    {
        this.name = name;
        this.avtor = avtor;
        this.year = year;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Название: '{name}', Автор: {avtor}, Год: {year}");
    }
}
