using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Npgsql;

namespace boraler_api.config
{
    public class DataConnection
    {
      string stringConnection = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=bora_ler_data";

      public void Connection()
      {
        var connectionPGSQL = new NpgsqlConnection(stringConnection);

        try
        {
          connectionPGSQL.Open();
          Console.WriteLine("Connected to Postgres successfully!!");

          string query = "Select name FROM teste;";

          var command = new NpgsqlCommand(query, connectionPGSQL);
          var reader = command.ExecuteReader();

          Console.WriteLine("\nTeste in database:\n");

          while (reader.Read()) {
            string name = reader.GetString(0);

            Console.WriteLine($"Name: {name}");
          }
        } catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
      }
    }
}