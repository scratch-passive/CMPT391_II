

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

    // Connects to the SSMS server
    public class DatabaseAccess
    {
        private string connectionString = 
            "Data Source = 206.75.31.209,11433; " +
            "Initial Catalog = 391project1P2; " +
            "User ID = mckenzy; " +
            "Password = 123456; " +
            "MultipleActiveResultSets = true;";

        // Sends a query to the database and returns the result
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine($"SQL ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}");
                }
            }
            return dataTable;
        }
    }

    public partial class Form1 : Form
    {
        private DatabaseAccess dbAccess = new DatabaseAccess();

        private DataGridView dataGridView1;

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
            string selectedUniversity = universityBox.SelectedItem?.ToString();
            string query = "";

            if (!string.IsNullOrEmpty(selectedUniversity))
            {
                // Show total number of courses for the selected university
                query = $"SELECT COUNT(*) AS TotalCourses FROM course WHERE university = '{selectedUniversity}'";
            }

            DataTable result = dbAccess.ExecuteQuery(query);
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedUniversity = universityBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedUniversity))
                {
                    // Drill down!
                    // Show distribution of courses by department for the selected university
                    string query = $"SELECT department, COUNT(*) AS TotalCourses FROM course WHERE university = '{selectedUniversity}' GROUP BY department";
                    DataTable result = dbAccess.ExecuteQuery(query);
                    dataGridView1.DataSource = result;
                }
            }
        }

        private void drillDownButton_Click(object sender, EventArgs e)
        {
            // University
            string selectedUniversity = universityBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedUniversity))
            {
                // Show distribution of courses by DEPARTMENT for the selected university
                string query = $"SELECT department, COUNT(*) AS TotalCourses FROM course WHERE university = '{selectedUniversity}' GROUP BY department";
                DataTable result = dbAccess.ExecuteQuery(query);
                dataGridView1.DataSource = result;
            }
        }

        private void rollUpButton_Click(object sender, EventArgs e)
        {
            // Univeristy
            string selectedUniversity = universityBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedUniversity))
            {
                // Show the total number of courses for the selected university
                string query = $"SELECT COUNT(*) AS TotalCourses FROM course WHERE university = '{selectedUniversity}'";
                DataTable result = dbAccess.ExecuteQuery(query);
                dataGridView1.DataSource = result;
            }
        }


        private void fillStudentOrInstructorBox()
        {
            studentOrInstructorBox.Items.Add("Student");
            studentOrInstructorBox.Items.Add("Instructor");
        }

        private void fillSemesterBox()
        {
            DataTable semesters = dbAccess.ExecuteQuery("select distinct semester from date");
            foreach (DataRow row in semesters.Rows)
            {
                semesterBox.Items.Add(row["semester"].ToString());
            }
        }

        private void fillYearBox()
        {
            DataTable years = dbAccess.ExecuteQuery("select distinct year from date");
            foreach (DataRow row in years.Rows)
            {
                yearBox.Items.Add(row["year"].ToString());
            }
        }

        private void fillMajorBox()
        {
            DataTable majors = dbAccess.ExecuteQuery("select distinct major from student");
            foreach (DataRow row in majors.Rows)
            {
                majorBox.Items.Add(row["major"].ToString());
            }
        }

        private void fillUniversityBox()
        {
            DataTable universities = dbAccess.ExecuteQuery("select distinct university from course");
            foreach (DataRow row in universities.Rows)
            {
                universityBox.Items.Add(row["university"].ToString());
            }
        }

        private void fillDepartmentBox()
        {
            DataTable departments = dbAccess.ExecuteQuery("select distinct department from course");
            foreach (DataRow row in departments.Rows)
            {
                departmentBox.Items.Add(row["department"].ToString());
            }
        }

        private void fillFacultyBox()
        {
            DataTable faculties = dbAccess.ExecuteQuery("select distinct faculty from course");
            foreach (DataRow row in faculties.Rows)
            {
                facultyBox.Items.Add(row["faculty"].ToString());
            }
        }

        private void fillGenderBox()
        {
            DataTable genders = dbAccess.ExecuteQuery("select distinct gender from student");
            foreach (DataRow row in genders.Rows)
            {
                genderBox.Items.Add(row["gender"].ToString());
            }
        }

    }
}
