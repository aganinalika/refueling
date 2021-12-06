using refueling.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace refueling.Repository
{
    public class RefuellerStorage
    {
        private Dictionary<int, Refueller> Refuellers { get; } = new Dictionary<int, Refueller>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public RefuellerStorage() => Connection.Open();

        public void Create(Refueller refueller)
        {
            Refuellers.Add(refueller.RefuellerId, refueller);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Refueller Read(int RefuellerId)
        {
            return Refuellers[RefuellerId];
        }

        public Refueller Update(int RefuellerId, Refueller newRefueller)
        {
            Refuellers[RefuellerId] = newRefueller;
            return Refuellers[RefuellerId];
        }

        public bool Delete(int RefuellerId)
        {
            return Refuellers.Remove(RefuellerId);
        }
    }
}