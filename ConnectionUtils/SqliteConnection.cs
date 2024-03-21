using System.Data;
using Mono.Data.Sqlite;
using System.Collections.Generic;
namespace ConnectionUtils;

public class SqliteConnectionFactory : ConnectionFactory
{
    public override IDbConnection createConnection(IDictionary<string,string> props)
    {
        //Mono Sqlite Connection

        //String connectionString = "URI=file:C:/Users/bianc/IdeaProjects/TemaLab1MPP/concurs" ;
        String connectionString = props["ConnectionString"];
        Console.WriteLine("SQLite ---Se deschide o conexiune la  ... {0}", connectionString);
        return new SqliteConnection(connectionString);

        // Windows SQLite Connection, fisierul .db ar trebuie sa fie in directorul debug/bin
        //String connectionString = "Data Source=tasks.db;Version=3";
        //return new SQLiteConnection(connectionString);
    }
}