using System;
using System.Collections.Generic;
using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.Repositories
{
    public interface IAppointmentRepository
    {
        Appointment MakeAppointment(string firstName, string lastName, DateTime dateOfBirth, string address, string doctorsName, DateTime appointmentDateTime);
        IEnumerable<Appointment> GetAllApointmentByPatientName(string firstName, string lastName, DateTime dateOfBirth, string address);
    }
}
