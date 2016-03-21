using System;
using System.Collections.Generic;
using DoctorVisitingSystem.Entities;
using System.Data.SqlClient;

namespace DoctorVisitingSystem.Repositories
{
    public class SqlPatientRepository : IPatientRepository
    {
        #region Queries

        private const string GetAllPatientsQuery = "spGetPatientsByLastName";
        private const string GetPatientsToDoctorQuery = "spGetPatientsByDoctorIdAndDate";
        private const string GetPatientsCountToDoctorQuery = "spGetPatientsCountByDoctorIdAndDate";

        #endregion

        #region Private fields

        private readonly string _connectionString;

        #endregion

        #region Constructor

        public SqlPatientRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region IPatientRepository

        public IEnumerable<Patient> GetPatientsByLastName(string lastName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(GetAllPatientsQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@lastName", lastName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Patient> patients = new List<Patient>();
                        while (reader.Read())
                        {
                            patients.Add(new Patient
                                        {
                                            Id = (int)reader["Id"],
                                            FirstName = (string)reader["FirstName"],
                                            LastName = (string)reader["LastName"],
                                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                                            Address = (string)reader["Address"]
                                        });
                        }

                        return patients;
                    }
                }
            }
        }        

        public IEnumerable<Appointment> GetPatientsByDoctorIdAndDate(int doctorId, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetPatientsToDoctorQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddRange(new SqlParameter[]
                                                {
                                                    new SqlParameter { ParameterName = "@date", Value = date },
                                                    new SqlParameter { ParameterName = "@doctorId", Value = doctorId }
                                                });
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Appointment> patients = new List<Appointment>();
                        while (reader.Read())
                        {
                            patients.Add(new Appointment
                                        {
                                            AppointmentDateTimeStart = (DateTime)reader["AppointmentTime"],
                                            PatientEntity = new Patient
                                                            {
                                                                FirstName = (string)reader["FirstName"],
                                                                LastName = (string)reader["LastName"]
                                                            }
                                        });
                        }

                        return patients;
                    }
                }
            }
        }

        public int GetPatientsCountByDoctorIdAndDate(int doctorId, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetPatientsCountToDoctorQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddRange(new SqlParameter[]
                                                {
                                                    new SqlParameter { ParameterName = "@date", Value = date },
                                                    new SqlParameter { ParameterName = "@doctorId", Value = doctorId }
                                                });
                    int patientCount = (int)command.ExecuteScalar();

                    return patientCount;
                }
            }
        }

        #endregion
    }
}
