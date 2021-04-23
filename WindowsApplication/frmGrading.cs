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
using Utility;

namespace WindowsApplication
{
    public partial class frmGrading : Form
    {
        ///given:  student and registration data will passed throughout 
        ///application. This object will be used to store the current
        ///student and selected registration
        ConstructorData constructorData;
        BITCollege_NNContext context = new BITCollege_NNContext();
        BITCollegeService.CollegeRegistrationClient client = new BITCollegeService.CollegeRegistrationClient();
        Course course;

        public frmGrading()
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
        public frmGrading(ConstructorData constructorData, Student student, Registration registration)
        {
            InitializeComponent();

            this.constructorData = constructorData;

            this.constructorData.GetStudent = student;
            this.constructorData.GetRegistration = registration;


            course = context.Courses.Where(course => course.CourseId == registration.CourseId).SingleOrDefault();

            studentBindingSource.DataSource       = student;
            registrationsBindingSource.DataSource = registration;
            coursesBindingSource.DataSource       = course;

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
        /// given:  open in top right of frame
        /// further code required:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGrading_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(0, 0);
                courseNumberMaskedLabel.Mask = BusinessRules.courseFormat(course.CourseType);

                if (gradeTextBox.Text != null && gradeTextBox.Text != "")
                {
                    lnkUpdate.Enabled = false;
                    gradeTextBox.Enabled = false;
                    lblExisting.Visible = true;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Handles update link button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            // Clear the gade format
            string grade = Numeric.ClearFormatting(gradeTextBox.Text, "%");

            // Check if the grade is numeric or not
            if (Numeric.isNumeric(grade, System.Globalization.NumberStyles.Float))
            {

                // Convert to 
                double convertedGrade = Convert.ToDouble(grade) / 100;

                // Check if the grade is in range from 0 to 1 
                if (convertedGrade > 1 || convertedGrade < 0)
                {
                    MessageBox.Show("The range must be from 0 to 1!");
                }
                else
                {
                    // Update the grade
                    client.updateGrade(convertedGrade, constructorData.GetRegistration.RegistrationId, "Updated Grade!");

                    // Return to the student form
                    frmStudent frmStudent = new frmStudent(constructorData);
                    frmStudent.MdiParent = this.MdiParent;
                    frmStudent.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("This field must be numeric!", "Error");
            }
            
        }
    }
}
