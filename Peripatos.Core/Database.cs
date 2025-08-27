using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Peripatos.Core
{
    public static class Database
    {
        private static SqliteConnection _connection;
        public static SqliteConnection Connection => _connection;

        public static void Connect_PeripatosDB()
        {
            string baseDir = Path.GetFullPath(
                Path.Combine(
                    Path.GetDirectoryName(typeof(Database).Assembly.Location),
                    @"..\..\..\..\Peripatos.Core"
                )
            );
            string dbFolder = Path.Combine(baseDir, "Data");
            string dbPath = Path.Combine(dbFolder, "DB_Peripatos.db");
            if (!File.Exists(dbPath))
                throw new FileNotFoundException("Database file not found.", dbPath);
            else
            {
                Debug.WriteLine("Connected!");
            }

            var connString = new SqliteConnectionStringBuilder { DataSource = dbPath, Cache = SqliteCacheMode.Shared, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();

            _connection = new SqliteConnection(connString);
            _connection.Open();
        }

        public static bool Insert_User(string username, string password)
        {
            if (_connection == null)
                Connect_PeripatosDB();

            // OPTIONAL: hash the password
            // password = HashPassword(password);

            var cmd = _connection.CreateCommand();

            cmd.CommandText = @"
            INSERT INTO [User] (Username, Password)
            VALUES ($username, $password);";

            cmd.Parameters.AddWithValue("$username", username);
            cmd.Parameters.AddWithValue("$password", password);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqliteException)
            {
                return false;
            }
        }

        public static DataTable Select_User(string username, string password)
        {

            var cmd = _connection.CreateCommand();

            cmd.CommandText = @"
            SELECT Username, Password FROM [User] 
            WHERE Username = $username AND Password=$password";

            cmd.Parameters.AddWithValue("$username", username);
            cmd.Parameters.AddWithValue("$password", password);

            cmd.ExecuteNonQuery();

            var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;

        }

        public static DataTable Select_All_Places_Of_Type(string placetype_name)
        {
            var cmd = _connection.CreateCommand();

            cmd.CommandText = @"
            SELECT Place.* 
            FROM Place
            INNER JOIN PlaceType ON Place.fplacetype = PlaceType.placetypeid
            WHERE PlaceType.Name = @name";

            cmd.Parameters.AddWithValue("@name", placetype_name);

            var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }

        public static List<byte[]> Select_All_PlaceImages_Per_Name(int placeid)
        {
            var result = new List<byte[]>();
            var cmd = _connection.CreateCommand();

            cmd.CommandText = @"
            SELECT PlaceImage.ImageBytes
            FROM PlaceImage
            WHERE PlaceImage.fPlaceID = @placeid";

            cmd.Parameters.AddWithValue("@placeid", placeid);

            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                var bytes = (byte[])reader["ImageBytes"];
                result.Add(bytes);
            }

            return result;

        }

        public static void ONETIME_Insert_PlaceImage(string placetype)
        {
            string baseDir = Path.GetFullPath(
                Path.Combine(
                    Path.GetDirectoryName(typeof(Database).Assembly.Location),
                    @"..\..\..\..\Peripatos.Core"
                )
            );
            string DataFolder = Path.Combine(baseDir, "Data");
            string Folder = Path.Combine(DataFolder, placetype);
            string ImagesFolder = Path.Combine(Folder, "Images");


            List<string> folderNames = Directory.GetDirectories(ImagesFolder).Select(Path.GetFileName).ToList();
 

            foreach (string folderName in folderNames)
            {
                Debug.WriteLine($"1");
                using (var insertCmd = _connection.CreateCommand())
                {
                    insertCmd.CommandText = @"
                    INSERT INTO [Place] (
                        Name,
                        description,
                        fPlaceType
                    )
                    VALUES (
                        $Name,
                        $description,
                        $fPlaceType
                    )";
                    
                    insertCmd.Parameters.AddWithValue("$Name", folderName);
                    //CHANGE THIS
                    insertCmd.Parameters.AddWithValue("$fPlaceType", 3);
                    insertCmd.Parameters.AddWithValue("$description", "-");

                    insertCmd.ExecuteNonQuery();
                }
            }

            foreach (string folderName in folderNames)
            {
                //Find the PlaceID from the folderName
                var cmd = _connection.CreateCommand();

                cmd.CommandText = @"
                SELECT Place.PlaceID 
                FROM Place
                WHERE Place.Name = @name";
                cmd.Parameters.AddWithValue("@name", folderName);

                var placeid = cmd.ExecuteScalar();


                //Get all JPG files in the folder
                string folderPath = Path.Combine(ImagesFolder, folderName);
                string[] jpgFiles = Directory.GetFiles(folderPath, "*.jpg", SearchOption.TopDirectoryOnly);


                //For each image in the folder insert to the database
                foreach (string filePath in jpgFiles)
                {
                    byte[] imageBytes = File.ReadAllBytes(filePath);

                    using (var insertCmd = _connection.CreateCommand())
                    {
                        insertCmd.CommandText = @"
                    INSERT INTO [PlaceImage] (
                        fPlaceID,
                        ImageBytes
                    )
                    VALUES (
                        $fplaceid,
                        $imagebytes
                    )";
                        insertCmd.Parameters.AddWithValue("$fplaceid", placeid);
                        insertCmd.Parameters.AddWithValue("$imagebytes", imageBytes);

                        insertCmd.ExecuteNonQuery();
                    }

                    Debug.WriteLine($"Inserted image {Path.GetFileName(filePath)} for PlaceID {placeid}");
                }

            }

        }


    }
}
