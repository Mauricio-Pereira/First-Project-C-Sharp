namespace CP01_TEST;

public class SwCard
{
    public SwCard()
    {
    }
    public SwCard(string cardName, string cardDescText)
    {
        NAME = cardName;
        DESCRIPTION = cardDescText;
    }

    public int ID { get; set; }
    public string NAME { get; set; }
    public string DESCRIPTION { get; set; }
    
}