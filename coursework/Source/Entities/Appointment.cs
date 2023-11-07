using System;

namespace CourseWork.Source.Entities
{
    internal class Appointment
    {
        public string clientPhoneNumber { get; set; } = string.Empty;
        public string employeePhoneNumber { get; set; } = string.Empty;
        public DateTime dateTime { get; set; } = DateTime.MinValue;
        override
        public string ToString()
        {
            return $"client_phone_number= {clientPhoneNumber}; employee_phone_number= {employeePhoneNumber}; " +
                $"date= {dateTime.ToString("yyyy-MM-dd")}; time= {dateTime.ToString("HH:mm")};";
        }
    }
}
