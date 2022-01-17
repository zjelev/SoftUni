using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdoNet
{
    class StartUp
    {
        private const string conn = @"Server = .; Integrated security = true";
        private const string dbName = "MinionsDB";

        //IList<Output> outputs = new List<Output>();
        StringBuilder output = new StringBuilder();
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

            // 2. Villain Names
            // Console.WriteLine(GetVillainCountMinions(dbConn));

            // 3. Minion Names
            // Console.Write("Input villain id: ");
            // int villainId = int.Parse(Console.ReadLine());
            // Console.WriteLine(GetMinionsOfAVillain(dbConn, villainId));

            // 4. Add Minion
            // string[] inputFour = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            // string minionName = inputFour[1];
            // int minionAge = int.Parse(inputFour[2]);
            // string town = inputFour[3];
            // inputFour = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            // string villainName = inputFour[1];

            // Console.WriteLine(AddMinion(dbConn, minionName, minionAge, town, villainName));

            // 5. Change Town Names Casing
            //string countryName = Console.ReadLine();
            //Console.WriteLine(ChangeTownNamesCasing(dbConn, countryName));

            // 6. Remove Villain
            // int villainId = int.Parse(Console.ReadLine());
            // Console.WriteLine(RemoveVillainById(dbConn, villainId));

            // 7. Print All Minion Names
            // PrintMinionNames(dbConn);

            // 8. Increase Minion Age
            string ages = Console.ReadLine();
            IncreaseMinionAge(dbConn, ages);

        }

        private static string GetVillainCountMinions(SqlConnection dbConn)
        {
            string query = @"
            SELECT v.Name, COUNT(mv.MinionId) AS MinionCount
                FROM Villains v
                JOIN MinionsVillains mv on v.Id = mv.VillainId
            GROUP BY v.Id, v.Name
            HAVING COUNT(mv.MinionId) > 2
            ORDER BY COUNT(mv.VillainId) ASC";

            using SqlCommand command = new SqlCommand(query, dbConn);
            Console.WriteLine(command.ExecuteScalar()?.ToString());

            StringBuilder sb = new StringBuilder();

            using SqlDataReader reader = command.ExecuteReader();

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

        private static string GetMinionsOfAVillain(SqlConnection dbConn, int villainId)
        {
            string selectVillainName = @"SELECT Name FROM Villains WHERE Id = @villainId";

            using SqlCommand getVillainName = new SqlCommand(selectVillainName, dbConn);
            getVillainName.Parameters.AddWithValue("@villainId", villainId);

            string villainName = getVillainName.ExecuteScalar()?.ToString();

            StringBuilder sb = new StringBuilder();

            if (villainName == null)
            {
                sb.AppendLine($"No villain with ID {villainId} exists in the database.");
                return sb.ToString().TrimEnd();
            }
            else
            {
                sb.AppendLine($"Villain: {villainName}");

                string query = @"
                    SELECT m.[Name], m.[Age] FROM Villains v
                    LEFT OUTER JOIN MinionsVillains mv
                    ON v.Id = mv.VillainId
                    LEFT OUTER JOIN Minions m
                    ON mv.MinionId = m.Id
                    WHERE v.[Name] = @villainName
                    ORDER BY m.[Name]";

                using SqlCommand getMinionsInfo = new SqlCommand(query, dbConn);
                getMinionsInfo.Parameters.AddWithValue("@villainName", villainName);

                using SqlDataReader reader = getMinionsInfo.ExecuteReader();

                if (reader.HasRows)
                {
                    int rowNum = 1;

                    while (reader.Read())
                    {
                        string minionName = reader["Name"]?.ToString();
                        string minionAge = reader["Age"]?.ToString();

                        if (minionName == String.Empty || minionAge == String.Empty)
                        {
                            sb.AppendLine("No minions");
                            break;
                        }

                        sb.AppendLine($"{rowNum}. {minionName} {minionAge}");
                        rowNum++;
                    }
                }
                else
                {
                    sb.AppendLine("No minions");
                }

                return sb.ToString().TrimEnd();
            }
        }

        private static string AddMinion(SqlConnection dbConn, string minionName, int minionAge, string town, string villainName)
        {
            StringBuilder output = new StringBuilder();

            string townId = SelectTownId(dbConn, town, output);

            string villainId = SelectVillainId(dbConn, villainName, output);

            string insertMinion = @"INSERT INTO Minions (Name, Age, TownId)
                                   VALUES (@minionName, @minionAge, @townId)";

            using SqlCommand insertMinionCmd = new SqlCommand(insertMinion, dbConn);
            insertMinionCmd.Parameters.AddRange(new[]
            {
                new SqlParameter("@minionName", minionName),
                new SqlParameter("@minionAge", minionAge),
                new SqlParameter("@townId", townId),
            });

            insertMinionCmd.ExecuteNonQuery();

            string getMinionId = @"SELECT Id FROM Minions WHERE Name = @minionName";
            using SqlCommand getMinionIdCmd = new SqlCommand(getMinionId, dbConn);
            getMinionIdCmd.Parameters.AddWithValue("@minionName", minionName);

            string minionId = getMinionIdCmd.ExecuteScalar()?.ToString();

            string assignMinion = @"INSERT INTO MinionsVillains(MinionId, VillainId) 
                VALUES (@minionId, @villainId)";

            using SqlCommand assignMinionCmd = new SqlCommand(assignMinion, dbConn);
            assignMinionCmd.Parameters.AddRange(new[]
            {
                new SqlParameter("@minionId", minionId),
                new SqlParameter("@villainId", villainId)
            });

            assignMinionCmd.ExecuteNonQuery();

            output.AppendLine($"Successfully added {minionName} to be minion of {villainName}.");
            return output.ToString().TrimEnd();
        }

        private static string SelectVillainId(SqlConnection dbConn, string villainName, StringBuilder output)
        {
            string getVillainId = @"SELECT ID FROM Villains WHERE Name = @name";

            using SqlCommand getVillainIdCmd = new SqlCommand(getVillainId, dbConn);
            getVillainIdCmd.Parameters.AddWithValue("@name", villainName);
            string villainId = getVillainIdCmd.ExecuteScalar()?.ToString();

            if (villainId == null)
            {
                string selectFactorId = @"SELECT Id FROM EvilnessFactors WHERE Name = 'Evil'";
                using SqlCommand selectFactorIdCmd = new SqlCommand(selectFactorId, dbConn);
                string factorId = selectFactorIdCmd.ExecuteScalar()?.ToString();

                string insertVillain = @"INSERT INTO Villains(Name, EvilnessFactorId) 
                                        VALUES (@villainName, @factorId)";
                using SqlCommand insertTownCmd = new SqlCommand(insertVillain, dbConn);
                insertTownCmd.Parameters.AddWithValue("@villainName", villainName);
                insertTownCmd.Parameters.AddWithValue("@factorId", factorId);
                insertTownCmd.ExecuteNonQuery();

                villainId = getVillainIdCmd.ExecuteScalar()?.ToString();

                output.AppendLine($"Villain {villainName} was added to the database.");
            }

            return villainId;
        }

        private static string SelectTownId(SqlConnection dbConn, string town, StringBuilder output)
        {
            string getTownId = @"SELECT ID FROM Towns WHERE Name = @town";

            using SqlCommand getTownIdCmd = new SqlCommand(getTownId, dbConn);
            getTownIdCmd.Parameters.AddWithValue("@town", town);
            string townId = getTownIdCmd.ExecuteScalar()?.ToString();

            if (townId == null)
            {
                string insertTown = @"INSERT INTO Towns(Name, CountryCode) VALUES (@town, 1)";
                using SqlCommand insertTownCmd = new SqlCommand(insertTown, dbConn);
                insertTownCmd.Parameters.AddWithValue("@town", town);
                insertTownCmd.ExecuteNonQuery();

                townId = getTownIdCmd.ExecuteScalar()?.ToString();

                output.AppendLine($"Town {town} was added to the database.");
            }

            return townId;
        }

        private static string ChangeTownNamesCasing(SqlConnection dbConn, string countryName)
        {
            string output = String.Empty;
            List<Town> towns = new List<Town>();

            string changeTownNames = @"update Towns
                        set Name = UPPER(Name)
                        WHERE CountryCode = (SELECT Id FROM Countries WHERE Name = @countryName)";

            using SqlCommand changeTownNamesCmd = new SqlCommand(changeTownNames, dbConn);
            changeTownNamesCmd.Parameters.AddWithValue("@countryName", countryName);
            changeTownNamesCmd.ExecuteScalar();

            string getTownNames = @"select t.Id, t.Name, t.CountryCode from Towns t 
                join Countries c
                on t.CountryCode = c.Id
                WHERE c.Name = @countryName";

            using SqlCommand getTownNamesCmd = new SqlCommand(getTownNames, dbConn);
            getTownNamesCmd.Parameters.AddWithValue("@countryName", countryName);
            using SqlDataReader reader = getTownNamesCmd.ExecuteReader();

            int changedTownsCount = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int townId = int.Parse(reader["Id"]?.ToString());
                    string townName = reader["Name"]?.ToString();
                    int countryCode = int.Parse(reader["CountryCode"]?.ToString());

                    towns.Add(new Town(townId, townName, countryCode));
                    changedTownsCount++;
                }
                
                Console.WriteLine($"{changedTownsCount} town names were affected.");
                Console.Write("[");
                foreach (var town in towns)
                {
                    output += town.Name + ", ";
                };
                
                //towns.ForEach(t => Console.Write("{0}, ", t.Name));
                output = output.Remove(output.Length - 2, 2) + "]";
            }
            else
            {
                output = "No town names were affected.";
            }
            return output;
        }

        private static string RemoveVillainById(SqlConnection dbConn, int villainId)
        {
            StringBuilder sb = new StringBuilder();
            using SqlTransaction sqlTransaction = dbConn.BeginTransaction();

            string getVillainName = @"SELECT [Name] FROM Villains WHERE Id = @villainId";

            using SqlCommand getVillainNameCmd = new SqlCommand(getVillainName, dbConn);
            getVillainNameCmd.Parameters.AddWithValue("@villainId", villainId);
            getVillainNameCmd.Transaction = sqlTransaction;

            string villainName = getVillainNameCmd.ExecuteScalar()?.ToString();
            
            if (villainName == null)
            {
                sb.AppendLine($"No such villain was found.");
            }
            else
            {
                try
                {
                    string releaseMinions = @"DELETE FROM MinionsVillains WHERE VillainId = @villainId";
                    using SqlCommand releaseMinionsCmd = new SqlCommand(releaseMinions, dbConn);
                    releaseMinionsCmd.Parameters.AddWithValue("@villainId", villainId);
                    releaseMinionsCmd.Transaction = sqlTransaction;
                    int releasedMinoinsCount = releaseMinionsCmd.ExecuteNonQuery();
                    
                    string deleteVillain = @"DELETE FROM Villains WHERE Id = @villainId";
                    using SqlCommand deleteVillainCmd = new SqlCommand(deleteVillain, dbConn);
                    deleteVillainCmd.Parameters.AddWithValue("@villainId", villainId);
                    deleteVillainCmd.Transaction = sqlTransaction;
                    deleteVillainCmd.ExecuteNonQuery();

                    sqlTransaction.Commit();

                    sb.AppendLine($"{villainName} was deleted")
                      .AppendLine($"{releasedMinoinsCount} minions were released.");
                }
                catch (Exception ex)
                {
                    sb.AppendLine(ex.Message);

                    try
                    {
                        sqlTransaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        sb.AppendLine(rollbackEx.Message);
                    }
                }
            }
            return sb.ToString().TrimEnd();
        }

        private static void PrintMinionNames(SqlConnection dbConn)
        {
            StringBuilder sb = new StringBuilder();
            string countMinionsQry = @"SELECT (COUNT (*)) FROM MINIONS";
            using SqlCommand countMinionsCmd = new SqlCommand(countMinionsQry, dbConn);
            int minionsCount = int.Parse(countMinionsCmd.ExecuteScalar()?.ToString());

            string[] minions = new string[minionsCount];

            string getMinionNames = @"SELECT [Name] FROM Minions";

            using SqlCommand getMinionNamesCmd = new SqlCommand(getMinionNames, dbConn);
            using SqlDataReader reader = getMinionNamesCmd.ExecuteReader();

            if (reader.HasRows)
            {
                for (int i = 0; reader.Read(); i++)
                {
                    minions[i] = reader["Name"].ToString();
                }
            }

            foreach (var name in minions)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---------");
            string[] minionsMixed = new string[minions.Length];
            int first = 0;
            int last = minionsCount - 1;
            for (int i = 0; i < minions.Length; i++)
            {
                if (i % 2 == 0)
                {
                    minionsMixed[i] = minions[first++];
                }
                else
                {
                    minionsMixed[i] = minions[last--];
                }
            }

            foreach (var name in minionsMixed)
            {
                Console.WriteLine(name);
            }
        }

        private static void IncreaseMinionAge(SqlConnection dbConn, string ages)
        {
            string[] agesArr = ages.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var character in agesArr)
            {
                int minionId = int.Parse(character);
                
                string setMinionAgeName = @"UPDATE Minions SET Age = Age + 1, 
                Name = UPPER(LEFT(Name, 1)) + LOWER(RIGHT(Name, LEN(Name) - 1))
                FROM [MinionsDB].[dbo].[Minions] WHERE Id = @minionId";

                using SqlCommand setMinionAgeNameCmd = new SqlCommand(setMinionAgeName, dbConn);
                setMinionAgeNameCmd.Parameters.AddWithValue("@minionId", minionId);
                setMinionAgeNameCmd.ExecuteScalar();
            }
            
            string selectMinions = @"SELECT [Id], [Name], [Age] FROM Minions";
            using SqlCommand selectMinionsCmd = new SqlCommand(selectMinions, dbConn);
            using SqlDataReader reader = selectMinionsCmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                     Console.WriteLine($"{reader["Name"]?.ToString()} {reader["Age"]?.ToString()}");
                }
            }
        }
    }
}
