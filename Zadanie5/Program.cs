namespace Zadanie5
{
    internal class Program
    {
        static async Task<int> GetDataAsync()
        {
            await Task.Delay(2000);
            return 8;
        }

        static async Task Main()
        {
            Console.WriteLine("Ждем данные...");
            int chislo = await GetDataAsync();
            Console.WriteLine("Данные получены!");
            Console.WriteLine($"Число: {chislo}");
        }
    }
}
