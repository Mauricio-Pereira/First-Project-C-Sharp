// See https://aka.ms/new-console-template for more information
// Modelo de exercício para cp1

using System.Globalization;
using System.Text;
using CsvHelper;
using Exercicio_1___ModeloCP;
using HtmlAgilityPack;


var urls = new List<string>
{
    "https://www.metacritic.com/game/elden-ring-shadow-of-the-erdtree/",
    "https://www.metacritic.com/game/the-elder-scrolls-v-skyrim/",
    "https://www.metacritic.com/game/the-elder-scrolls-v-skyrim-special-edition/",
    "https://www.metacritic.com/game/the-elder-scrolls-v-skyrim-anniversary-edition/"
};

var games = new List<MetacriticGame>();

Parallel.ForEach(urls, url =>
{
    var html = new HtmlWeb().LoadFromWebAsync(url).Result;
    //Get the title of the game
    var title =
        html.DocumentNode.SelectSingleNode(
            "/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[1]/h1");
    //Get the critic score of the game
    var criticScore = html.DocumentNode.SelectSingleNode(
        "/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[4]/div[1]/div/div[1]/div[2]/div/div/span");

    //Get the user score of the game
    var userScore = html.DocumentNode.SelectSingleNode(
        "/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[4]/div[2]/div[1]/div[2]/div/div/span");
    
    games.Add(new MetacriticGame(title.InnerText, criticScore.InnerText, userScore.InnerText));

    html = null;
    GC.Collect();
});
foreach (var game in games)
{
    Console.WriteLine(game.Name);
    Console.WriteLine(game.Metascore);
    Console.WriteLine(game.UserScore);
    Console.WriteLine();
}
//save the data to a csv file
var csv = new StringBuilder();
csv.AppendLine("Name, Metascore, UserScore");
csv.AppendLine(string.Join("\n", games.Select(g => $"{g.Name}, {g.Metascore}, {g.UserScore}")));
File.WriteAllText("games.csv", csv.ToString());




