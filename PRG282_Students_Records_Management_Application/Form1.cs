using PRG282_Students_Records_Management_Application.Data.Data_Handlers;
using PRG282_Students_Records_Management_Application.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Reflection.Emit;

namespace PRG282_Students_Records_Management_Application
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BackToMenu()
        {
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder2(object sender, EventArgs e)
        {
            if (textBox3.Text == "Confirm Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Confirm Password";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderID(object sender, EventArgs e)
        {
            if (textBox4.Text == "Student ID")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderID(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "Student ID";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderName(object sender, EventArgs e)
        {
            if (textBox5.Text == "Name")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderName(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Name";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderAge(object sender, EventArgs e)
        {
            if (textBox6.Text == "Age")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderAge(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "Age";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderCourse(object sender, EventArgs e)
        {
            if (textBox7.Text == "Course")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderCourse(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                textBox7.Text = "Course";
                textBox7.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderID1(object sender, EventArgs e)
        {
            if (textBox8.Text == "Student ID")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderID1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                textBox8.Text = "Student ID";
                textBox8.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderName1(object sender, EventArgs e)
        {
            if (textBox9.Text == "Name")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderName1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                textBox9.Text = "Name";
                textBox9.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderAge1(object sender, EventArgs e)
        {
            if (textBox10.Text == "Age")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderAge1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                textBox10.Text = "Age";
                textBox10.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderCourse1(object sender, EventArgs e)
        {
            if (textBox11.Text == "Course")
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderCourse1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox11.Text))
            {
                textBox11.Text = "Course";
                textBox7.ForeColor = Color.Gray;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //write data from files as soon as app loads.
            /**WriteHandler.WriteStudentsFile();
            WriteHandler.WriteSummaryReportFile();

            //Get the data from files as soon as app loads.
            Student.ListOfStudents = ReadHandler.ReadStudentsFile();
            SummaryReport summaryReport = ReadHandler.ReadSummaryReportFile();

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Student.ListOfStudents;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = summaryReport;

            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;**/

            this.Text = "Student Records Management Application";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;


            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            Panel bottomBorder = new Panel();



            this.Controls.Add(bottomBorder);
            textBox1.Text = "Username";
            textBox1.ForeColor = Color.Gray;
            textBox1.Enter += RemovePlaceholder;
            textBox1.Leave += SetPlaceholder;

            textBox2.Text = "Password";
            textBox2.ForeColor = Color.Gray;
            textBox2.Enter += RemovePlaceholder1;
            textBox2.Leave += SetPlaceholder1;

            textBox3.Text = "Confirm Password";
            textBox3.ForeColor = Color.Gray;
            textBox3.Enter += RemovePlaceholder2;
            textBox3.Leave += SetPlaceholder2;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button1.BackColor = Color.Black;
            button1.Text = "Sign In";
            button1.ForeColor = Color.White;


            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button2.BackColor = Color.Black;
            button2.Text = "Log In";
            button2.ForeColor = Color.White;
            button2.Hide();
            label1.Text = "Have An Account? Click here to Log In";
            label2.Text = "Sign In";
            label2.Font = new Font(label2.Font.FontFamily, 40);

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;


            //Menu
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.BackColor = Color.Black;
            button3.Text = "Add Students";
            button3.ForeColor = Color.White;

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.BackColor = Color.Black;
            button4.Text = "View Students";
            button4.ForeColor = Color.White;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.BackColor = Color.Black;
            button5.Text = "Update Students";
            button5.ForeColor = Color.White;

            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.BackColor = Color.Black;
            button6.Text = "Delete Students";
            button6.ForeColor = Color.White;

            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button7.BackColor = Color.Black;
            button7.Text = "Generate Report";
            button7.ForeColor = Color.White;

            label3.Text = "Menu";
            label3.Font = new Font(label3.Font.FontFamily, 40);

            //Add Form
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            button8.BackColor = Color.Red;
            button8.Text = "Back";
            button8.ForeColor = Color.White;

            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;
            button9.BackColor = Color.Black;
            button9.Text = "Add Student";
            button9.ForeColor = Color.White;

            textBox4.Text = "Student ID";
            textBox4.ForeColor = Color.Gray;
            textBox4.Enter += RemovePlaceholderID;
            textBox4.Leave += SetPlaceholderID;

            textBox5.Text = "Name";
            textBox5.ForeColor = Color.Gray;
            textBox5.Enter += RemovePlaceholderName;
            textBox5.Leave += SetPlaceholderName;

            textBox6.Text = "Age";
            textBox6.ForeColor = Color.Gray;
            textBox6.Enter += RemovePlaceholderAge;
            textBox6.Leave += SetPlaceholderAge;

            textBox7.Text = "Course";
            textBox7.ForeColor = Color.Gray;
            textBox7.Enter += RemovePlaceholderCourse;
            textBox7.Leave += SetPlaceholderCourse;


            //View Students Form
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 0;
            button10.BackColor = Color.Red;
            button10.Text = "Back";
            button10.ForeColor = Color.White;

            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 0;
            button11.BackColor = Color.Red;
            button11.Text = "Delete";
            button11.ForeColor = Color.White;
            button11.Hide();

            //Update Form
            button12.FlatStyle = FlatStyle.Flat;
            button12.FlatAppearance.BorderSize = 0;
            button12.BackColor = Color.Red;
            button12.Text = "Back";
            button12.ForeColor = Color.White;

            button13.FlatStyle = FlatStyle.Flat;
            button13.FlatAppearance.BorderSize = 0;
            button13.BackColor = Color.Black;
            button13.Text = "Update";
            button13.ForeColor = Color.White;

            button14.FlatStyle = FlatStyle.Flat;
            button14.FlatAppearance.BorderSize = 0;
            button14.BackColor = Color.Black;
            button14.Text = "Update";
            button14.ForeColor = Color.White;

            button15.FlatStyle = FlatStyle.Flat;
            button15.FlatAppearance.BorderSize = 0;
            button15.BackColor = Color.Black;
            button15.Text = "Update";
            button15.ForeColor = Color.White;

            textBox8.Text = "Student ID";
            textBox8.ForeColor = Color.Gray;
            textBox8.Enter += RemovePlaceholderID1;
            textBox8.Leave += SetPlaceholderID1;

            textBox9.Text = "Name";
            textBox9.ForeColor = Color.Gray;
            textBox9.Enter += RemovePlaceholderName1;
            textBox9.Leave += SetPlaceholderName1;

            textBox10.Text = "Age";
            textBox10.ForeColor = Color.Gray;
            textBox10.Enter += RemovePlaceholderAge1;
            textBox10.Leave += SetPlaceholderAge1;

            textBox11.Text = "Course";
            textBox11.ForeColor = Color.Gray;
            textBox11.Enter += RemovePlaceholderCourse1;
            textBox11.Leave += SetPlaceholderCourse1;





        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox3.Hide();
            button1.Hide();
            label1.Hide();
            button2.Show();
            label2.Text = "Log In";
            label2.Font = new Font(label2.Font.FontFamily, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you put the method to sign in but for now I will let you in");
            panel1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where the log in method would go, but I am too kind so I will not keep you out");
            panel1.Show();
        }

        //This code underneath is for the MENU. Just scroll, DO NOT TOUCH...just scroll down to your form
        private void button3_Click(object sender, EventArgs e)
        {
            BackToMenu();
            panel2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackToMenu();
            panel2.Show();
            panel3.Show();
            WriteHandler.WriteStudentsFile();
            WriteHandler.WriteSummaryReportFile();

            //Get the data from files as soon as app loads.
            Student.ListOfStudents = ReadHandler.ReadStudentsFile();
            SummaryReport summaryReport = ReadHandler.ReadSummaryReportFile();

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Student.ListOfStudents;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = summaryReport;

            pictureBox3.Hide();
            button11.Hide();
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.Hide();
            dataGridView1.Show();
            //dataGridView2.DataSource = bindingSource2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BackToMenu();
            panel2.Show();
            panel3.Show();
            panel4.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BackToMenu();
            panel2.Show();
            panel3.Show();
            WriteHandler.WriteStudentsFile();
            WriteHandler.WriteSummaryReportFile();


            Student.ListOfStudents = ReadHandler.ReadStudentsFile();
            SummaryReport summaryReport = ReadHandler.ReadSummaryReportFile();

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Student.ListOfStudents;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = summaryReport;

            pictureBox3.Hide();
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView2.DataSource = bindingSource2;
            button11.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            BackToMenu();
            panel2.Show();
            panel3.Show();
            WriteHandler.WriteStudentsFile();
            WriteHandler.WriteSummaryReportFile();

            //Get the data from files as soon as app loads.
            Student.ListOfStudents = ReadHandler.ReadStudentsFile();
            SummaryReport summaryReport = ReadHandler.ReadSummaryReportFile();

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Student.ListOfStudents;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = summaryReport;

            pictureBox3.Show();
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.Show();
            dataGridView1.Hide();
            dataGridView2.DataSource = bindingSource2;
        }

        //Everything underneath here would be code for various forms
        //but it will only be maximum 2 buttons per form mainly, back button and crud button so do not stress

        //this is for the add form
        private void button8_Click(object sender, EventArgs e)
        {
            BackToMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Collecting student data from text boxes
            string studentID = textBox4.Text;
            string name = textBox5.Text;
            int age = int.TryParse(textBox6.Text, out int parsedAge) ? parsedAge : 0;
            string course = textBox7.Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(name) || age <= 0 || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill all fields with valid information.");
                return;
            }

            // Create a new student and add it to the list
            Student newStudent = new Student(int.Parse(studentID), name, age, course);

            // Add student to data and save
            Student.ListOfStudents.Add(newStudent);
            WriteHandler.WriteStudentsFile();

            MessageBox.Show("Student has been added successfully!");
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        //this is for the view form
        private void button10_Click(object sender, EventArgs e)
        {
            BackToMenu();
        }

        //Underneath is the delete button
        private void button11_Click(object sender, EventArgs e)
        {
            // Get the selected student ID
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            string studentID = dataGridView1.SelectedRows[0].Cells["_StudentID"].Value.ToString();

            // Remove the student from the list
            Student studentToRemove = Student.ListOfStudents.FirstOrDefault(s => s._StudentID == int.Parse(studentID));
            if (studentToRemove != null)
            {
                Student.ListOfStudents.Remove(studentToRemove);
                WriteHandler.WriteStudentsFile();
                MessageBox.Show("Student deleted successfully.");

                // Refresh the data grid view
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Student.ListOfStudents;
            }
        }


        //Update Form Button
        private void button12_Click(object sender, EventArgs e)
        {
            BackToMenu();
            textBox8.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Fetch updated data
            string studentID = textBox8.Text;
            string name = textBox9.Text;

            // Find the student to update
            Student studentToUpdate = Student.ListOfStudents.FirstOrDefault(s => s._StudentID == int.Parse(studentID));
            if (studentToUpdate != null)
            {
                // Update student properties
                studentToUpdate._StudentName = name;

                WriteHandler.WriteStudentsFile();

                MessageBox.Show("Student updated successfully.");

                // Refresh the data grid view
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Student.ListOfStudents;
            }
            else
            {
                MessageBox.Show("Student not found.");
            }


            textBox9.Clear();
        }


        private void button14_Click(object sender, EventArgs e)
        {
            // Fetch updated data
            string studentID = textBox8.Text;
            int age = int.TryParse(textBox10.Text, out int parsedAge) ? parsedAge : 0;


            // Find the student to update
            Student studentToUpdate = Student.ListOfStudents.FirstOrDefault(s => s._StudentID == int.Parse(studentID));
            if (studentToUpdate != null)
            {
                // Update student properties
                studentToUpdate._StudentAge = age;


                WriteHandler.WriteStudentsFile();

                MessageBox.Show("Student updated successfully.");

                // Refresh the data grid view
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Student.ListOfStudents;
            }
            else
            {
                MessageBox.Show("Student not found.");
            }


            textBox10.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Fetch updated data
            string studentID = textBox8.Text;
            string course = textBox11.Text;

            // Find the student to update
            Student studentToUpdate = Student.ListOfStudents.FirstOrDefault(s => s._StudentID == int.Parse(studentID));
            if (studentToUpdate != null)
            {
                // Update student properties
                studentToUpdate._CourseName = course;

                WriteHandler.WriteStudentsFile();

                MessageBox.Show("Student updated successfully.");

                // Refresh the data grid view
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Student.ListOfStudents;
            }
            else
            {
                MessageBox.Show("Student not found.");
            }


            textBox11.Clear();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
