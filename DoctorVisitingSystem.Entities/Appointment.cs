using System;

namespace DoctorVisitingSystem.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDateTimeStart { get; set; }
        public DateTime AppointmentDateTimeFinish { get; set; }
        public Doctor DoctorEntity { get; set; }
        public Patient PatientEntity { get; set; }
    }


}
