namespace AsyncEnumerablesExample;

static class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Press a key to start the extraction number by number");
        Console.ReadKey();

        var listFetcher = new ListFetcher();

        await foreach (var item in listFetcher.GetAllIntsAsyncEnumerable())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Press a key to start the extraction numbers by batch");
        Console.ReadKey();

        //this will fetch all data first and then it will print the result on the screen on 1 go

        foreach (var item in await listFetcher.GetAllInts())
        {
            Console.WriteLine(item);
        }
    }
}
