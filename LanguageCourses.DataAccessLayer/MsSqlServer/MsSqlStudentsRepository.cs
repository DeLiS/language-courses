using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.DataAccessLayer.DataAccessObjects;
using LanguageCourses.DataAccessLayer.Interfaces;

namespace LanguageCourses.DataAccessLayer.MsSqlServer
{
    public class MsSqlStudentsRepository : IStudentsRepository
    {
        private readonly string _connectionString;

        public MsSqlStudentsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Student FindStudentById(long id)
        {
            string findQuery = "SELECT * FROM Students WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(findQuery, connection);
                command.Parameters.Add("@id", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return MapToStudent(reader);
                    }
                }

            }
            return null;
        }

        private static Student MapToStudent(SqlDataReader reader)
        {
            var student =  new Student
            {
                Id = Convert.ToInt64(reader["id"]),
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
               
            };

            if (reader["phone_number"] != DBNull.Value)
                student.PhoneNumber = Convert.ToString(reader["phone_number"]);
            if (reader["group_id"] != DBNull.Value)
                student.GroupId = Convert.ToInt64(reader["group_id"]);

            return student;
        }

        public bool RemoveStudentById(long id)
        {
            string removeQuery = "DELETE FROM Students WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(removeQuery, connection);
                command.Parameters.Add("@id", id);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public long CreateStudent(Student person)
        {
            string insertQuery = "INSERT INTO Students(id, first_name, last_name, phone_number, group_id)" +
                                 " VALUES(@id, @first_name, @last_name, @phone_number, @group_id)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.Add("@id", person.Id);
                command.Parameters.Add("@first_name", person.FirstName);
                command.Parameters.Add("@last_name", person.LastName);
                if (person.PhoneNumber != null)
                {
                    command.Parameters.Add("@phone_number", person.PhoneNumber);
                }
                else
                {
                    command.Parameters.Add("@phone_number", DBNull.Value);
                }

                if (person.GroupId != null)
                {
                    command.Parameters.Add("@group_id", person.GroupId.Value);
                }
                else
                {
                    command.Parameters.Add("@group_id", DBNull.Value);
                }
                
                return command.ExecuteNonQuery();
            }
        }

        public bool UpdateStudent(Student updatedStudent)
        {
            string updateQuery = "UPDATE Students " +
                                 "SET first_name = @first_name, " +
                                 "last_name = @last_name, " +
                                 "phone_number = @phone_number " +
                                 "WHERE id = @id";
                                 
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.Add("@id", updatedStudent.Id);
                command.Parameters.Add("@first_name", updatedStudent.FirstName);
                command.Parameters.Add("@last_name", updatedStudent.LastName);
                if (updatedStudent.PhoneNumber != null)
                {
                    command.Parameters.Add("@phone_number", updatedStudent.PhoneNumber);
                }
                else
                {
                    command.Parameters.Add("@phone_number", DBNull.Value);
                }

                return command.ExecuteNonQuery() == 1;
            }
        }

        public IEnumerable<Student> FindStudentsByName(string firstName, string lastName, long offset, int count)
        {
            List<Student> result = new List<Student>();
            string findQuery = "SELECT * " +
                               "FROM Students " +
                               "WHERE first_name LIKE @first_name " +
                               "AND last_name LIKE @last_name " +
                               "ORDER BY id " +
                               "OFFSET @offset ROWS " +
                               "FETCH NEXT @count ROWS ONLY";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(findQuery, connection);
                command.Parameters.Add("@first_name", String.Format("%{0}%", firstName ?? ""));
                command.Parameters.Add("@last_name", String.Format("%{0}%", lastName ?? ""));
                command.Parameters.Add("@offset", offset);
                command.Parameters.Add("@count", count);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(MapToStudent(reader));
                    }
                }

            }
            return result.AsEnumerable();
        }

        public IEnumerable<Student> GetStudents(long offset, int count)
        {
            List<Student> result = new List<Student>();
            string findQuery = "SELECT * FROM Students";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(findQuery, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(MapToStudent(reader));
                    }
                }

            }
            return result.AsEnumerable();
        }

        public void Dispose()
        {
            
        }
    }
}
