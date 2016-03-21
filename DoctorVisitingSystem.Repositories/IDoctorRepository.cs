using System;
using System.Collections.Generic;
using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctorById(int id);      
        IEnumerable<string> GetAvaiableDoctorByDateTime(DateTime dateTime);
        IDictionary<string, int> GetDoctorsRating(DateTime timeFrom, DateTime timeTo);
    }
}
