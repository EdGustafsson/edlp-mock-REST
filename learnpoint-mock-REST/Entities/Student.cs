using System;
using System.Collections.Generic;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string NationalRegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string MobilePhone { get; set; }
        public StudentHomeAddress HomeAddress { get; set; }
        public string HomePhone { get; set; }
    }
}
