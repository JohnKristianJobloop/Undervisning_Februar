using HTTP_Client.Services;

Console.WriteLine("Hello, World!");
var client = new HttpClient();

//var result = await client.GetAsync("https://www.nrk.no/");

//await File.AppendAllTextAsync("./result.html", await result.Content.ReadAsStringAsync());

//Console.WriteLine(result.StatusCode);

var paraService = new ParallellService(client);

var seqService = new SequentialService(client);

List<string> endpoints = [
    "https://icanhazdadjoke.com/",
    "https://official-joke-api.appspot.com/random_joke",
    "https://api.chucknorris.io/jokes/random"
];

await seqService.SendSequentialRequestsWithStopwatch(endpoints);

await paraService.SendParallellRequestWithStopwatch(endpoints);