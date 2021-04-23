using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BITCollege_NN.Models;

namespace BITCollegeSite
{
    public partial class wfStudent : System.Web.UI.Page
    {
        BITCollege_NNContext context = new BITCollege_NNContext();

        /// <summary>
        /// Handles page load event
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
                // Save user name to session
                Session["user_name"] = Context.User.Identity.Name;

                //Check if the user name is in session
                if(!string.IsNullOrEmpty((string)Session["user_name"]))
                {
                    string convertName = (string)Session["user_name"];
                    string userName = convertName.Substring(0, convertName.IndexOf("@"));

                    Student studentItem = context.Students.Where(student => student.StudentNumber.ToString() == userName).SingleOrDefault();

                    // Save student record to session
                    Session["students"] = studentItem;

                    lblFullName.Text = studentItem.FullName;

                    // Query the list of registered courses of logged in student
                    List<Course> courses = (from course in context.Courses
                                            join registration in context.Registrations
                                            on course.CourseId equals registration.CourseId
                                            where registration.StudentId == studentItem.StudentId
                                            select course).ToList();
 
                    Session["courses"] = courses;
                    grvRegisteredCourses.DataSource = courses;
                    grvRegisteredCourses.DataBind();
                }
                else
                {
                    Response.Redirect("/Account/Login");
                }
            }
            catch(Exception exception)
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = exception.Message;
            }
        }

        /// <summary>
        /// Handles gridview select index change event
        /// </summary>
        protected void grvRegisteredCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["selected_row_course"] = grvRegisteredCourses.SelectedRow.Cells[1].Text;
            Response.Redirect("wfDrop");
        }

        /// <summary>
        /// Handles register course button click event
        /// </summary>
        protected void lbtnRegisterCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfRegister");
        }
    }
}