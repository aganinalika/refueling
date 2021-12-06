namespace refueling.Domain
{
    public class Card
    {
        public int CardId { get; set; }
        public Client Owner { get; set; }
    }
}