using System;

namespace CourseWork.Source.Entities
{
    internal class Person
    {
        //primary key in database   
        public string phoneNumber = string.Empty;
        public string firstName = string.Empty;
        public string lastName = string.Empty;
        public DateTime dateOfBirth = DateTime.MinValue;
        public Roles role = Roles.Client;

        //roles of persons, matches to DBtables
        public enum Roles
        {
            Client,
            Employee,
        }
        override
        public string ToString()
        {
            return $"phone_number= {phoneNumber}; first_name= {firstName}, " +
                $"last_name= {lastName}, date_of_birth= {dateOfBirth.ToString("yyyy-MM-dd")}, role= {role.ToString()}";
        }
    }
}
