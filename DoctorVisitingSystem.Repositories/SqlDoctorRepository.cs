using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.Repositories
{
    public class SqlDoctorRepository : IDoctorRepository
    {    
        #region Queries

        private const string GetDoctorsQuery = "spGetAllDoctors";
        private const string GetDoctorByIdQuery = "spGetDoctorById";
        private const string GetAvaiableDoctorsQuery = "spGetAvaiableDoctorByDateTime";
        private const string GetDoctorsRatingQuery = "spGetDoctorsRating";

        #endregion

        #region Private fields

        private readonly string _connectionString;

        #endregion

        #region Constructor

        public SqlDoctorRepository(string connectionString)
        {
            // IP: ініціалізацію _connectionString можна було б "віддати" базовому класу SqlBaseRepository
            _connectionString = connectionString;
        }

        #endregion

        #region IDoctorRepository

        public IEnumerable<Doctor> GetAllDoctors()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetDoctorsQuery, connection))
                {                  

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Doctor> doctors = new List<Doctor>();
                        while (reader.Read())
                        {
                            doctors.Add(new Doctor 
                                        {
                                            Id = (int)reader["Id"],
                                            Name = (string)reader["Name"],
                                            ArrivingTime = (TimeSpan)reader["ArrivingTime"],
                                            LeavingTime = (TimeSpan)reader["LeavingTime"],
                                            StartingTimeOfBreak = (TimeSpan)reader["StartingTimeOfBreak"],
                                            FinishingTimeOfBreak = (TimeSpan)reader["FinishingTimeOfBreak"],
                                            AppointmentDuration = (TimeSpan)reader["AppointmentDuration"] 
                                    });                            
                        }

                        return doctors;
                    }
                }
            }
        }

        public Doctor GetDoctorById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetDoctorByIdQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@doctorId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Doctor searchedDoctor = new Doctor() { Id = id };
                        if (reader.Read())
                        {
                            searchedDoctor.Name = (string)reader["Name"];
                            searchedDoctor.ArrivingTime = (TimeSpan)reader["ArrivingTime"];
                            searchedDoctor.LeavingTime = (TimeSpan)reader["LeavingTime"];
                            searchedDoctor.StartingTimeOfBreak = (TimeSpan)reader["StartingTimeOfBreak"];
                            searchedDoctor.FinishingTimeOfBreak = (TimeSpan)reader["FinishingTimeOfBreak"];
                            searchedDoctor.AppointmentDuration = (TimeSpan)reader["AppointmentDuration"];
                        }

                        return searchedDoctor;
                    }
                }
            }       
        }

        public IEnumerable<string> GetAvaiableDoctorByDateTime(DateTime dateTime)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetAvaiableDoctorsQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dateTime", dateTime);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> availableDoctorsList = new List<string>();
                        while (reader.Read())
                        {
                            string doctorsName = (string)reader["Name"];
                            availableDoctorsList.Add(doctorsName);
                        }

                        return availableDoctorsList;
                    }
                }
            }
        }

        public IDictionary<string, int> GetDoctorsRating(DateTime timeFrom, DateTime timeTo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetDoctorsRatingQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddRange(new SqlParameter[]
                                                {
                                                    new SqlParameter { ParameterName = "@timeFrom", Value = timeFrom },
                                                    new SqlParameter { ParameterName = "@timeTo", Value = timeTo }
                                                });
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Dictionary<string, int> attendance = new Dictionary<string, int>();
                        while (reader.Read())
                        {
                            attendance.Add((string)reader["Name"], (int)reader["Count"]);
                        }

                        return attendance;
                    }
                }
            }
        }

        #endregion
    }
}
