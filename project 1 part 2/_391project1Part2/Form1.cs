

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

        public Form1()
        {
            InitializeComponent();
            fillSemesterBox();
            fillDepartmentBox();
            fillFacultyBox();
            fillSemesterBox();
            fillYearBox();
            fillMajorBox();
            fillGenderBox();
            fillUniversityBox();
            fillStudentOrInstructorBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }

        private void fillStudentOrInstructorBox()
        {
            string stu = "Student";
            string ins = "Instructor";
            studentOrInstructorBox.Items.Add(stu);
            studentOrInstructorBox.Items.Add(ins);
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
