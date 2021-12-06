using refueling.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace refueling.Repository
{
    public class StationStorage
    {
        private Dictionary<int, Station> Stations { get; } = new Dictionary<int, Station>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public StationStorage() => Connection.Open();

        public void Create(Station station)
        {
            Stations.Add(station.StationId, station);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Station Read(int StationId)
        {
            return Stations[StationId];
        }

        public Station Update(int StationId, Station newStation)
        {
            Stations[StationId] = newStation;
            return Stations[StationId];
        }

        public bool Delete(int StationId)
        {
            return Stations.Remove(StationId);
        }
    }
}