

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
        public Form1()
        {
            InitializeComponent();
            fillStudentBox();
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

        private void fillStudentBox() //THIS IS TO FILL studentOrInstructor box --> change that on line 68 (from semesterbox to studentOrInstructor box)
        {
            // Construct the connection string
            string connectionString = $"Server=206.75.31.209,11433;Database=391project1P2;User Id=mckenzy;Password=123456;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    con.Open();
                    Debug.WriteLine("Connection successful!");


                    SqlCommand command = new SqlCommand("select distinct semester from date");
                    SqlDataReader myreader = command.ExecuteReader();
                    Debug.WriteLine("Executed succesfully");

                    List<String> studentOrInstructor = new List<String>();
                    while (myreader.Read())
                    {
                        studentOrInstructor.Add(myreader[0].ToString());

                    }
                    for (int i = 0; i < studentOrInstructor.Count; i++)
                    {
                        semesterBox.Items.Add(studentOrInstructor[i]);
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
