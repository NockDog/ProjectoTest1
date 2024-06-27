using System;
using System.Collections.Generic;

namespace ProyectoMatricula
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string IdentificationNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Grade { get; set; }
        public string PreviousSchool { get; set; }
        public string AcademicHistory { get; set; }
        public string GuardianName { get; set; }
        public string GuardianId { get; set; }
        public string GuardianAddress { get; set; }
        public string GuardianPhoneNumber { get; set; }
        public string GuardianEmail { get; set; }
        public string GuardianOccupation { get; set; }
        public string HealthStatus { get; set; }
        public string MedicalInsurance { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public List<string> Subjects { get; set; }

        public Student()
        {
            Subjects = new List<string>();
        }

        public double CalculateTotalCost()
        {
            double baseCost = 6000.00; // Costo base del formulario
            double subjectCost = 20000.00; // Costo por materia

            // Calcula el costo total sumando el costo base y el costo por cada materia seleccionada
            double totalCost = baseCost + (Subjects.Count * subjectCost);

            return totalCost;
        }
    }
}
