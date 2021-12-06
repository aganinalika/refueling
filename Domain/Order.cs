namespace refueling.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public float OrderPrice { get; set; }
        public Client Client { get; set; }
        public bool IsPayed { get; set; }
    }
}