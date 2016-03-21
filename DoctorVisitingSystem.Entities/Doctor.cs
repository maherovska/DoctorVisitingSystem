using System;

namespace DoctorVisitingSystem.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan ArrivingTime { get; set; }
        public TimeSpan LeavingTime { get; set; }
        public TimeSpan StartingTimeOfBreak { get; set; }
        public TimeSpan FinishingTimeOfBreak { get; set; }
        public TimeSpan AppointmentDuration { get; set; }
    }
}
