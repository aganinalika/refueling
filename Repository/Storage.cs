namespace refueling.Repository
{
    public static class Storage
    {
        public static CardStorage CardStorage { get; } = new CardStorage();
        public static CarStorage CarStorage { get; } = new CarStorage();
        public static ClientStorage ClientStorage { get; } = new ClientStorage();
        public static CommentStorage CommentStorage { get; } = new CommentStorage();
        public static ErrorStorage ErrorStorage { get; } = new ErrorStorage();
        public static OrderStorage OrderStorage { get; } = new OrderStorage();
        public static RefuellerStorage RefuellerStorage { get; } = new RefuellerStorage();
        public static StationStorage StationStorage { get; } = new StationStorage();
       
    }
}