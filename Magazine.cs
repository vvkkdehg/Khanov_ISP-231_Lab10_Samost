using System.Xml.Linq;

public class Magazine: IPrintable
{
    public string name { get; set; }
    public string napravl { get; set; }
    public int tirazh { get; set; }

    public Magazine(string name, string napravl, int tirazh)
    {
        this.name = name;
        this.napravl = napravl;
        this.tirazh = tirazh;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Журнал: '{name}', Направление: {napravl}, Тираж: {tirazh}");
    }
}
