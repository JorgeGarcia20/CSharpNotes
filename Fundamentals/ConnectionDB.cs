using Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class ConnectionDB: IDBActions<Beer>
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=beverages_db;User=JorgeGarcia;Password=mysecret";

        public bool Add(Beer beer)
        {
            int result;
            string query = "INSERT INTO beers(beer_name, brand, alcohol_percentage, price, quantity)" +
                "VALUES(@beer_name, @brand, @alcohol_percentage, @price, @quantity)";
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@beer_name", beer.Name);
                command.Parameters.AddWithValue("@brand", beer.Brand);
                command.Parameters.AddWithValue("@alcohol_percentage", beer.AlcoholPercentage);
                command.Parameters.AddWithValue("@price", beer.Price);
                command.Parameters.AddWithValue("@Quantity", beer.Quantity);

                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result > 0;
        }

        public List<Beer> Get()
        {
            List<Beer> beers = new List<Beer>();
            string query = "SELECT beer_name, brand, alcohol_percentage, price, quantity FROM beers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string name = dataReader.GetString(0);
                    string brand = dataReader.GetString(1);
                    decimal alcohol_percentage = dataReader.GetDecimal(2);
                    decimal price = dataReader.GetDecimal(3);
                    int quantity = dataReader.GetInt32(4);

                    Beer beer = new(name, brand, alcohol_percentage, price, quantity);

                    beers.Add(beer);
                }
                dataReader.Close();

                connection.Close();
            }
            return beers;
        }

        public bool Remove(int Id)
        {
            int result;
            string query = "DELETE FROM beers WHERE id = @Id ";

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result > 0;
        }

        public bool Update(Beer beer, int Id)
        {
            int result;
            string query = "UPDATE beers SET beer_name = @beer_name, brand = @brand, " +
                "alcohol_percentage = @alcohol_percentage, price = @price, quantity = @quantity " +
                "WHERE id = @id";
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@beer_name", beer.Name);
                command.Parameters.AddWithValue("@brand", beer.Brand);
                command.Parameters.AddWithValue("@alcohol_percentage", beer.AlcoholPercentage);
                command.Parameters.AddWithValue("@price", beer.Price);
                command.Parameters.AddWithValue("@Quantity", beer.Quantity);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result > 0;
        }
    }
}
