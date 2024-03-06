

namespace _391project1Part2
{
    using Microsoft.VisualBasic;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using static System.Net.Mime.MediaTypeNames;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source = 206.75.31.209,11433; " +
                    "Initial Catalog = 391project1P2; " +
                    "User ID = mckenzy; " +
                    "Password = 123456; " +
                    "MultipleActiveResultSets = true;";

        private int stuOrIns = -1;
        private int sem = -1;
        private int dept = -1;
        private int fac = -1;
        private int year = -1;
        private int maj = -1;
        private int gen = -1;
        private int uni = -1;


        public Form1()
        {
            InitializeComponent();
            fillSemesterBox();
            fillDepartmentBox();
            fillFacultyBox();
            fillYearBox();
            fillMajorBox();
            fillGenderBox();
            fillUniversityBox();
            
            
        }

        private void getBoxIndices()
        {

            sem = semesterBox.SelectedIndex;

            fac = facultyBox.SelectedIndex;
            year = yearBox.SelectedIndex;
            maj = majorBox.SelectedIndex;
            gen = genderBox.SelectedIndex;
            uni = universityBox.SelectedIndex;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string qu = null;
            getBoxIndices();

            if (stuOrIns == 0)
            {
                qu = "select count(*) as num from takes T, student S where T.studentID = S.studentID";
            }
            else if (stuOrIns == 1)
            {
                qu = "select count(*) as num from takes T, instructor I where I.instructorID = T.instructorID";
            }


            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // Open the connection

                //Debug.WriteLine("Connection successful!");


                SqlCommand command = new SqlCommand("runQuery", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@query", qu);
                SqlDataReader myreader;
                con.Open();
                myreader = command.ExecuteReader();
                Debug.WriteLine("Executed succesfully");

                List<String> semester = new List<String>();
                while (myreader.Read())
                {
                    semester.Add(myreader[0].ToString());
                    Debug.WriteLine("reader: " + myreader[0].ToString());
                }
                for (int i = 0; i < semester.Count; i++)
                {
                    Debug.WriteLine("sem: " + semester[i]);
                    listBox1.Items.Add(semester[i]);
                }

                // Close the connection
                con.Close();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine($"SQL ERROR: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }




        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            string query0 = "DECLARE ";
            string query1 = "SELECT COUNT (*) AS TotalStudents";
            string query2 = "FROM takes t, student s";
            string query3 = "WHERE t.studentID = s.studentID";

            if (semesterBox.SelectedItem != null)
            {
                query0 += $"@semester = {semesterBox.SelectedItem.ToString()}";
                query2 += $", course c";
                query3 += $" AND t.courseID = c.courseID and semester = @semester";
            }
            else if (facultyBox.SelectedItem != null)
            {
                query0 += $"@faculty = {facultyBox.SelectedItem.ToString()}";
                query2 += $", course c";
                query3 += $" AND t.courseID = c.courseID and facukty = @faculty";
            }

        }
        private void courseRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InstructorRadio_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void fillSemesterBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct semester from date", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> semester = new List<String>();
                    while (myreader.Read())
                    {
                        semester.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < semester.Count; i++)
                    {
                        semesterBox.Items.Add(semester[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }
        /*private void fillCityBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct city from student", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> semester = new List<String>();
                    while (myreader.Read())
                    {
                        semester.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < semester.Count; i++)
                    {
                        cityBox.Items.Add(semester[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }*/
        private void fillYearBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct year from date", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> year = new List<String>();
                    while (myreader.Read())
                    {
                        year.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < year.Count; i++)
                    {
                        yearBox.Items.Add(year[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }
        private void fillMajorBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct major from student", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> major = new List<String>();
                    while (myreader.Read())
                    {
                        major.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < major.Count; i++)
                    {
                        majorBox.Items.Add(major[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }
        private void fillUniversityBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct university from course", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> uni = new List<String>();
                    while (myreader.Read())
                    {
                        uni.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < uni.Count; i++)
                    {
                        universityBox.Items.Add(uni[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }
        private void fillDepartmentBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct department from course", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> studentOrInstructor = new List<String>();
                    while (myreader.Read())
                    {
                        studentOrInstructor.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < studentOrInstructor.Count; i++)
                    {
                        departmentBox.Items.Add(studentOrInstructor[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }
        private void fillFacultyBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct faculty from course", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> faculty = new List<String>();
                    while (myreader.Read())
                    {
                        faculty.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < faculty.Count; i++)
                    {
                        facultyBox.Items.Add(faculty[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }
        private void fillGenderBox()
        {
            // Construct the connection string
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    // Open the connection

                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct gender from student", con);
                    SqlDataReader myreader;
                    Debug.WriteLine("Executed succesfully");
                    con.Open();
                    myreader = command.ExecuteReader();
                    List<String> gender = new List<String>();
                    while (myreader.Read())
                    {
                        gender.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < gender.Count; i++)
                    {
                        genderBox.Items.Add(gender[i]);
                    }

                    // Close the connection
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }
    }
}
