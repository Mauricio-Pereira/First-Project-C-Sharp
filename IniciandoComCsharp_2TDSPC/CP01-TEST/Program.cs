using System.Text;
using System.Web;
using CP01_TEST;
using HtmlAgilityPack;

var urlMain = "https://scryfall.com/sets/pcbb";
var urls = new List<string>();
var cards = new List<SwCards>();
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

    var cardName = htmlCard.DocumentNode.SelectSingleNode("//*[@class='card-text-card-name']");
    var cardDesc = htmlCard.DocumentNode.SelectSingleNode("//*[@class='card-text-oracle']");
    // Seleciona todos os parágrafos dentro do cardDescNode
    var paragraphs = cardDesc.SelectNodes(".//p");
    
    // Concatena o texto de todos os parágrafos
    var cardDescText = string.Join(" ", paragraphs.Select(p => HttpUtility.HtmlDecode(p.InnerText.Trim().Replace("\r\n", " ")
        .Replace("\n", " ")
        .Replace("\r", " "))));
    cards.Add(new SwCards(HttpUtility.HtmlDecode(cardName.InnerText.Trim()), cardDescText));
    html = null;
    GC.Collect();
});

var csv = new StringBuilder();
csv.AppendLine("Name | Description");
csv.AppendLine(string.Join("\n", cards.Select(c => $"{c.Nome} | {c.Descricao}")));
File.WriteAllText("cards.csv", csv.ToString(), Encoding.UTF8);