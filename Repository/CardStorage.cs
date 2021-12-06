using refueling.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace refueling.Repository
{
    public class CardStorage
    {
        private Dictionary<int, Card> Cards { get; } = new Dictionary<int, Card>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public Cardtorage() => Connection.Open();

        public void Create(Card card)
        {
            Cards.Add(card.CardId, card);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Card Read(int CardId)
        {
            return Cards[CardId];
        }

        public Card Update(int CardId, Card newCard)
        {
            Cards[CardId] = newCard;
            return Cards[CardId];
        }

        public bool Delete(int CardId)
        {
            return Cards.Remove(CardId);
        }
    }
}