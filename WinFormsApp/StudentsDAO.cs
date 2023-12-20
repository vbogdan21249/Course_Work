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
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Pqc.Crypto.Utilities;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp
{
    internal class StudentsDAO
    {
        string connectionString = "Server=localhost;Port=3306;Database=students;Uid=root;Pwd=root;";

        public DataTable GetStudentsData()
        {
            DataTable dtStudents = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(
                    "SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, COALESCE(d.Dormitory_Number, 0) AS Dormitory_Number, COALESCE(r.Room_Number, 0) AS Room_Number " +
                    "FROM students s " +
                    "INNER JOIN classes c ON s.Class_ID = c.ID " +
                    "LEFT JOIN dorms d ON s.Dormitory_ID = d.ID " +
                    "LEFT JOIN rooms r ON s.Room_ID = r.ID", connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dtStudents);
                    }
                }
            }

            return dtStudents;
        }

        public DataTable GetQQStudents(int classID = 0)
        {
            DataTable dtStudents = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number FROM students s INNER JOIN classes c ON s.Class_ID = c.ID INNER JOIN dorms d ON s.Dormitory_ID = d.ID INNER JOIN rooms r ON s.Room_ID = r.ID WHERE s.Class_ID = @classID", connection);

                command.Parameters.AddWithValue("@classID", classID);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dtStudents);
                }

                connection.Close();
            }

            return dtStudents;
        }

        public DataTable SearchTitles(string searchTerm, ComboBox searchComboBox)
        {
            DataTable dtSearchResults = new DataTable();

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
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                        {
                            adapter.SelectCommand = new MySqlCommand(
                                $"SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number " +
                                $"FROM students s " +
                                $"INNER JOIN classes c ON s.Class_ID = c.ID " +
                                $"INNER JOIN dorms d ON s.Dormitory_ID = d.ID " +
                                $"INNER JOIN rooms r ON s.Room_ID = r.ID " +
                                $"WHERE {mappedColumnName} LIKE @search", connection);

                            adapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                            adapter.Fill(dtSearchResults);
                        }
                    }
                }

                connection.Close();
            }

            return dtSearchResults;
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
            MessageBox.Show("New row inserted.");
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

        public DataTable GetAllClasses()
        {
            DataTable dtClasses = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM classes", connection))
                {

                    adapter.Fill(dtClasses);
                }
            }

            return dtClasses;
        }

        public DataTable GetStudentsForClass(int classID)
        {
            DataTable dtStudents = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    adapter.SelectCommand = new MySqlCommand(
                        "SELECT s.ID, s.Name, s.Surname, s.Patronymic, c.Name AS ClassName, d.Dormitory_Number, r.Room_Number " +
                        "FROM students s " +
                        "INNER JOIN classes c ON s.Class_ID = c.ID " +
                        "INNER JOIN dorms d ON s.Dormitory_ID = d.ID " +
                        "INNER JOIN rooms r ON s.Room_ID = r.ID " +
                        "WHERE s.Class_ID = @classid", connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@classid", classID);

                    adapter.Fill(dtStudents);
                }
            }

            return dtStudents;
        }

        public int addClass(Class classes)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using (MySqlCommand checkCommand = new MySqlCommand("SELECT COUNT(*) FROM `classes` WHERE `Name` = @name", connection))
            {
                checkCommand.Parameters.AddWithValue("@name", classes.Name);
                int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                if (existingCount > 0)
                {
                    MessageBox.Show("The name already exists in the classes table. Insertion failed.");
                }
                else
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `classes` (`ID`, `Name`) VALUES (NULL, @name);", connection);
                    command.Parameters.AddWithValue("@name", classes.Name);
                    int newRows = command.ExecuteNonQuery();
                    MessageBox.Show("Insertion completed successfully.");
                    return newRows;
                }
            }
            connection.Close();
            return 1;
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

        public DataTable GetDormitoryData()
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT ID, Dormitory_Number FROM dorms", connection))
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

        public DataTable GetRoomsData(int dormID)
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {

                connection.Open();
                if (dormID == null)
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT ID, Room_Number FROM rooms", connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                else
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT ID, Room_Number FROM rooms WHERE dorms_ID = @dormID", connection))
                    {
                        command.Parameters.AddWithValue("@dormID", dormID);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
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

    }
}
