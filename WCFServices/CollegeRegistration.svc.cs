using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BITCollege_NN.Models;
using Utility;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CollegeRegistration" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CollegeRegistration.svc or CollegeRegistration.svc.cs at the Solution Explorer and start debugging.
    public class CollegeRegistration : ICollegeRegistration
    {
        BITCollege_NNContext context = new BITCollege_NNContext();

        const int gradeNullException = -100;
        const int exceededAttemptsException = -200;
        const int updateExceptions = -300;

        /// <summary>
        /// Drops the registered course
        /// </summary>
        /// <param name="registrationID">the id of the course to drop</param>
        /// <returns></returns>
        public bool dropCourse(int registrationID)
        {
            try
            {
                var registrationQuery = from registration in context.Registrations
                                        where registration.RegistrationId == registrationID
                                        select registration;

                Registration courseToDrop = registrationQuery.SingleOrDefault();

                context.Registrations.Remove(courseToDrop);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Add a course to the student course list
        /// </summary>
        /// <param name="studentID">the target student</param>
        /// <param name="courseID">the courseId to add</param>
        /// <param name="notes">the course notes</param>
        /// <returns></returns>
        public int registerCourse(int studentID, int courseID, string notes)
        {
            int returnValue = 0;
           
            // Query the registrations of the student
            var registrationQuery = from registrations in context.Registrations
                                    where registrations.CourseId == courseID && registrations.StudentId == studentID
                                    select registrations;

            // Query the target course 
            var courseQuery = from courses in context.Courses
                              where courses.CourseId == courseID
                              select courses;

            Registration registration = registrationQuery.FirstOrDefault();
            Course course = courseQuery.SingleOrDefault();

            foreach (Registration reg in registrationQuery)
            {
                if (reg.Grade == null)
                {
                    return gradeNullException;
                }
            }

            if (course.CourseType == "Mastery")
            {
                MasteryCourse masteryCourse = (from masteryCourses in context.MasteryCourses
                                               where masteryCourses.CourseId == courseID
                                               select masteryCourses).SingleOrDefault();

                if(registrationQuery.Count() > masteryCourse.MaximumAttempts)
                {
                    return exceededAttemptsException;
                }
            }

            try //Update the registrations
            {

                Registration newRegistration = new Registration();
                newRegistration.StudentId = studentID;
                newRegistration.CourseId = courseID;
                newRegistration.Notes = notes;
                newRegistration.RegistrationDate = DateTime.Now;
                newRegistration.setNextRegistrationNumber();

                context.Registrations.Add(newRegistration);
                Student student = (from students in context.Students
                                   where students.StudentId == studentID
                                   select students).SingleOrDefault();
                GPAState gpa = (from gpastate in context.GPAStates
                                where gpastate.GPAStateId == student.GPAStateId
                                select gpastate).SingleOrDefault();
                student.OutstandingFees = course.TuitionAmount + (gpa.tuitionRateAdjustment(student) * course.TuitionAmount);
                context.SaveChanges();

                return returnValue;
        }
            catch
            {
                return updateExceptions;
            }
        }

        /// <summary>
        /// Updates the grade for the specific registration
        /// </summary>
        /// <param name="grade">the grade to add</param>
        /// <param name="registrationId">the target registrationId</param>
        /// <param name="notes">the course notes</param>
        public void updateGrade(double grade, int registrationId, string notes)
        {
            Registration registrations = (from registration in context.Registrations
                                          where registration.RegistrationId == registrationId
                                          select registration).SingleOrDefault();

            registrations.Grade = grade;
            registrations.Notes = notes;
            calculateGPA(registrations.StudentId);
            context.SaveChanges();
        }

        private double calculateGPA(int studentId)
        {
            double GradePointAvarage = 0;
            double totalGradeHours = 0;
            double totalCreditHours = 0;
            List<Registration> registrationQuery = (from registration in context.Registrations
                                                    where registration.StudentId == studentId && registration.Grade != null
                                                    select registration).ToList();

            foreach (Registration item in registrationQuery)
            {
                double grade = (double)item.Grade;

                Course course = (context.Courses.Where(x => x.CourseId == item.CourseId)).SingleOrDefault();
                                 
                CourseType type = BusinessRules.courseTypeLookup(course.CourseType);

                double GradePointValue = BusinessRules.gradeLookup(grade, type);

                double creditHours = course.CreditHours;

                double calculation = GradePointValue * creditHours;

                totalGradeHours += calculation;
                totalCreditHours += creditHours;
            }

            if (totalCreditHours != 0)
            {
                GradePointAvarage = totalGradeHours / totalCreditHours;
            }

            Student student = (from students in context.Students
                               where students.StudentId == studentId
                               select students).SingleOrDefault();
            student.GradePointAverage = GradePointAvarage;
            context.SaveChanges();

            return GradePointAvarage;
        }
    } 
}

