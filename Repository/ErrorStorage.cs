using refueling.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace refueling.Repository
{
    public class ErrorStorage
    {
        private Dictionary<int, Error> Errors { get; } = new Dictionary<int, Error>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public ErrorStorage() => Connection.Open();

        public void Create(Error error)
        {
            Errors.Add(error.ErrorId, error);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Error Read(int ErrorId)
        {
            return Errors[ErrorId];
        }

        public Error Update(int ErrorId, Error newError)
        {
            Errors[ErrorId] = newError;
            return Errors[ErrorId];
        }

        public bool Delete(int ErrorId)
        {
            return Errors.Remove(ErrorId);
        }
    }
}