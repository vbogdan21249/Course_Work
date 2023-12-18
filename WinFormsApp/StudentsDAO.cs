using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Pqc.Crypto.Utilities;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

            //List<Classes> classes = new List<Classes>();
            //MySqlCommand command = new MySqlCommand("SELECT * FROM classes", connection);
            //using (MySqlDataReader reader = command.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        Classes c = new Classes()
            //        {
            //            ID = reader.GetInt32(0),
            //            Name = reader.GetString(1)
            //        };
            //        classes.Add(c);
            //    }
            //}
            //MySqlCommand command = new MySqlCommand();
            //command = new("SELECT * FROM students", connection);
            //MySqlCommand command = new MySqlCommand("SELECT * FROM students", connection);
            MySqlCommand command = new MySqlCommand("SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number FROM students s INNER JOIN classes c ON s.Class_ID = c.ID INNER JOIN dorms d ON s.Dormitory_ID = d.ID INNER JOIN rooms r ON s.Room_ID = r.ID", connection);

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
                        ClassName = reader.GetString(4),
                        Dormitory = reader.GetInt32(5),
                        Room = reader.GetInt32(6),
                    };

                    returnThese.Add(s);
                }
            }
            connection.Close();
            return returnThese;
        }




        public List<Student> getQQStudents(int classID = 0)
        {
            List<Student> returnThese = new List<Student>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            List<Class> classes = new List<Class>();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM students WHERE Class_ID = @classID", connection);
            //command.Parameters.AddWithValue("@classID", classID);

            MySqlCommand command = new MySqlCommand("SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number FROM students s INNER JOIN classes c ON s.Class_ID = c.ID INNER JOIN dorms d ON s.Dormitory_ID = d.ID INNER JOIN rooms r ON s.Room_ID = r.ID WHERE s.Class_ID = @classID", connection);

            command.Parameters.AddWithValue("@classID", classID);
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
                        ClassName = reader.GetString(4),
                        Dormitory = reader.GetInt32(5),
                        Room = reader.GetInt32(6),
                    };

                    returnThese.Add(s);
                }
            }

            connection.Close();
            return returnThese;
        }  // ---
           //public List<Student> searchTitles(string searchTerm, ComboBox searchComboBox)
           //{
           //    List<Student> returnThese = new List<Student>();
           //    MySqlConnection connection = new MySqlConnection
           //        (connectionString);
           //    connection.Open();

        //    string searchWildPhrase = "%" + searchTerm + "%";

        //    MySqlCommand command = new MySqlCommand();

        //    string? selectedOption = searchComboBox.SelectedItem?.ToString();

        //    command.CommandText = $"SELECT * FROM students WHERE {selectedOption} LIKE @search";
        //    command.Parameters.AddWithValue("@search", searchWildPhrase);
        //    command.Connection = connection;

        //    using (MySqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            Student s = new Student()
        //            {
        //                ID = reader.GetInt32(0),
        //                FirstName = reader.GetString(1),
        //                SecondName = reader.GetString(2),
        //                ThirdName = reader.GetString(3),
        //                Class_ID = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
        //                Dormitory_ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
        //                Room_ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
        //            };

        //            returnThese.Add(s);
        //        }
        //    }
        //    connection.Clone();
        //    return returnThese;
        //}



        //public List<Student> searchTitles(string searchTerm, ComboBox searchComboBox) 
        //{
        //    List<Student> returnThese = new List<Student>();

        //    using (MySqlConnection connection = new MySqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        string? selectedOption = searchComboBox.SelectedItem?.ToString();

        //        if (!string.IsNullOrEmpty(selectedOption))
        //        {
        //            using (MySqlCommand command = new MySqlCommand())
        //            {
        //                command.Connection = connection;
        //                command.CommandText = $"SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number " +
        //                                      $"FROM students s " +
        //                                      $"INNER JOIN classes c ON s.Class_ID = c.ID " +
        //                                      $"INNER JOIN dorms d ON s.Dormitory_ID = d.ID " +
        //                                      $"INNER JOIN rooms r ON s.Room_ID = r.ID " +
        //                                      $"WHERE {selectedOption} LIKE @search";

        //                command.Parameters.AddWithValue("@search", $"%{searchTerm}%");

        //                using (MySqlDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        Student s = new Student()
        //                        {
        //                            ID = reader.GetInt32(0),
        //                            FirstName = reader.GetString(1),
        //                            SecondName = reader.GetString(2),
        //                            ThirdName = reader.GetString(3),
        //                            ClassName = reader.GetString(4),
        //                            Dormitory = reader.GetInt32(5),
        //                            Room = reader.GetInt32(6),
        //                        };
        //                        returnThese.Add(s);
        //                    }
        //                }
        //            }
        //        }

        //        connection.Close(); // Close the connection after processing the data
        //    }

        //    return returnThese;
        //} // ---
        public List<Student> searchTitles(string searchTerm, ComboBox searchComboBox)
        {
            List<Student> returnThese = new List<Student>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string? selectedOption = searchComboBox.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedOption))
                {
                    // Define a mapping between display names and SQL column names with table aliases
                    Dictionary<string, string> columnMapping = new Dictionary<string, string>
            {
                {"ID", "s.ID"},
                {"Name", "s.Name"},
                {"Surname", "s.Surname"},
                {"Patronymic", "s.Patronymic"},
                {"Class", "c.Name"},
                {"Dormitory", "d.Dormitory_Number"},
                {"Room", "r.Room_Number"}
            };

                    if (columnMapping.TryGetValue(selectedOption, out string mappedColumnName))
                    {
                        using (MySqlCommand command = new MySqlCommand())
                        {
                            command.Connection = connection;
                            // Use the mapped column name in the SELECT and WHERE clauses
                            command.CommandText = $"SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number " +
                                                  $"FROM students s " +
                                                  $"INNER JOIN classes c ON s.Class_ID = c.ID " +
                                                  $"INNER JOIN dorms d ON s.Dormitory_ID = d.ID " +
                                                  $"INNER JOIN rooms r ON s.Room_ID = r.ID " +
                                                  $"WHERE {mappedColumnName} LIKE @search";

                            command.Parameters.AddWithValue("@search", $"%{searchTerm}%");

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
                                        ClassName = reader.GetString(4),
                                        Dormitory = reader.GetInt32(5),
                                        Room = reader.GetInt32(6),
                                    };
                                    returnThese.Add(s);
                                }
                            }
                        }
                    }
                }

                connection.Close();
            }

            return returnThese;
        }

        public int addStudent(Student student)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `students` (`ID`, `Name`, `Surname`, `Patronymic`, `Class_ID`, `Dormitory_ID`, `Room_ID`) VALUES (NULL, @name, @surname, @patronymic, @class, @dormitory, @room);", connection);
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
        public int deleteStudent(int studentID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `students` WHERE `students`.`ID` = @studentID", connection);

            command.Parameters.AddWithValue("@studentID", studentID);
            MessageBox.Show("Student removed");
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public List<Class> getAllClasses()
        {
            List<Class> returnThese = new List<Class>();
            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM classes", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Class c = new Class()
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

            command.CommandText = "SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number " +
                      "FROM students s " +
                      "INNER JOIN classes c ON s.Class_ID = c.ID " +
                      "INNER JOIN dorms d ON s.Dormitory_ID = d.ID " +
                      "INNER JOIN rooms r ON s.Room_ID = r.ID " +
                      "WHERE s.Class_ID = @classid";

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
                        ThirdName = reader.GetString(3),
                        ClassName = reader.GetString(4),
                        Dormitory = reader.GetInt32(5),
                        Room = reader.GetInt32(6),
                    };
                    returnThese.Add(s);
                }
            }
            connection.Close();
            return returnThese;
        }
        //public List<Student> getClassesForStudent(int studentsID)
        //{
        //    List<Student> returnThese = new List<Student>();

        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //    connection.Open();
        //    MySqlCommand command = new MySqlCommand();

        //    command.CommandText = "SELECT * FROM students WHERE Class_ID = @classid";
        //    command.Parameters.AddWithValue("@classid", studentsID);
        //    command.Connection = connection;

        //    using (MySqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            Student s = new Student()
        //            {
        //                ID = reader.GetInt32(0),
        //                FirstName = reader.GetString(1),
        //                SecondName = reader.GetString(2),
        //                ThirdName = reader.GetString(3)

        //                //ClassNumber = reader.GetString(4),
        //                //DormitoryNumber = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
        //                //Room_ID = (reader.IsDBNull(6) ? 0 : reader.GetInt32(6))
        //            };
        //            returnThese.Add(s);
        //        }
        //    }
        //    connection.Close();

        //    return returnThese;
        //}

        public DataTable GetClassesData()
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {

                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT ID, Name FROM classes", connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        public int addClass(Class classes)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO `classes` (`ID`, `Name`) VALUES (NULL, @name);", connection);
            command.Parameters.AddWithValue("@name", classes.Name);

            int newRows = command.ExecuteNonQuery();
            connection.Close();

            return newRows;
        }

        public bool deleteClass(int classID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                CheckDependenciesBeforeDelete(classID, connection);

                using (MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM `classes` WHERE `ID` = @classID", connection))
                {
                    using (MySqlCommand command = new MySqlCommand("UPDATE `students` SET `Class_ID` = @newClassID WHERE `Class_ID` = @classID", connection))
                    {
                        command.Parameters.AddWithValue("@newClassID", 0);
                        command.Parameters.AddWithValue("@classID", classID);
                        command.ExecuteNonQuery();
                    }
                    deleteCommand.Parameters.AddWithValue("@classID", classID);
                    deleteCommand.ExecuteNonQuery();
                }
                connection.Close();

                // The class and its dependencies are successfully deleted
                return true;
            }
        }
        private bool CheckDependenciesBeforeDelete(int classID, MySqlConnection connection)
        {
            using (MySqlCommand commandStudents = new MySqlCommand("SELECT COUNT(*) FROM `students` WHERE `Class_ID` = @classID", connection))
            {
                commandStudents.Parameters.AddWithValue("@classID", classID);
                int studentCount = Convert.ToInt32(commandStudents.ExecuteScalar());
                if (studentCount > 0)
                {
                    // There are dependencies in `students` table
                    return false;
                }
            }
            // There are no dependencies in `students` table
            return true;
        }
    }
}
