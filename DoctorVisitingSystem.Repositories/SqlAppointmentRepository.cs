using System;
using System.Collections.Generic;
using DoctorVisitingSystem.Entities;
using System.Data.SqlClient;

namespace DoctorVisitingSystem.Repositories
{
    public class SqlAppointmentRepository : IAppointmentRepository
    {
        #region Queries

        private const string MakeAppointmentQuery = "spMakeAnAppointment";
        private const string GetAppointmentsByPatientNameQuery = "spGetAllApointmentByPatientName";

        #endregion

        #region Private fields

        private readonly string _connectionString;

        #endregion

        #region Constructor

        public SqlAppointmentRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region IAppointmentRepository

        public Appointment MakeAppointment(string firstName, string lastName, DateTime dateOfBirth, string address, string doctorsName, DateTime appointmentDateTime)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(MakeAppointmentQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddRange(new SqlParameter[]
                                                {
                                                    new SqlParameter { ParameterName = "@firstName", Value = firstName },
                                                    new SqlParameter { ParameterName = "@lastName", Value = lastName },
                                                    new SqlParameter { ParameterName = "@dateOfBirth", Value = dateOfBirth },
                                                    new SqlParameter { ParameterName = "@address", Value = address },
                                                    new SqlParameter { ParameterName = "@doctorsName", Value = doctorsName },
                                                    new SqlParameter { ParameterName = "@appointmentDateTime", Value = appointmentDateTime }
                                                });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Appointment appointmentFullInfo = null;

                        if (reader.Read())
                        {
                            appointmentFullInfo = new Appointment
                            {
                                PatientEntity = new Patient
                                {
                                    FirstName = firstName,
                                    LastName = lastName
                                },
                                DoctorEntity = new Doctor
                                {
                                    Name = doctorsName
                                },
                                AppointmentDateTimeStart = appointmentDateTime,
                                AppointmentDateTimeFinish = (DateTime)reader["AppointmentDateTimeFinish"]
                            };
                        }

                        return appointmentFullInfo;
                    }
                }
            }
        }

        public IEnumerable<Appointment> GetAllApointmentByPatientName(string firstName, string lastName, DateTime dateOfBirth, string address)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetAppointmentsByPatientNameQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddRange(new SqlParameter[]
                                                {
                                                    new SqlParameter { ParameterName = "@firstName", Value = firstName },
                                                    new SqlParameter { ParameterName = "@lastName", Value = lastName },
                                                    new SqlParameter { ParameterName = "@dateOfBirth", Value = dateOfBirth },
                                                    new SqlParameter { ParameterName = "@address", Value = address }
                                                });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Appointment> appointments = new List<Appointment>();
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment
                                                {
                                                    PatientEntity = new Patient
                                                                    {
                                                                        FirstName = (string)reader["FirstName"],
                                                                        LastName = (string)reader["LastName"]
                                                                    },
                                                    DoctorEntity = new Doctor
                                                                    {
                                                                        Name = (string)reader["Name"]
                                                                    },
                                                    AppointmentDateTimeStart = (DateTime)reader["AppointmentDateTimeStart"],
                                                    AppointmentDateTimeFinish = (DateTime)reader["AppointmentDateTimeFinish"]
                                                });
                        }

                        return appointments;
                    }
                }
            }
        }

        #endregion
    }
}
