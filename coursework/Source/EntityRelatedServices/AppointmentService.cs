using CourseWork.Source.DataBaseRelated;
using CourseWork.Source.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;

namespace CourseWork.Source.Services
{
    internal class AppointmentService
    {
        public static DataBase dataBase { get; set; } = null;
        private const string TableName = "appointments";
        public static readonly Dictionary<string, string> ColumnMapping = new Dictionary<string, string>()
        {
            { "Client", "client_phone_number" },
            { "Employee", "employee_phone_number" },
            { "Date", "date" },
            { "Time", "time"}
        };
        #region CRUD operations
        public List<string> GetAvailableTimeForAppointment(string employeePhoneNumber, DateTime date)
        {
            SQLiteCommand command = new SQLiteCommand($"SELECT {ColumnMapping["Time"]} FROM `{TableName}` " +
                $"WHERE {ColumnMapping["Employee"]}=@employeePhoneNumber " +
                $"AND {ColumnMapping["Date"]}=@dateOfAppointment;");

            command.Parameters.AddWithValue("@employeePhoneNumber", employeePhoneNumber);
            command.Parameters.AddWithValue("@dateOfAppointment", date.ToString("yyyy-MM-dd"));

            var NotContainsHour = (int hour, List<DateTime> times) => {
                foreach (DateTime time in times)
                {
                    if (time.Hour == hour) return false;
                }
                return true;
            };           
            List<DateTime> bookedUpTime = dataBase.GetColumnValuesAsList(command).Select(time => DateTime.Parse(time)).ToList();
            DateTime beginOfWorkDay = new DateTime(1, 1, 1, 10, 0, 0);
            DateTime endOfWorkDay = new DateTime(1, 1, 1, 22, 0, 0);

            List<DateTime> freeTime = Enumerable.Range(0, (int)(endOfWorkDay - beginOfWorkDay).TotalHours + 1)
                                     .Select(hour => beginOfWorkDay.AddHours(hour))
                                     .Where(time => NotContainsHour(time.Hour, bookedUpTime))
                                     .ToList();

            return freeTime.Select(time => GetFormatTime(time))
                                     .ToList();
        }
        public DataTable GetDataTableForTheDate(DateTime date)
        {
            var command = new SQLiteCommand($"SELECT * FROM `{TableName}` " +
                $"WHERE {ColumnMapping["Date"]}=@date;");

            command.Parameters.AddWithValue("@date", GetFormatDate(date));
            return  dataBase.GetDataTable(command);
           
        }
        public void Save(Appointment appointment)
        {
            if (Exists(appointment))
            {
                throw new Exception("Добавление невозможно: это время у мастера занято.");
            }
            var command = new SQLiteCommand($"INSERT INTO `{TableName}` (" +
                $"{ColumnMapping["Client"]}, {ColumnMapping["Employee"]}, {ColumnMapping["Date"]}, {ColumnMapping["Time"]}) " +
                $"VALUES(@client, @employee, @date, @time);");

            command.Parameters.AddWithValue("@client", appointment.clientPhoneNumber);
            command.Parameters.AddWithValue("@employee", appointment.employeePhoneNumber);
            command.Parameters.AddWithValue("@date", GetFormatDate(appointment.dateTime));
            command.Parameters.AddWithValue("@time", GetFormatTime(appointment.dateTime));
            dataBase.ExecuteCommandNQ(command);
        }
        public void DeleteAll()
        {
            var command = new SQLiteCommand($"DELETE FROM `{TableName}`;");
            dataBase.ExecuteCommandNQ(command);
        }
        #endregion
        #region Helper Methods
        public bool Exists(Appointment appointment)
        {
            var command = new SQLiteCommand($"SELECT COUNT(*) FROM `{TableName}` " +
                $"WHERE {ColumnMapping["Employee"]}=@employee " +
                $"AND {ColumnMapping["Date"]}=@date " +
                $"AND {ColumnMapping["Time"]}=@time;");

            command.Parameters.AddWithValue("@employee", appointment.employeePhoneNumber);
            command.Parameters.AddWithValue("@date", GetFormatDate(appointment.dateTime));
            command.Parameters.AddWithValue("@time", GetFormatTime(appointment.dateTime));
            return Convert.ToInt32(dataBase.ExecuteCommandScalar(command)) != 0;
        }
        public string GetFormatDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
        public string GetFormatTime(DateTime time)
        {
            return time.ToString("HH:mm");
        }
        #endregion
    }
}
