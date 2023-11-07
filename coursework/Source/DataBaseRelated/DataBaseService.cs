using CourseWork.Source.DataBaseRelated;

using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CourseWork.Source.Services
{
    internal partial class DataBaseService
    {
        private static DataBaseService instance = null;
        private string DataBasesPath = string.Empty;
        private DataBase DataBase = null;
        private DataBaseService() { }
        public static DataBaseService GetInstance()
        {
            if (instance == null)
            {
                instance = new DataBaseService();
                instance.DataBasesPath = "C:/Users/Danil/repos/C#/MANiCURE/DataBases";
                instance.DataBase = new DataBase();
            }
            return instance;
        }
        public void SetNewDataBase(string dataBaseName)
        {
            string dataBasePath = Path.Combine(DataBasesPath, $"{dataBaseName}.db");
            SQLiteConnection.CreateFile(dataBasePath);
            SetConnectionToDataBase(dataBasePath);
            CreateDataTables();
            SetDataBaseToServices();
        }
        public void SetExistingDataBase(string dataBaseName)
        {
            string dataBasePath = Path.Combine(DataBasesPath, $"{dataBaseName}.db");
            SetConnectionToDataBase(dataBasePath);
            SetDataBaseToServices();
        }
        private void SetConnectionToDataBase(string dataBasePath)
        {
            string connectionString = $"Data Source={dataBasePath}; Version=3;";
            DataBase.Connection = new SQLiteConnection(connectionString);
        }
        private void SetDataBaseToServices()
        {
            ClientService.dataBase = DataBase;
            EmployeeService.dataBase = DataBase;
            AppointmentService.dataBase = DataBase;
        }
        private void CreateDataTables()
        {
            SQLiteCommand command = new SQLiteCommand(
                    @"CREATE TABLE clients (
                        phone_number VARCHAR(12) NOT NULL PRIMARY KEY,
                        first_name VARCHAR(20) NOT NULL,
                        last_name VARCHAR(20) NOT NULL,
                        date_of_birth DATE NOT NULL 
                    );
                    CREATE TABLE employees (
                        phone_number VARCHAR(12) NOT NULL PRIMARY KEY,
                        first_name VARCHAR(20) NOT NULL,
                        last_name VARCHAR(20) NOT NULL,
                        date_of_birth DATE NOT NULL 
                    );
                    CREATE TABLE appointments (   
                        client_phone_number VARCHAR(12) NOT NULL,
                        employee_phone_number VARCHAR(12) NOT NULL,
                        date DATE NOT NULL,
                        time TIME NOT NULL,
                        FOREIGN KEY (client_phone_number) REFERENCES clients(phone_number),
                        FOREIGN KEY (employee_phone_number) REFERENCES employees(phone_number)
                    );");
            DataBase.ExecuteCommandNQ(command);
        }
        public bool CheckDataBaseExists(string dataBaseName)
        {
            return File.Exists(Path.Combine(DataBasesPath, $"{dataBaseName}.db"));
        }
        [GeneratedRegex("^[A-Za-zА]{3,15}$")]
        public static partial Regex RegexDataBaseName();
        public static string GetRequirementsForDataBaseName()
        {
            return "Некорректное имя для базы данных. Имя должно состоять из латинских букв и быть длиной от 3 до 15 символов";
        }
    }
}

