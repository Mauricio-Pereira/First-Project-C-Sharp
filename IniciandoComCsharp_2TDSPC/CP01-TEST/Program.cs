using System.Text;
using CP01_TEST;
using HtmlAgilityPack;

var urlMain = "https://scryfall.com/sets/dsk";
var urls = new List<string>();
var cardsName = new List<string>();


var html = new HtmlWeb().LoadFromWebAsync(urlMain).Result;
var mainDiv = html.DocumentNode.SelectNodes("//*[@class='card-grid-inner']");

// Seleciona todos os links <a> dentro das divs que estão dentro da div principal
foreach (var node in mainDiv)
{
    urls.AddRange(node.Descendants("a").Select(a => a.GetAttributeValue("href", string.Empty)));
}

Parallel.ForEach(urls, link =>
{
    var htmlCard = new HtmlWeb().LoadFromWebAsync(link).Result;

    var cardName = htmlCard.DocumentNode.SelectSingleNode("/html/body/div[3]/div[1]/div/div[3]/h1/span[1]");
    var cardDesc = htmlCard.DocumentNode.SelectSingleNode("//*[@class='card-text-box']");
    // Seleciona todos os parágrafos dentro do cardDescNode
    var paragraphs = cardDesc.SelectNodes(".//p");
    
    // Concatena o texto de todos os parágrafos
    var cardDescText = string.Join(" ", paragraphs.Select(p => p.InnerText.Trim()));
    cardsName.Add(cardDesc.InnerText.Trim());
    Console.WriteLine(link);
    html = null;
    GC.Collect();
});


foreach (var name  in cardsName)
{
    Console.WriteLine(name);
}

var csv = new StringBuilder();
csv.AppendLine("Name");
csv.AppendLine(string.Join("\n", cardsName.Select(g => $"{g}")));
File.WriteAllText("cards.csv", csv.ToString());