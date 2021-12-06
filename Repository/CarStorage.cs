using refueling.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace refueling.Repository
{
    public class CarStorage
    {
        private Dictionary<int, Car> Cars { get; } = new Dictionary<int, Car>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CarStorage() => Connection.Open();

        public void Create(Car car)
        {
            Cars.Add(car.CarId, car);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Car Read(int CarId)
        {
            return Cars[CarId];
        }

        public Car Update(int CarId, Car newCar)
        {
            Cars[CarId] = newCar;
            return Cars[CarId];
        }

        public bool Delete(int CarId)
        {
            return Cars.Remove(CarId);
        }
    }
}