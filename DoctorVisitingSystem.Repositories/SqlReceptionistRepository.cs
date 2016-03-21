using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.Repositories
{
    public class SqlReceptionistRepository : IReceptionistRepository
    {
        #region Queries

        private const string GetReceptionistByLoginQuery = "spGetReceptionistByLogin";

        #endregion

        #region Private fields

        private readonly string _connectionString;

        #endregion

        #region Constructor

        public SqlReceptionistRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region IReceptionistRepository

        public Receptionist GetReceptionistByLogin(string login, string password)
        {
            string encryptedPassword;

            MD5 encryptor = new MD5CryptoServiceProvider();
            encryptor.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = encryptor.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            encryptedPassword = strBuilder.ToString();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(GetReceptionistByLoginQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddRange(new SqlParameter[]
                                                    {
                                                        new SqlParameter { ParameterName = "@login", Value = login },
                                                        new SqlParameter { ParameterName = "@password", Value = encryptedPassword }
                                                    });
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Receptionist receptionist = null;

                        if (reader.Read())
                        {
                            receptionist = new Receptionist();

                            receptionist.Id = (int)reader["Id"];
                            receptionist.FirstName = (string)reader["FirstName"];
                            receptionist.LastName = (string)reader["LastName"];
                            receptionist.Login = (string)reader["Login"];
                            receptionist.Password = (string)reader["Password"];
                        }

                        return receptionist;
                    }
                }
            }
        }

        #endregion
    }
}
