namespace WindowsApplication
{
    partial class frmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label studentNumberLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label provinceLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label dateCreatedLabel;
            System.Windows.Forms.Label outstandingFeesLabel;
            System.Windows.Forms.Label gradePointAverageLabel;
            System.Windows.Forms.Label registrationNumberLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label creditHoursLabel;
            System.Windows.Forms.Label courseNumberLabel;
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradePointAverageLabel1 = new System.Windows.Forms.Label();
            this.studentNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.outstandingFeesLabel1 = new System.Windows.Forms.Label();
            this.dateCreatedMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.postalCodeMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.provinceMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.gbxRegistration = new System.Windows.Forms.GroupBox();
            this.cboRegistrationNumber = new System.Windows.Forms.ComboBox();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditHoursLabel1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.courseNumberLabel1 = new System.Windows.Forms.Label();
            this.gPAStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbtnUpdateGrade = new System.Windows.Forms.LinkLabel();
            this.lbtnViewDetails = new System.Windows.Forms.LinkLabel();
            this.srlPort = new System.IO.Ports.SerialPort(this.components);
            studentNumberLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            provinceLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dateCreatedLabel = new System.Windows.Forms.Label();
            outstandingFeesLabel = new System.Windows.Forms.Label();
            gradePointAverageLabel = new System.Windows.Forms.Label();
            registrationNumberLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            creditHoursLabel = new System.Windows.Forms.Label();
            courseNumberLabel = new System.Windows.Forms.Label();
            this.gbxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.gbxRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPAStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(48, 33);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 1;
            studentNumberLabel.Text = "Student Number:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(50, 63);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name:";
            fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(48, 93);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new System.Drawing.Point(305, 123);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new System.Drawing.Size(52, 13);
            provinceLabel.TabIndex = 9;
            provinceLabel.Text = "Province:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(466, 123);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 11;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(48, 123);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 12;
            cityLabel.Text = "City:";
            // 
            // dateCreatedLabel
            // 
            dateCreatedLabel.AutoSize = true;
            dateCreatedLabel.Location = new System.Drawing.Point(47, 154);
            dateCreatedLabel.Name = "dateCreatedLabel";
            dateCreatedLabel.Size = new System.Drawing.Size(73, 13);
            dateCreatedLabel.TabIndex = 13;
            dateCreatedLabel.Text = "Date Created:";
            // 
            // outstandingFeesLabel
            // 
            outstandingFeesLabel.AutoSize = true;
            outstandingFeesLabel.Location = new System.Drawing.Point(305, 154);
            outstandingFeesLabel.Name = "outstandingFeesLabel";
            outstandingFeesLabel.Size = new System.Drawing.Size(93, 13);
            outstandingFeesLabel.TabIndex = 15;
            outstandingFeesLabel.Text = "Outstanding Fees:";
            // 
            // gradePointAverageLabel
            // 
            gradePointAverageLabel.AutoSize = true;
            gradePointAverageLabel.Location = new System.Drawing.Point(48, 183);
            gradePointAverageLabel.Name = "gradePointAverageLabel";
            gradePointAverageLabel.Size = new System.Drawing.Size(109, 13);
            gradePointAverageLabel.TabIndex = 17;
            gradePointAverageLabel.Text = "Grade Point Average:";
            // 
            // registrationNumberLabel
            // 
            registrationNumberLabel.AutoSize = true;
            registrationNumberLabel.Location = new System.Drawing.Point(47, 30);
            registrationNumberLabel.Name = "registrationNumberLabel";
            registrationNumberLabel.Size = new System.Drawing.Size(106, 13);
            registrationNumberLabel.TabIndex = 0;
            registrationNumberLabel.Text = "Registration Number:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(314, 62);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title:";
            // 
            // creditHoursLabel
            // 
            creditHoursLabel.AutoSize = true;
            creditHoursLabel.Location = new System.Drawing.Point(47, 99);
            creditHoursLabel.Name = "creditHoursLabel";
            creditHoursLabel.Size = new System.Drawing.Size(68, 13);
            creditHoursLabel.TabIndex = 6;
            creditHoursLabel.Text = "Credit Hours:";
            // 
            // courseNumberLabel
            // 
            courseNumberLabel.AutoSize = true;
            courseNumberLabel.Location = new System.Drawing.Point(47, 62);
            courseNumberLabel.Name = "courseNumberLabel";
            courseNumberLabel.Size = new System.Drawing.Size(83, 13);
            courseNumberLabel.TabIndex = 2;
            courseNumberLabel.Text = "Course Number:";
            // 
            // gbxStudent
            // 
            this.gbxStudent.Controls.Add(this.descriptionLabel1);
            this.gbxStudent.Controls.Add(gradePointAverageLabel);
            this.gbxStudent.Controls.Add(this.gradePointAverageLabel1);
            this.gbxStudent.Controls.Add(outstandingFeesLabel);
            this.gbxStudent.Controls.Add(this.studentNumberMaskedTextBox);
            this.gbxStudent.Controls.Add(this.outstandingFeesLabel1);
            this.gbxStudent.Controls.Add(dateCreatedLabel);
            this.gbxStudent.Controls.Add(this.dateCreatedMaskedLabel);
            this.gbxStudent.Controls.Add(cityLabel);
            this.gbxStudent.Controls.Add(this.cityLabel1);
            this.gbxStudent.Controls.Add(postalCodeLabel);
            this.gbxStudent.Controls.Add(this.postalCodeMaskedLabel);
            this.gbxStudent.Controls.Add(provinceLabel);
            this.gbxStudent.Controls.Add(this.provinceMaskedLabel);
            this.gbxStudent.Controls.Add(addressLabel);
            this.gbxStudent.Controls.Add(this.addressLabel1);
            this.gbxStudent.Controls.Add(fullNameLabel);
            this.gbxStudent.Controls.Add(this.fullNameLabel1);
            this.gbxStudent.Controls.Add(studentNumberLabel);
            this.gbxStudent.Controls.Add(this.lblRFID);
            this.gbxStudent.Location = new System.Drawing.Point(31, 50);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(745, 239);
            this.gbxStudent.TabIndex = 0;
            this.gbxStudent.TabStop = false;
            this.gbxStudent.Text = "Student Data";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "GPAState.Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(308, 179);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(100, 20);
            this.descriptionLabel1.TabIndex = 20;
            this.descriptionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(BITCollege_NN.Models.Student);
            // 
            // gradePointAverageLabel1
            // 
            this.gradePointAverageLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradePointAverageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "GradePointAverage", true));
            this.gradePointAverageLabel1.Location = new System.Drawing.Point(162, 179);
            this.gradePointAverageLabel1.Name = "gradePointAverageLabel1";
            this.gradePointAverageLabel1.Size = new System.Drawing.Size(100, 20);
            this.gradePointAverageLabel1.TabIndex = 18;
            this.gradePointAverageLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentNumberMaskedTextBox
            // 
            this.studentNumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentNumber", true));
            this.studentNumberMaskedTextBox.Location = new System.Drawing.Point(162, 26);
            this.studentNumberMaskedTextBox.Mask = "0000-0000";
            this.studentNumberMaskedTextBox.Name = "studentNumberMaskedTextBox";
            this.studentNumberMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNumberMaskedTextBox.TabIndex = 2;
            this.studentNumberMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.studentNumberMaskedTextBox.Leave += new System.EventHandler(this.studentNumberMaskedTextBox_Leave);
            // 
            // outstandingFeesLabel1
            // 
            this.outstandingFeesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outstandingFeesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "OutstandingFees", true));
            this.outstandingFeesLabel1.Location = new System.Drawing.Point(404, 150);
            this.outstandingFeesLabel1.Name = "outstandingFeesLabel1";
            this.outstandingFeesLabel1.Size = new System.Drawing.Size(100, 20);
            this.outstandingFeesLabel1.TabIndex = 16;
            this.outstandingFeesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateCreatedMaskedLabel
            // 
            this.dateCreatedMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateCreatedMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "DateCreated", true));
            this.dateCreatedMaskedLabel.Location = new System.Drawing.Point(162, 150);
            this.dateCreatedMaskedLabel.Name = "dateCreatedMaskedLabel";
            this.dateCreatedMaskedLabel.Size = new System.Drawing.Size(100, 20);
            this.dateCreatedMaskedLabel.TabIndex = 14;
            this.dateCreatedMaskedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityLabel1
            // 
            this.cityLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "City", true));
            this.cityLabel1.Location = new System.Drawing.Point(162, 119);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(128, 20);
            this.cityLabel1.TabIndex = 13;
            this.cityLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // postalCodeMaskedLabel
            // 
            this.postalCodeMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postalCodeMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "PostalCode", true));
            this.postalCodeMaskedLabel.Location = new System.Drawing.Point(539, 119);
            this.postalCodeMaskedLabel.Name = "postalCodeMaskedLabel";
            this.postalCodeMaskedLabel.Size = new System.Drawing.Size(82, 20);
            this.postalCodeMaskedLabel.TabIndex = 12;
            this.postalCodeMaskedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // provinceMaskedLabel
            // 
            this.provinceMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.provinceMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Province", true));
            this.provinceMaskedLabel.Location = new System.Drawing.Point(363, 119);
            this.provinceMaskedLabel.Name = "provinceMaskedLabel";
            this.provinceMaskedLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.provinceMaskedLabel.Size = new System.Drawing.Size(73, 20);
            this.provinceMaskedLabel.TabIndex = 10;
            this.provinceMaskedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel1
            // 
            this.addressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.addressLabel1.Location = new System.Drawing.Point(162, 90);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(459, 16);
            this.addressLabel1.TabIndex = 6;
            this.addressLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FullName", true));
            this.fullNameLabel1.Location = new System.Drawing.Point(162, 59);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(459, 20);
            this.fullNameLabel1.TabIndex = 4;
            this.fullNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.ForeColor = System.Drawing.Color.Red;
            this.lblRFID.Location = new System.Drawing.Point(371, 33);
            this.lblRFID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(250, 13);
            this.lblRFID.TabIndex = 0;
            this.lblRFID.Text = "RFID Unavailable - Enter Student Number Manually";
            // 
            // gbxRegistration
            // 
            this.gbxRegistration.Controls.Add(this.cboRegistrationNumber);
            this.gbxRegistration.Controls.Add(creditHoursLabel);
            this.gbxRegistration.Controls.Add(this.creditHoursLabel1);
            this.gbxRegistration.Controls.Add(titleLabel);
            this.gbxRegistration.Controls.Add(this.titleLabel1);
            this.gbxRegistration.Controls.Add(courseNumberLabel);
            this.gbxRegistration.Controls.Add(this.courseNumberLabel1);
            this.gbxRegistration.Controls.Add(registrationNumberLabel);
            this.gbxRegistration.Location = new System.Drawing.Point(31, 300);
            this.gbxRegistration.Name = "gbxRegistration";
            this.gbxRegistration.Size = new System.Drawing.Size(745, 147);
            this.gbxRegistration.TabIndex = 1;
            this.gbxRegistration.TabStop = false;
            this.gbxRegistration.Text = "Registration Information";
            // 
            // cboRegistrationNumber
            // 
            this.cboRegistrationNumber.DataSource = this.registrationBindingSource;
            this.cboRegistrationNumber.DisplayMember = "RegistrationNumber";
            this.cboRegistrationNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegistrationNumber.FormattingEnabled = true;
            this.cboRegistrationNumber.Location = new System.Drawing.Point(162, 27);
            this.cboRegistrationNumber.Name = "cboRegistrationNumber";
            this.cboRegistrationNumber.Size = new System.Drawing.Size(100, 21);
            this.cboRegistrationNumber.TabIndex = 8;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataSource = typeof(BITCollege_NN.Models.Registration);
            // 
            // creditHoursLabel1
            // 
            this.creditHoursLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditHoursLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Course.CreditHours", true));
            this.creditHoursLabel1.Location = new System.Drawing.Point(162, 94);
            this.creditHoursLabel1.Name = "creditHoursLabel1";
            this.creditHoursLabel1.Size = new System.Drawing.Size(100, 23);
            this.creditHoursLabel1.TabIndex = 7;
            this.creditHoursLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel1
            // 
            this.titleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Course.Title", true));
            this.titleLabel1.Location = new System.Drawing.Point(350, 57);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(271, 23);
            this.titleLabel1.TabIndex = 5;
            this.titleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseNumberLabel1
            // 
            this.courseNumberLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseNumberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Course.CourseNumber", true));
            this.courseNumberLabel1.Location = new System.Drawing.Point(162, 57);
            this.courseNumberLabel1.Name = "courseNumberLabel1";
            this.courseNumberLabel1.Size = new System.Drawing.Size(100, 22);
            this.courseNumberLabel1.TabIndex = 3;
            this.courseNumberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gPAStateBindingSource
            // 
            this.gPAStateBindingSource.DataSource = typeof(BITCollege_NN.Models.GPAState);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(BITCollege_NN.Models.Course);
            // 
            // lbtnUpdateGrade
            // 
            this.lbtnUpdateGrade.AutoSize = true;
            this.lbtnUpdateGrade.Location = new System.Drawing.Point(247, 475);
            this.lbtnUpdateGrade.Name = "lbtnUpdateGrade";
            this.lbtnUpdateGrade.Size = new System.Drawing.Size(74, 13);
            this.lbtnUpdateGrade.TabIndex = 5;
            this.lbtnUpdateGrade.TabStop = true;
            this.lbtnUpdateGrade.Text = "Update Grade";
            this.lbtnUpdateGrade.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // lbtnViewDetails
            // 
            this.lbtnViewDetails.AutoSize = true;
            this.lbtnViewDetails.Location = new System.Drawing.Point(391, 475);
            this.lbtnViewDetails.Name = "lbtnViewDetails";
            this.lbtnViewDetails.Size = new System.Drawing.Size(65, 13);
            this.lbtnViewDetails.TabIndex = 6;
            this.lbtnViewDetails.TabStop = true;
            this.lbtnViewDetails.Text = "View Details";
            this.lbtnViewDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDetails_LinkClicked);
            // 
            // srlPort
            // 
            this.srlPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.srlPort_DataReceived);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 610);
            this.Controls.Add(this.lbtnViewDetails);
            this.Controls.Add(this.lbtnUpdateGrade);
            this.Controls.Add(this.gbxRegistration);
            this.Controls.Add(this.gbxStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStudent";
            this.Text = "Student Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStudent_FormClosing);
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.gbxRegistration.ResumeLayout(false);
            this.gbxRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPAStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudent;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.GroupBox gbxRegistration;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.Label fullNameLabel1;
        private System.Windows.Forms.MaskedTextBox studentNumberMaskedTextBox;
        private System.Windows.Forms.BindingSource gPAStateBindingSource;
        private System.Windows.Forms.Label gradePointAverageLabel1;
        private System.Windows.Forms.Label outstandingFeesLabel1;
        private EWSoftware.MaskedLabelControl.MaskedLabel dateCreatedMaskedLabel;
        private System.Windows.Forms.Label cityLabel1;
        private EWSoftware.MaskedLabelControl.MaskedLabel postalCodeMaskedLabel;
        private EWSoftware.MaskedLabelControl.MaskedLabel provinceMaskedLabel;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private System.Windows.Forms.LinkLabel lbtnUpdateGrade;
        private System.Windows.Forms.LinkLabel lbtnViewDetails;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label creditHoursLabel1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.ComboBox cboRegistrationNumber;
        private System.Windows.Forms.Label courseNumberLabel1;
        private System.IO.Ports.SerialPort srlPort;
    }
}