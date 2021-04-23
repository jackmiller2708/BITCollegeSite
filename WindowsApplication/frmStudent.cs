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
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace WindowsApplication
{
    public partial class frmStudent : Form
    {
        ///Given: Student and Registration data will be retrieved
        ///in this form and passed throughout application
        ///These variables will be used to store the current
        ///Student and selected Registration
        ConstructorData constructorData = new ConstructorData();
        BITCollege_NNContext context = new BITCollege_NNContext();
        long returnedRegistrationNumber;

        delegate void SetLeaveCallBack(string somestring);
        

        public frmStudent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// given:  This constructor will be used when returning to frmStudent
        /// from another form.  This constructor will pass back
        /// specific information about the student and registration
        /// based on activites taking place in another form
        /// </summary>
        /// <param name="constructorData">Student data passed among forms</param>
        public frmStudent(ConstructorData constructorData)
        {
            InitializeComponent();
            //further code to be added

            this.constructorData = constructorData;
            
            studentNumberMaskedTextBox.Text = constructorData.GetStudent.StudentNumber.ToString();

            returnedRegistrationNumber = constructorData.GetRegistration.RegistrationNumber;

            studentNumberMaskedTextBox_Leave(this, EventArgs.Empty);
        }

        /// <summary>
        /// given: open grading form passing constructor data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setCurrentData();

            //instance of frmTransaction passing constructor data
            frmGrading frmGrading = new frmGrading(constructorData, constructorData.GetStudent, constructorData.GetRegistration);
            //open in frame
            frmGrading.MdiParent = this.MdiParent;
            //show form
            frmGrading.Show();
            this.Close();
        }

        /// <summary>
        /// given: open history form passing data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setCurrentData();

            //instance of frmHistory passing constructor data
            frmHistory frmHistory = new frmHistory(constructorData, constructorData.GetStudent, constructorData.GetRegistration);
            //open in frame
            frmHistory.MdiParent = this.MdiParent;
            //show form
            frmHistory.Show();
            this.Close();
        }

        /// <summary>
        /// given:  opens form in top right of frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStudent_Load(object sender, EventArgs e)
        {
            //keeps location of form static when opened and closed
            this.Location = new Point(0, 0);

        }

        /// <summary>
        /// Handles masked textbox leave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentNumberMaskedTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                BITCollege_NNContext context = new BITCollege_NNContext();
                if (studentNumberMaskedTextBox.MaskCompleted == true)
                {
                    // Get the student based on the input student number
                    Student students = context.Students.Where(student => student.StudentNumber.ToString() == studentNumberMaskedTextBox.Text).SingleOrDefault();

                    // If there's no student
                    if (students == null)
                    {
                        MessageBox.Show("Student Number does not exist", "Invalid Student Number");

                        // Disable all link buttons
                        setLnkEnabled(false);

                        // Clear all bindings
                        studentBindingSource.Clear();
                        registrationBindingSource.Clear();
                    }

                    else
                    {
                        // Set the datasouce for studentBindingSource
                        studentBindingSource.DataSource = students;
                       
                        int studentId = students.StudentId;

                        // Get a list of registrations based on the retrieved student's ID
                        List<Registration> registrations = context.Registrations.Where(registration => registration.StudentId == studentId).ToList();

                        // Set the datasource for registrationBindingSource
                        registrationBindingSource.DataSource = registrations;

                        // IF no registrations return
                        if (registrations.Count() == 0)
                        {

                            // Disable link buttons
                            setLnkEnabled(false);

                            // Clear registrationBindings
                            registrationBindingSource.Clear();
                        }
                        else
                        {
                            setLnkEnabled(true);

                            if (constructorData.GetRegistration != null)
                            {
                                cboRegistrationNumber.Text = returnedRegistrationNumber.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            
        }


        /// <summary>
        /// Sets all the link label on the form to the given boolean.
        /// </summary>
        /// <param name="boolean"></param>
        private void setLnkEnabled(bool boolean)
        {
            lbtnUpdateGrade.Enabled = boolean;
            lbtnViewDetails.Enabled = boolean;
        }

        /// <summary>
        /// Retrives the current data for the student and registration.
        /// </summary>
        private void setCurrentData()
        {
            constructorData.GetRegistration = (Registration)registrationBindingSource.Current;
            constructorData.GetStudent = (Student)studentBindingSource.Current;
        }

        private void setLeave(string somestring)
        {
            if (studentNumberMaskedTextBox.InvokeRequired)
            {
                object[] array = new object[] {somestring};

                SetLeaveCallBack callBack = setLeave;

                callBack(somestring);
            }
            else
            {
                int convertedValue = Convert.ToInt32(somestring);

                int lastThreeDigits = Convert.ToInt32(somestring.Substring(somestring.Length - 3));

                int multipliedValue = convertedValue * lastThreeDigits;

                string hexadecimalvalue = multipliedValue.ToString("X");

                string lastThreeCharacters = hexadecimalvalue.Substring(hexadecimalvalue.Length - 3);

                if (Regex.IsMatch(lastThreeCharacters, "/^((?![A-Z]).)*$/gm"))
                {
                    hexadecimalvalue = hexadecimalvalue.Substring(0, hexadecimalvalue.Length - 3);
                }

                long convertedLongValue = long.Parse(hexadecimalvalue, System.Globalization.NumberStyles.HexNumber);

                StudentCard studentCard = context.StudentCards.Where(card => card.CardNumber == convertedLongValue).SingleOrDefault();

                if (studentCard == null)
                {
                    throw new Exception("Invalid Student Card");
                }

                Student student = context.Students.Where(std => std.StudentId == studentCard.StudentId).SingleOrDefault();

                studentNumberMaskedTextBox.Text = student.StudentNumber.ToString();
                studentNumberMaskedTextBox_Leave(this, EventArgs.Empty);

            }
        }

        private void srlPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string result = srlPort.ReadExisting().Replace(" ","");

            if(result.Length == 12)
            {
                setLeave(result);
            }
        }

        private void openPort(string portName)
        {
            lblRFID.Visible = false;
            if (!srlPort.IsOpen)
            {
                srlPort.BaudRate = 9600;
                srlPort.PortName = portName;
                srlPort.Parity = Parity.None;
                srlPort.DataBits = 8;
                srlPort.StopBits = StopBits.One;
                srlPort.Handshake = Handshake.None;
                srlPort.ReadTimeout = 3000;
                srlPort.ReceivedBytesThreshold = 1;
                srlPort.DtrEnable = true;

                srlPort.Open();
            }
        }

        private void frmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (srlPort.IsOpen)
            {
                srlPort.Close();
            }
        }
    }
}
