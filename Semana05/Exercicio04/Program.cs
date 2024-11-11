
class Program{

    static async Task Main(string[] args){
        string URL = "https://gist.github.com/cpdean/5bcc526fe7f1e64cf766#file-doge-md";
        var tasks = new List<Task>{SummonDogLocally(),SummonDogFromURL(URL)};
        await Task.WhenAll(tasks);

    }
    static async Task SummonDogLocally(){

        System.Console.WriteLine("1. Summoning dog locally... ");
        string dogText = await File.ReadAllTextAsync("dog.txt");
        System.Console.WriteLine("2. Dog summoned locally:\n"+dogText);
    }
    static async Task SummonDogFromURL(string URL){
        System.Console.WriteLine("1. Summoning dog from URL... ");
        using(var httpClient = new HttpClient())
        {
            string result = await httpClient.GetStringAsync(URL);
            System.Console.WriteLine("2. Dog summoned from URL:\n"+result);
        }
        
    }
}