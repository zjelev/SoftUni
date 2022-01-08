using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdoNet
{
    class StartUp
    {
        private const string conn = @"Server = .\SQLEXPRESS; Integrated security = true";
        private const string dbName = "MinionsDB";

        IList<Output> outputs = new List<Output>();
        static void Main(string[] args)
        {
            string createDB = $"CREATE DATABASE {dbName}";
            string useDB = $"USE {dbName}";

            string createTables = useDB + @"
                    CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50))
                    CREATE TABLE Towns(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50), CountryCode INT FOREIGN KEY REFERENCES Countries(Id))
                    CREATE TABLE Minions(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(30), Age INT, TownId INT FOREIGN KEY REFERENCES Towns(Id))
                    CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))
                    CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))
                    CREATE TABLE MinionsVillains (MinionId INT FOREIGN KEY REFERENCES Minions(Id),VillainId INT FOREIGN KEY REFERENCES Villains(Id),CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId))";
            
            string insertValues = useDB + @"
                    INSERT INTO Countries ([Name]) VALUES ('Bulgaria'),('England'),('Cyprus'),('Germany'),('Norway')
                    INSERT INTO Towns ([Name], CountryCode) VALUES ('Plovdiv', 1),('Varna', 1),('Burgas', 1),('Sofia', 1),('London', 2),('Southampton', 2),('Bath', 2),('Liverpool', 2),('Berlin', 3),('Frankfurt', 3),('Oslo', 4)
                    INSERT INTO Minions (Name,Age, TownId) VALUES('Bob', 42, 3),('Kevin', 1, 1),('Bob ', 32, 6),('Simon', 45, 3),('Cathleen', 11, 2),('Carry ', 50, 10),('Becky', 125, 5),('Mars', 21, 1),('Misho', 5, 10),('Zoe', 125, 5),('Json', 21, 1)
                    INSERT INTO EvilnessFactors (Name) VALUES ('Super good'),('Good'),('Bad'), ('Evil'),('Super evil')
                    INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru',2),('Victor',1),('Jilly',3),('Miro',4),('Rosen',5),('Dimityr',1),('Dobromir',2)
                    INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (4,2),(1,1),(5,7),(3,5),(2,6),(11,5),(8,4),(9,7),(7,1),(1,3),(7,3),(5,3),(4,3),(1,2),(2,1),(2,7)";
            
            using SqlConnection dbConn = new SqlConnection(conn);
            dbConn.Open();

            // SqlCommand command = new SqlCommand(createDB, dbConn);

            using SqlCommand command = new SqlCommand(useDB, dbConn);
            command.ExecuteScalar();

            // command = new SqlCommand(createTables, dbConn);
            // command.ExecuteScalar();

            // command = new SqlCommand(insertValues, dbConn);
            // command.ExecuteScalar();
            
            Console.WriteLine(getVillainCountMinions(dbConn));
        }

        private static string getVillainCountMinions(SqlConnection dbConn)
        {            
            string selectVillainCountMinions = @"
            SELECT v.Name, COUNT(mv.MinionId) AS MinionCount
                FROM Villains v
                JOIN MinionsVillains mv on v.Id = mv.VillainId
            GROUP BY v.Id, v.Name
            HAVING COUNT(mv.MinionId) > 2
            ORDER BY COUNT(mv.VillainId) DESC";

            using SqlCommand command = new SqlCommand(selectVillainCountMinions, dbConn);
            //string result = command.ExecuteScalar()?.ToString();

            using SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string villainName = reader["Name"]?.ToString();
                    string minionCount = reader["MinionCount"]?.ToString();

                    sb.AppendLine($"{villainName} - {minionCount}");
                }
            }
            else
            {
                sb.AppendLine("No rows");
            }

            return sb.ToString().TrimEnd();
        }
    }
}