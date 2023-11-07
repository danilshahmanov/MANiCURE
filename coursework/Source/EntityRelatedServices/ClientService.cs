using CourseWork.Source.Entities;
using CourseWork.Source.DataBaseRelated;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace CourseWork.Source.Services
{
    internal partial class ClientService
    {
        public static DataBase dataBase = null;
        private const string TableName = "clients";
        public static readonly Dictionary<string, string> ColumnMapping = new Dictionary<string, string>()
        {
            { "FirstName", "first_name" },
            { "LastName", "last_name" },
            { "PhoneNumber", "phone_number" },
            { "DateOfBirth", "date_of_birth"}
        };
        #region CRUD Operations
        public Person GetByPhoneNumber(string phoneNumber)
        {
            var fields = LoadFields(phoneNumber);
            return new Person()
            {
                firstName = fields[ColumnMapping["FirstName"]],
                lastName = fields[ColumnMapping["LastName"]],
                phoneNumber = fields[ColumnMapping["PhoneNumber"]],
                dateOfBirth = DateTime.Parse(fields[ColumnMapping["DateOfBirth"]]),
                role = Person.Roles.Client
            };
        }
        public DataTable GetDataTableOfAll()
        {
            var command = new SQLiteCommand($"SELECT * FROM `{TableName}`");
            return dataBase.GetDataTable(command);
        }
        public void Save(Person client)
        {
            if (Exists(client.phoneNumber))
            {
                throw new Exception("Добавление невозможно: номер телефона уже используется.");
            }
            var command = new SQLiteCommand(
                $"INSERT INTO `{TableName}`" +
                $"({ColumnMapping["PhoneNumber"]}, {ColumnMapping["FirstName"]}, " +
                $"{ColumnMapping["LastName"]}, {ColumnMapping["DateOfBirth"]})" +
                $"VALUES (@phoneNumber, @firstName, @lastName, @dateOfBirth);");

            command.Parameters.AddWithValue("@phoneNumber", client.phoneNumber);
            command.Parameters.AddWithValue("@firstName", client.firstName);
            command.Parameters.AddWithValue("@lastName", client.lastName);
            command.Parameters.AddWithValue("@dateOfBirth", GetFormatDateOfBirth(client.dateOfBirth));
            dataBase.ExecuteCommandNQ(command);
        }
        public void Delete(string phoneNumber)
        {
            var command = new SQLiteCommand($"DELETE FROM `{TableName}` " +
                $"WHERE {ColumnMapping["PhoneNumber"]} = @phoneNumber;");

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            dataBase.ExecuteCommandNQ(command);
        }
        public void Update(Person client)
        {
            var command = new SQLiteCommand($"UPDATE " +
                $"`{TableName}` " +
                $"SET {ColumnMapping["FirstName"]}=@firstName, " +
                $"{ColumnMapping["LastName"]}=@lastName, {ColumnMapping["DateOfBirth"]}=@dateOfBirth " +
                $"WHERE {ColumnMapping["PhoneNumber"]}=@phoneNumber;");

            command.Parameters.AddWithValue("@phoneNumber", client.phoneNumber);
            command.Parameters.AddWithValue("@firstName", client.firstName);
            command.Parameters.AddWithValue("@lastName", client.lastName);
            command.Parameters.AddWithValue("@dateOfBirth", GetFormatDateOfBirth(client.dateOfBirth));
            dataBase.ExecuteCommandNQ(command);
        }
        public void DeleteAll()
        {
            var command = new SQLiteCommand($"DELETE FROM `{TableName}`;");
            dataBase.ExecuteCommandNQ(command);
        }
        #endregion
        #region Helper Methods
        public string GetFormatDateOfBirth(DateTime dateOfBirth)
        {
            return dateOfBirth.ToString("yyyy-MM-dd");
        }
        public Dictionary<string, string> LoadFields(string phoneNumber)
        {
            var command = new SQLiteCommand(
                $"SELECT * FROM `{TableName}` " +
                $"WHERE {ColumnMapping["PhoneNumber"]}=@phoneNumber;");

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            return dataBase.GetRowAsDictionary(command);
        }
        private bool Exists(string phoneNumber)
        {
            var command = new SQLiteCommand(
                $"SELECT COUNT(*) FROM `{TableName}` " +
                $"WHERE {ColumnMapping["PhoneNumber"]}=@phoneNumber;");

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            return Convert.ToInt32(dataBase.ExecuteCommandScalar(command)) != 0;
        }
        #endregion
        #region Validation Methods
        [GeneratedRegex("^[A-Za-zА-ЯЁа-яё]{3,15}$")]
        public static partial Regex RegexFirstName();
        public static string GetRequirementsForFirstName()
        {
            return "имя должно состояьть из латинских или кириллических букв и быть длиной от 3 до 15 символов";
        }
        [GeneratedRegex("^[A-Za-zА-ЯЁа-яё]{3,15}$")]
        public static partial Regex RegexLastName();
        public static string GetRequirementsForLastName()
        {
            return "фамилия должна состояьть из латинских или кириллических букв и быть длиной от 3 до 15 символов";
        }
        [GeneratedRegex("^\\+?\\d{1,3}\\s?\\(?\\d{3}\\)?[-.\\s]?\\d{3}[-.\\s]?\\d{4}$")]
        public static partial Regex RegexPhoneNumber();
        public static string GetRequirementsForPhoneNumber()
        {
            return "номер телефона должен быть корректным";
        }
        #endregion
    }
}
