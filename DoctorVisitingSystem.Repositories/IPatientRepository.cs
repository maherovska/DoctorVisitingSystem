using System;
using System.Collections.Generic;
using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatientsByLastName(string lastName);
        IEnumerable<Appointment> GetPatientsByDoctorIdAndDate(int doctorId, DateTime date);
        int GetPatientsCountByDoctorIdAndDate(int doctorId, DateTime date);        
    }
}
