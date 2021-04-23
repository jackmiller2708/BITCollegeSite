using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BITCollege_NN.Models;
using Utility;

namespace BITCollegeSite
{
    public partial class wfRegister : System.Web.UI.Page
    {
        BITCollege_NNContext context = new BITCollege_NNContext();
        WCFServiceReference.CollegeRegistrationClient webService = new WCFServiceReference.CollegeRegistrationClient();

        /// <summary>
        /// Handles page load event
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Check if the page first load
                if (!Page.IsPostBack)
                {
                    lblStudentName.Text = getStudent().FullName;
                    int programId = (int)getStudent().ProgramId;
    
                    //Gets the courses based on the student's ProgramId
                    List<Course> coursesQuery = context.Courses.Where(course => course.ProgramId == programId).ToList();

                    drpCourseSelector.DataSource = coursesQuery;

                    drpCourseSelector.DataTextField = "Title";
                    drpCourseSelector.DataValueField = "CourseId";

                    drpCourseSelector.DataBind();
                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        /// <summary>
        /// Handles register button click event.
        /// </summary>
        protected void lbtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = getStudent().StudentId;
                int courseId = Convert.ToInt32(drpCourseSelector.SelectedValue);
                string notes = txtNotes.Text;

                // Check if the registerCourse method returns any error code
                if(webService.registerCourse(studentId, courseId, notes) != 0)
                {
                    lblError.Text = BusinessRules.reggisterError(webService.registerCourse(studentId, courseId, notes));
                    lblError.Visible = true;
                }
                else
                {
                    Response.Redirect("wfStudent");
                }   
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        /// <summary>
        /// Gets the student record from session
        /// </summary>
        /// <returns> logged in student record </returns>
        protected Student getStudent()
        {
            return (Student)Session["students"];
        }

        /// <summary>
        /// Handles return button click event
        /// </summary>
        protected void lbtnReturn_Click(object sender, EventArgs e)
        { 
            Response.Redirect("wfStudent"); // Redirects back to Course list
        }
    }
}