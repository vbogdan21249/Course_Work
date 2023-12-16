using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Utilities;

namespace WinFormsApp
{
    internal class StudentsDAO
    {

        string connectionString = "Server=localhost;Port=3306;Database=students;Uid=root;Pwd=root;";
        public List<Student> getAllStudents()
        {
            List<Student> returnThese = new List<Student>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            List<Classes> classes = new List<Classes>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM classes", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Classes c = new Classes()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    classes.Add(c);
                }
            }

            command = new ("SELECT * FROM students", connection);
            //MySqlCommand command = new MySqlCommand("SELECT * FROM students", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student s = new Student()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        SecondName = reader.GetString(2),
                        ThirdName = reader.GetString(3),
                        Class_ID = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                        Dormitory_ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        Room_ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                    };

                    returnThese.Add(s);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<Student> searchTitles(string searchTerm, ComboBox searchComboBox)
        {
            List<Student> returnThese = new List<Student>();
            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();

            string? selectedOption = searchComboBox.SelectedItem?.ToString();

            command.CommandText = $"SELECT * FROM students WHERE {selectedOption} LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student s = new Student()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        SecondName = reader.GetString(2),
                        ThirdName = reader.GetString(3),
                        Class_ID = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                        Dormitory_ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        Room_ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                    };
                    
                    returnThese.Add(s);
                }
            }
            connection.Clone();
            return returnThese;
        }

        internal int addStudent(Student student)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //INSERT INTO `students` (`ID`, `Name`, `Surname`, `Patronymic`, `dorms_ID`, `rooms_ID`, `classes_ID`) VALUES(NULL, 'qqqqq', 'wwww', 'qqqqqe', '2', '1', '2');

            MySqlCommand command = new MySqlCommand("INSERT INTO `students` (`ID`, `Name`, `Surname`, `Patronymic`, `classes_ID`, `dorms_ID`, `rooms_ID`) VALUES (NULL, @name, @surname, @patronymic, @class, @dormitory, @room);", connection);
            command.Parameters.AddWithValue("@name", student.FirstName);
            command.Parameters.AddWithValue("@surname", student.SecondName);
            command.Parameters.AddWithValue("@patronymic", student.ThirdName);
            command.Parameters.AddWithValue("@class", student.Class_ID);
            command.Parameters.AddWithValue("@dormitory", student.Dormitory_ID);
            command.Parameters.AddWithValue("@room", student.Room_ID);

            int newRows = command.ExecuteNonQuery();
            connection.Close();

            return newRows;
        }


        public List<Classes> getAllClasses()
        {
            List<Classes> returnThese = new List<Classes>();
            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM classes", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Classes c = new Classes()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };

                    returnThese.Add(c);
                }
            }
            connection.Clone();
            return returnThese;
        }
        public List<Student> getStudentsForClass(int classesID)
        {
            List<Student> returnThese = new List<Student>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            
            command.CommandText = "SELECT * FROM students WHERE Class_ID = @classid";
            command.Parameters.AddWithValue("@classid", classesID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student s = new Student()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        SecondName = reader.GetString(2),
                        ThirdName = reader.GetString(3)

                        //ClassNumber = reader.GetString(4),
                        //DormitoryNumber = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        //Room_ID = (reader.IsDBNull(6) ? 0 : reader.GetInt32(6))
                    };
                    returnThese.Add(s);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<Student> getClassesForStudent(int studentsID)
        {
            List<Student> returnThese = new List<Student>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM students WHERE Class_ID = @classid";
            command.Parameters.AddWithValue("@classid", studentsID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student s = new Student()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        SecondName = reader.GetString(2),
                        ThirdName = reader.GetString(3)

                        //ClassNumber = reader.GetString(4),
                        //DormitoryNumber = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        //Room_ID = (reader.IsDBNull(6) ? 0 : reader.GetInt32(6))
                    };
                    returnThese.Add(s);
                }
            }
            connection.Close();

            return returnThese;
        }
    }
}
