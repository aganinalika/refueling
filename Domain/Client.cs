namespace refueling.Domain
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public Car Car { get; set; }
    }
}