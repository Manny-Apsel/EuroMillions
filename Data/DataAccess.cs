using System.Globalization;
using CsvHelper;
using Microsoft.Data.Sqlite;

namespace EM
{
    public static class DataAccess
    {
        public static List<CsvData> getDataCsv()
        {
            using (var reader = new StreamReader("Data/euromillionsgamedata-20040213-2022112.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<CsvData>().ToList();
            }
        }

        public static List<CsvData> getDataCsv(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<CsvData>().ToList();
            }
        }

        public static void writeDataCsv(List<Analysis> results)
        {
            using (var writer = new StreamWriter("Data/Results.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // headers
                csv.WriteField("Numbers");
                csv.WriteField("Stars");
                csv.WriteField("Number Zero Hits %");
                csv.WriteField("Number One Hits %");
                csv.WriteField("Number Two Hits %");
                csv.WriteField("Number Three Hits %");
                csv.WriteField("Number Four Hits %");
                csv.WriteField("Number Five Hits %");
                csv.WriteField("Stars Zero Hits %");
                csv.WriteField("Stars One Hits %");
                csv.WriteField("Stars Two Hits %");
                csv.NextRecord();
                foreach (var r in results)
                {
                    if (r.Numbers != null)
                    {
                        csv.WriteField(String.Join(", ", r.Numbers));
                    }
                    else
                    {
                        csv.WriteField("");
                    }
                    if (r.Stars != null)
                    {
                        csv.WriteField(String.Join(", ", r.Stars));
                    }
                    else
                    {
                        csv.WriteField("");
                    }

                    csv.WriteField(r.HitsZeroPercentage);
                    csv.WriteField(r.HitsOnePercentage);
                    csv.WriteField(r.HitsTwoPercentage);
                    csv.WriteField(r.HitsThreePercentage);
                    csv.WriteField(r.HitsFourPercentage);
                    csv.WriteField(r.HitsFivePercentage);
                    csv.WriteField(r.StarsZeroPercentage);
                    csv.WriteField(r.StarsOnePercentage);
                    csv.WriteField(r.StarsTwoPercentage);
                    csv.NextRecord();
                }
            }
        }

        public static void writeDataSqlFiveNum(List<Analysis> results, string table)
        {
            using (var connection = new SqliteConnection("Data Source=Data/Data.db"))
            {
                connection.Open();

                foreach (var r in results)
                {
                    try
                    {
                        string primaryId = "";
                        for (int i = 0; i < r.Numbers.Length; i++)
                        {
                            primaryId += $"{r.Numbers[i].ToString()} ";
                        }
                        var query = $"INSERT INTO {table} VALUES('{primaryId}', {r.HitsZeroPercentage}, {r.HitsOnePercentage}, {r.HitsTwoPercentage}, {r.HitsThreePercentage}, {r.HitsFourPercentage}, {r.HitsFivePercentage});";
                        var command = connection.CreateCommand();
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    catch (System.Exception e)
                    {
                        System.Console.WriteLine(e);
                    }

                }
            }
        }
        public static void writeDataSqlTwoStar(List<Analysis> results, string table)
        {
            using (var connection = new SqliteConnection("Data Source=Data/Data.db"))
            {
                connection.Open();

                foreach (var r in results)
                {
                    try
                    {
                        string primaryId = "";
                        for (int i = 0; i < r.Stars.Length; i++)
                        {
                            primaryId += $"{r.Stars[i].ToString()} ";
                        }
                        var query = $"INSERT INTO {table} VALUES('{primaryId}', {r.StarsZeroPercentage}, {r.StarsOnePercentage}, {r.StarsTwoPercentage});";
                        var command = connection.CreateCommand();
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    catch (System.Exception e)
                    {
                        System.Console.WriteLine(e);
                    }

                }
            }
        }
    }
}