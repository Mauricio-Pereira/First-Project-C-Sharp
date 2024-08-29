using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using CP01_TEST;
using HtmlAgilityPack;

var urlMain = "https://scryfall.com/sets/blb";
var urls = new List<string>();
var cards = new List<SwCard>();
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

    var cardName = HttpUtility.HtmlDecode(htmlCard.DocumentNode.SelectSingleNode("//*[@class='card-text-title']").InnerText.Trim());
    cardName = System.Text.RegularExpressions.Regex.Replace(cardName, @"\s+", " ");
    var cardDesc = htmlCard.DocumentNode.SelectSingleNode("//*[@class='card-text-oracle']");
    // Seleciona todos os parágrafos dentro do cardDescNode
    var paragraphs = cardDesc.SelectNodes(".//p");
    
    // Concatena o texto de todos os parágrafos
    var cardDescText = string.Join(" ", paragraphs.Select(p => HttpUtility.HtmlDecode(p.InnerText.Trim().Replace("\r\n", " ")
        .Replace("\n", " ")
        .Replace("\r", " "))));
    cards.Add(new SwCard(cardName, cardDescText));
    
    
    html = null;
    GC.Collect();
});

using (var context = new SwCardsDbContext())
{
    context.Database.EnsureCreated();
    context.SWCARDS.AddRange(cards);
    context.SaveChanges();
    var cardsDb = context.SWCARDS.ToList();
    var csv = new StringBuilder();
    csv.AppendLine("ID | NAME | DESCRIPTION");
    foreach (var card in cardsDb)
    {
        csv.AppendLine($"{card.ID} | {card.NAME} | {card.DESCRIPTION}");
    }
    File.WriteAllText("cards.csv", csv.ToString(), Encoding.UTF8);
}

Console.WriteLine("Fim do programa");
