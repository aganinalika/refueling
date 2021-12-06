namespace refueling.Domain
{
    public class Station
    {
        public int StationId { get; set; }
        public Order Order { get; set; }
        public Refueller Refueller { get; set; }
    }
}
