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

namespace PRG282_Students_Records_Management_Application
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
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

            this.Text= "Student Records Management Application";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

           
            pictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
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
            MessageBox.Show("This is where you put the method to sign in");
        }
    }
}
