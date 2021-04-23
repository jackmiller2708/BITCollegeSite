using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using BITCollege_NN.Models;
using Utility;

namespace WindowsApplication
{
    class Batch
    {
        BITCollege_NNContext context = new BITCollege_NNContext();
        BITCollegeService.CollegeRegistrationClient client = new BITCollegeService.CollegeRegistrationClient();

        private string inputFileName;
        private string logFileName;
        private string logData;

        /// <summary>
        /// Process all error records
        /// </summary>
        /// <param name="beforeQuery"></param>
        /// <param name="afterQuery"></param>
        /// <param name="message"></param>
        private void processErrors(IEnumerable<XElement> beforeQuery, IEnumerable<XElement> afterQuery, string message)
        {
            IEnumerable<XElement> invalidRecords = beforeQuery.Except(afterQuery);

            foreach (XElement invalidRecord in invalidRecords)
            {
                string Exportedmessage = "";

                //-------------------------------------------------------------------------------
                //-------------------------------------------------------------------------------

                XElement programAcronym     = invalidRecord.Element("program");
                //--
                XElement studentNumber      = invalidRecord.Element("student_no");
                //--
                XElement courseNumber       = invalidRecord.Element("course_no");
                //--
                XElement registrationNumber = invalidRecord.Element("registration_no");
                //--
                XElement type               = invalidRecord.Element("type");
                //--
                XElement grade              = invalidRecord.Element("grade");
                //--
                XElement notes              = invalidRecord.Element("notes");
                //--
                int nodes                   = invalidRecord.Nodes().Count();

                //-------------------------------------------------------------------------------
                //-------------------------------------------------------------------------------

                
                switch (message)
                {
                    case "Grade is invalid":
                        if (!Numeric.isNumeric(grade.Value, System.Globalization.NumberStyles.Integer))
                        {
                            Exportedmessage = "Grade is not numeric";
                        }
                        break;
                    case "Grade must be * for type 1 and in range of 0 to 100 for type 2":
                        if (type.Value == "1" && grade.Value != "*")
                        {
                            Exportedmessage = "Grade must be * for type 1";
                        }
                        else if (type.Value == "2" && (Convert.ToInt64(grade.Value) < 0 || Convert.ToInt64(grade.Value) > 100))
                        {
                            Exportedmessage = "Grade must be in range from 0 to 100 for type 2";
                        }
                        break;
                    case "Course Number does not exist":
                        if (type.Value == "2" && courseNumber.Value != "*")
                        {
                            Exportedmessage = "Course Number must be * for type 2";
                        }
                        else
                        {
                            Exportedmessage = message;
                        }
                        break;
                    case "Registration Number does not exist":
                        if (type.Value == "1" && registrationNumber.Value != "*")
                        {
                            Exportedmessage = "Registration Number must be * for type 1";
                        }
                        else
                        {
                            Exportedmessage = message;
                        }
                        break;
                    default:
                        Exportedmessage = message;
                        break;
                }

                //-------------------------------------------------------------------------------
                //-------------------------------------------------------------------------------

                logData += "--------------ERROR-----------------\n";
                logData += $"File: {inputFileName} \n";
                logData += $"Program: {programAcronym} \n";
                logData += $"Student Number: {studentNumber}\n";
                logData += $"Course Number: {courseNumber}\n";
                logData += $"Registration Number: {registrationNumber}\n";
                logData += $"Type: {type}\n";
                logData += $"Grade: {grade}\n";
                logData += $"Notes: {notes}\n";
                logData += $"Nodes: {nodes}\n";
                logData += $"{Exportedmessage}\n";
                logData += "------------------------------------\n";

                //-------------------------------------------------------------------------------
                //-------------------------------------------------------------------------------
            }
        }

        /// <summary>
        /// Process the xml header
        /// </summary>
        private void processHeader()
        {    
            
            XDocument xDocument = XDocument.Load(inputFileName);

            XElement xElement = xDocument.Element("student_update");
            IEnumerable<XAttribute> xAttributes = xElement.Attributes();
            string checkSum = xElement.Attribute("checksum").Value;
            IEnumerable<XElement> studenNumberNodes = xDocument.Descendants("student_no");

            int sum = 0;

            foreach (XElement studentNumberNode in studenNumberNodes)
            {
                sum += Convert.ToInt32(studentNumberNode.Value);
            }

            IEnumerable<string> programAcronyms = context.Programs.Select(program => program.ProgramAcronnym);
            string programAttribute = xElement.Attribute("program").Value;
           
            //Validations
            if (xAttributes.Count() != 3)
            {
                throw new Exception("The number of attributes is Invalid!");
            }
            else if (xElement.Attribute("date").Value != DateTime.Now.ToString("yyyy-MM-dd"))
            {
                throw new Exception(DateTime.Now.Date.ToString());
            }
            else if (!programAcronyms.Contains(programAttribute))
            {
                throw new Exception("The program acronym is invalid!");
            }
            else if (sum != Convert.ToInt32(checkSum))
            {
                throw new Exception("Invalid checksum!");
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void processDetails()
        {   
            // Loads the document
            XDocument xDocument = XDocument.Load(inputFileName);
            
            // Gets all transaction nodes
            IEnumerable<XElement> transactionElements = xDocument.Descendants().Where(obj => obj.Name == "transaction");
            //------------------------------------------ CHECK NUMBERS NODE ------------------------------------------------------------------------------
            IEnumerable<XElement> firstFilter = transactionElements.Where(transaction => transaction.Nodes().Count() == 7);
            processErrors(transactionElements, firstFilter, "the number of nodes is not 7");
            //---------------------------------------- CHECK PROGRAM ACCRONYM ----------------------------------------------------------------------------
            IEnumerable<XElement> secondFilter = firstFilter.Where(transaction => transaction.Element("program").Value == xDocument.Element("student_update").Attribute("program").Value);
            processErrors(firstFilter, secondFilter, "Program Acronym is invalid");
            //----------------------------------------CHECK TYPE NODE DATA TYPE -------------------------------------------------------------------------
            IEnumerable<XElement> thirdFilter = secondFilter.Where(transaction => Numeric.isNumeric(transaction.Element("type").Value, System.Globalization.NumberStyles.Integer));
            processErrors(secondFilter, thirdFilter, "Type must be numeric");
            //------------------------------------------ CHECK GEADE DATA TYPE --------------------------------------------------------------------------
            IEnumerable<XElement> fourthFilter = thirdFilter.Where(transaction => Numeric.isNumeric(transaction.Element("grade").Value, System.Globalization.NumberStyles.Integer) || transaction.Element("grade").Value == "*");
            processErrors(thirdFilter, fourthFilter, "Grade is invalid");
            //------------------------------------------- CHECK TYPE VALUE -----------------------------------------------------------------------------
            IEnumerable<XElement> fifthFilter = fourthFilter.Where(transaction => transaction.Element("type").Value == "1" || transaction.Element("type").Value == "2");
            processErrors(fourthFilter, fifthFilter, "Type must be 1 or 2");
            //------------------------------------------ CHECK GRADE VALUE -------------------------------------------------------------------------
            IEnumerable<XElement> sixthFilter = fifthFilter.Where(transaction => transaction.Element("type").Value == "1" && transaction.Element("grade").Value == "*" || 
                transaction.Element("type").Value == "2" && (Convert.ToInt64(transaction.Element("grade").Value) >= 0 && Convert.ToInt64(transaction.Element("grade").Value) <= 100));
            processErrors(fifthFilter, sixthFilter, "Grade must be * for type 1 and in range of 0 to 100 for type 2");
            //------------------------------------ CHECK STUDENT NUMBER DATA TYPE -----------------------------------------------------------------------------
            IEnumerable<long> studentNumbers = context.Students.Select(student => student.StudentNumber);
            IEnumerable<XElement> seventhFilter = sixthFilter.Where(transaction => studentNumbers.Contains(Convert.ToInt64(transaction.Element("student_no").Value)));
            processErrors(sixthFilter, seventhFilter, "Student Number must be numeric");
            //------------------------------------- CHECK VALID COURSE NUMBER -----------------------------------------------------------------------------------
            IEnumerable<string> courseNumbers = context.Courses.Select(course => course.CourseNumber);
            IEnumerable<XElement> eighthFilter = seventhFilter.Where(transaction => (transaction.Element("type").Value == "2" && transaction.Element("course_no").Value == "*") || (transaction.Element("type").Value == "1" && courseNumbers.Contains(transaction.Element("course_no").Value)));
            processErrors(seventhFilter,eighthFilter,"Course Number does not exist");
            //----------------------------------- CHECK VALID REGISTRATION NUMBER ----------------------------------------------------------------------------------
            IEnumerable<string> registrationNumbers = context.Registrations.Select(registration => registration.RegistrationNumber.ToString());
            IEnumerable<XElement> finalFilter = eighthFilter.Where(transaction => (transaction.Element("type").Value == "2" && registrationNumbers.Contains(transaction.Element("registration_no").Value)) || (transaction.Element("type").Value == "1" && transaction.Element("registration_no").Value == "*"));
            processErrors(eighthFilter, finalFilter, "Registration Number does not exist");
            //------------------------------------------------------------------------------------------------------------------------
            processTransactions(finalFilter);
        }

        /// <summary>
        /// Process the collection of transaction
        /// </summary>
        /// <param name="transationRecords">The collection of transaction</param>
        private void processTransactions(IEnumerable<XElement> transationRecords)
        {
            foreach (XElement transaction in transationRecords)
            {

                //--------------------------------------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------------------------------------

                long studentNumber        = Convert.ToInt64(transaction.Element("student_no").Value);
                string courseNumber       = transaction.Element("course_no").Value;
                string registrationNumber = transaction.Element("registration_no").Value;
                int type                  = Convert.ToInt32(transaction.Element("type").Value);
                string grade              = transaction.Element("grade").Value;
                string notes              = transaction.Element("notes").Value;

                //--------------------------------------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------------------------------------

                int studentId             = context.Students.Where(student => student.StudentNumber == studentNumber).SingleOrDefault().StudentId;
                int courseId;
                int registrationId;

                //--------------------------------------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------------------------------------

                if (type == 1)
                {
                    try
                    {
                        // Gets the studentId
                        courseId = context.Courses.Where(course => course.CourseNumber == courseNumber).SingleOrDefault().CourseId;
                        
                        // Registers the course
                        int error = client.registerCourse(studentId, courseId, notes);

                        switch (error)
                        {
                            case -100:
                                logData += $"Student cannot register for a course in which there is already an ungraded registration\n";
                                break;
                            case -200:
                                logData += $"Student exceeded maximum attempt for this course\n";
                                break;
                            case -300:
                                logData += $"Fail to update\n";
                                break;
                            default:
                                logData += $"Successful Registration student {studentNumber} course {courseNumber}\n";
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        logData += "ERROR: Student cannot register for a course in which there is already an ungraded registration\n";
                    }
                }
                else if (type == 2)
                {
                    try
                    {
                        // Gets the registration ID
                        registrationId = context.Registrations.Where(registration => registration.RegistrationNumber.ToString() == registrationNumber).SingleOrDefault().RegistrationId;
                        if (grade != "*")
                        {
                            double convertedGrade = Convert.ToDouble(grade);
                            if (convertedGrade >= 0 && convertedGrade <= 100)
                            {
                                convertedGrade = convertedGrade / 100;

                                // Updates the grade
                                client.updateGrade(convertedGrade, registrationId, notes);
                                logData += $"grade {convertedGrade} applied to student {studentNumber} for registration {registrationNumber}\n";
                            }
                            else
                            {
                                throw new Exception();
                            }

                            
                        }
                    }
                    catch (Exception)
                    {
                        logData += "ERROR: Student grade already exist \n";
                    }
                }
            }
        }

        /// <summary>
        /// Write the log data
        /// </summary>
        /// <returns></returns>
        public string writeLogData()
        {
            if (File.Exists("COMPLETE-" + inputFileName))
            {
                File.Delete("COMPLETE-" + inputFileName);
            }
            else if (File.Exists(inputFileName))
            {
                File.Move(inputFileName, "COMPLETE-" + inputFileName);

                StreamWriter writer = new StreamWriter(logFileName, true);
                writer.WriteLine(logData);
                writer.Close();
            }

            string savedLogData = logData;
            logData = null;
            logFileName = null;

            return savedLogData;

        }

        /// <summary>
        /// Process the transmission
        /// </summary>
        /// <param name="programAcronym">the Program Acronym</param>
        /// <param name="key">The key to decrypt the encrypted file</param>
        public void processTransmission(string programAcronym, string key)
        {
            try
            {
                int year = DateTime.Now.Year;
                int day = DateTime.Now.DayOfYear;

                inputFileName = year + "-" + day + "-" + programAcronym + ".xml";

                logFileName = "LOG " + year + "-" + day + "-" + programAcronym + ".txt";

                string encryptedFileName = $"{inputFileName}.encrypted";

                if (File.Exists(encryptedFileName))
                {
                    Encryption.decrypt(encryptedFileName, inputFileName, key);
                }
                else
                {
                    logData += $"No encrypted {inputFileName} found. \n";
                }

                if (File.Exists(inputFileName))
                {
                    processHeader();
                    processDetails();
                }
                else
                {
                    logData += $"The file {inputFileName} does not exist!\n";
                }

            }
            catch (Exception ex)
            {

                logData += $"{ex.Message}\n";

            }
        }
    }
}
