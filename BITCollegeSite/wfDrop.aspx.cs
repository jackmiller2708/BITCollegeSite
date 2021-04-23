using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BITCollege_NN.Models;
using System.Configuration;


namespace BITCollegeSite
{
    /// <summary>
    /// Represents the wfDrop form
    /// </summary>
    public partial class wfDrop : System.Web.UI.Page
    {
        BITCollege_NNContext context = new BITCollege_NNContext();
        WCFServiceReference.CollegeRegistrationClient collegeRegistration = new WCFServiceReference.CollegeRegistrationClient();

        /// <summary>
        /// Handles page load event
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Session["selected_row_course"] as string))
            {
                try
                {
                    setDetailsView();
                }
                catch(Exception exception)
                {
                    lblErrorMessage.Text = exception.Message;
                    lblErrorMessage.Visible = true;
                }
            }

        }

        /// <summary>
        /// Sets the data to the details view
        /// </summary>
        protected void setDetailsView()
        {
            string courseNumber = (string)Session["selected_row_course"];

            Course courseItem = context.Courses.Where(course => course.CourseNumber.ToString() == courseNumber).SingleOrDefault();
            Student studentItem = (Student)Session["students"];

            List<Registration> registrations = context.Registrations.Where(registration => 
                                               registration.StudentId == studentItem.StudentId && registration.CourseId == courseItem.CourseId).ToList();

            dtvCourse.DataSource = registrations;
            dtvCourse.DataBind();

            dtvCourse.Rows[2].Cells[1].Text = courseItem.Title;
            dtvCourse.Rows[1].Cells[1].Text = studentItem.FullName;

            if (dtvCourse.Rows[4].Cells[1].Text == "&nbsp;")
            {
                lbntDropCourse.Enabled = true;
            }
            else
            {
                lbntDropCourse.Enabled = false;
            }
        }

        /// <summary>
        /// Handles return button click event
        /// </summary>
        protected void lbntReturnListing_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfStudent");
        }

        /// <summary>
        /// Handles details view page changing event
        /// </summary>
        protected void dtvCourse_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            dtvCourse.PageIndex = e.NewPageIndex;

            setDetailsView();
        }

        /// <summary>
        /// Handles drop course button click event
        /// </summary>
        protected void lbntDropCourse_Click(object sender, EventArgs e)
        {
            int registrationNumber = Convert.ToInt32(dtvCourse.Rows[0].Cells[1].Text);
            int registrationId = context.Registrations.Where(registration => registration.RegistrationNumber == registrationNumber).SingleOrDefault().RegistrationId;
            collegeRegistration.dropCourse(registrationId);
            Response.Redirect("wfStudent");
        }
    }
}