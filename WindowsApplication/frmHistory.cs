using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BITCollege_NN.Models;

namespace WindowsApplication
{
    public partial class frmHistory : Form
    {
        ///given:  student and registration data will passed throughout 
        ///application. This object will be used to store the current
        ///student and selected registration
        ConstructorData constructorData;

        BITCollege_NNContext context = new BITCollege_NNContext();

        public frmHistory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// given:  This constructor will be used when called from 
        /// frmStudent.  This constructor will receive 
        /// specific information about the student and registration
        /// further code required:  
        /// </summary>
        /// <param name="student">specific student instance</param>
        /// <param name="registration">specific registration instance</param>
        public frmHistory(ConstructorData constructorData, Student student, Registration registration)
        {
            InitializeComponent();

            this.constructorData = constructorData;

            // Sets the student and registration to constructorData Properties
            this.constructorData.GetStudent = student;
            this.constructorData.GetRegistration = registration;

            
        }

        /// <summary>
        /// given: this code will navigate back to frmStudent with
        /// the specific student and registration data that launched
        /// this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //return to student with the data selected for this form
            frmStudent frmStudent = new frmStudent(constructorData);
            frmStudent.MdiParent = this.MdiParent;
            frmStudent.Show();
            this.Close();
        }

        /// <summary>
        /// given:  open in top left of frame
        /// further code required:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHistory_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(0, 0);

                // Set studentBindingSource data source
                studentBindingSource.DataSource = constructorData.GetStudent;

                // Turn off auto generate columns 
                registrationDataGridView.AutoGenerateColumns = false;

                // Get the student Id
                int studentID = constructorData.GetStudent.StudentId;

                // get registrations based on the retrieved student ID
                var registrationQuery = context.Registrations.Join(context.Courses,
                                                                    registration => registration.CourseId, // First half of ON statement
                                                                    course => course.CourseId,             // Second half of ON statemet
                                                                    (registration, course) => new          // SELECT Statment
                                                                    {
                                                                        registration.StudentId,            // StudentID
                                                                        registration.RegistrationNumber,   // RegistrationNumber
                                                                        registration.RegistrationDate,     // RegistrationDate
                                                                        Course = course.Title,             // CourseTitle 
                                                                        registration.Grade,                // Grade
                                                                        registration.Notes                 // Notes
                                                                    }).Where(registratedCourse => registratedCourse.StudentId == studentID).ToList();

                // Set the registrationDataGridView DataSource to the query
                registrationDataGridView.DataSource = registrationQuery;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
