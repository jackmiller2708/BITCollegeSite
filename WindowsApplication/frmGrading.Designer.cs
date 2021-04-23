namespace WindowsApplication
{
    partial class frmGrading
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label courseTypeLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label courseNumberLabel;
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.studentNumberMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.gbxGrade = new System.Windows.Forms.GroupBox();
            this.courseNumberMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.courseTypeLabel1 = new System.Windows.Forms.Label();
            this.lnkReturn = new System.Windows.Forms.LinkLabel();
            this.lnkUpdate = new System.Windows.Forms.LinkLabel();
            this.lblExisting = new System.Windows.Forms.Label();
            studentNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            courseTypeLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            courseNumberLabel = new System.Windows.Forms.Label();
            this.gbxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.gbxGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(38, 26);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 0;
            studentNumberLabel.Text = "Student Number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(38, 57);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(49, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Program:";
            // 
            // courseTypeLabel
            // 
            courseTypeLabel.AutoSize = true;
            courseTypeLabel.Location = new System.Drawing.Point(36, 56);
            courseTypeLabel.Name = "courseTypeLabel";
            courseTypeLabel.Size = new System.Drawing.Size(70, 13);
            courseTypeLabel.TabIndex = 13;
            courseTypeLabel.Text = "Course Type:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(120, 139);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(39, 13);
            gradeLabel.TabIndex = 15;
            gradeLabel.Text = "Grade:";
            // 
            // courseNumberLabel
            // 
            courseNumberLabel.AutoSize = true;
            courseNumberLabel.Location = new System.Drawing.Point(36, 31);
            courseNumberLabel.Name = "courseNumberLabel";
            courseNumberLabel.Size = new System.Drawing.Size(83, 13);
            courseNumberLabel.TabIndex = 16;
            courseNumberLabel.Text = "Course Number:";
            // 
            // gbxStudent
            // 
            this.gbxStudent.Controls.Add(descriptionLabel);
            this.gbxStudent.Controls.Add(this.descriptionLabel1);
            this.gbxStudent.Controls.Add(this.fullNameLabel1);
            this.gbxStudent.Controls.Add(studentNumberLabel);
            this.gbxStudent.Controls.Add(this.studentNumberMaskedLabel);
            this.gbxStudent.Location = new System.Drawing.Point(27, 26);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(561, 100);
            this.gbxStudent.TabIndex = 0;
            this.gbxStudent.TabStop = false;
            this.gbxStudent.Text = "Student Data";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Program.Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(131, 52);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(259, 23);
            this.descriptionLabel1.TabIndex = 4;
            this.descriptionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(BITCollege_NN.Models.Student);
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FullName", true));
            this.fullNameLabel1.Location = new System.Drawing.Point(246, 21);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(247, 23);
            this.fullNameLabel1.TabIndex = 3;
            this.fullNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentNumberMaskedLabel
            // 
            this.studentNumberMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentNumber", true));
            this.studentNumberMaskedLabel.Location = new System.Drawing.Point(131, 21);
            this.studentNumberMaskedLabel.Mask = "0000-0000";
            this.studentNumberMaskedLabel.Name = "studentNumberMaskedLabel";
            this.studentNumberMaskedLabel.Size = new System.Drawing.Size(100, 23);
            this.studentNumberMaskedLabel.TabIndex = 1;
            this.studentNumberMaskedLabel.Text = "    -";
            this.studentNumberMaskedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxGrade
            // 
            this.gbxGrade.Controls.Add(courseNumberLabel);
            this.gbxGrade.Controls.Add(this.courseNumberMaskedLabel);
            this.gbxGrade.Controls.Add(gradeLabel);
            this.gbxGrade.Controls.Add(this.gradeTextBox);
            this.gbxGrade.Controls.Add(this.titleLabel1);
            this.gbxGrade.Controls.Add(courseTypeLabel);
            this.gbxGrade.Controls.Add(this.courseTypeLabel1);
            this.gbxGrade.Controls.Add(this.lnkReturn);
            this.gbxGrade.Controls.Add(this.lnkUpdate);
            this.gbxGrade.Controls.Add(this.lblExisting);
            this.gbxGrade.Location = new System.Drawing.Point(78, 175);
            this.gbxGrade.Name = "gbxGrade";
            this.gbxGrade.Size = new System.Drawing.Size(462, 227);
            this.gbxGrade.TabIndex = 1;
            this.gbxGrade.TabStop = false;
            this.gbxGrade.Text = "Grade Information                  ";
            // 
            // courseNumberMaskedLabel
            // 
            this.courseNumberMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseNumberMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseNumber", true));
            this.courseNumberMaskedLabel.Location = new System.Drawing.Point(125, 26);
            this.courseNumberMaskedLabel.Name = "courseNumberMaskedLabel";
            this.courseNumberMaskedLabel.Size = new System.Drawing.Size(100, 23);
            this.courseNumberMaskedLabel.TabIndex = 17;
            this.courseNumberMaskedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataSource = typeof(BITCollege_NN.Models.Course);
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationsBindingSource, "Grade", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "P"));
            this.gradeTextBox.Location = new System.Drawing.Point(165, 136);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTextBox.TabIndex = 16;
            // 
            // registrationsBindingSource
            // 
            this.registrationsBindingSource.DataMember = "Registrations";
            this.registrationsBindingSource.DataSource = this.coursesBindingSource;
            // 
            // titleLabel1
            // 
            this.titleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Title", true));
            this.titleLabel1.Location = new System.Drawing.Point(245, 26);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(197, 23);
            this.titleLabel1.TabIndex = 15;
            this.titleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseTypeLabel1
            // 
            this.courseTypeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseTypeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseType", true));
            this.courseTypeLabel1.Location = new System.Drawing.Point(125, 51);
            this.courseTypeLabel1.Name = "courseTypeLabel1";
            this.courseTypeLabel1.Size = new System.Drawing.Size(100, 23);
            this.courseTypeLabel1.TabIndex = 14;
            this.courseTypeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkReturn
            // 
            this.lnkReturn.AutoSize = true;
            this.lnkReturn.Location = new System.Drawing.Point(219, 194);
            this.lnkReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkReturn.Name = "lnkReturn";
            this.lnkReturn.Size = new System.Drawing.Size(117, 13);
            this.lnkReturn.TabIndex = 12;
            this.lnkReturn.TabStop = true;
            this.lnkReturn.Text = "Return to Student Data";
            this.lnkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReturn_LinkClicked);
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.AutoSize = true;
            this.lnkUpdate.Location = new System.Drawing.Point(113, 194);
            this.lnkUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Size = new System.Drawing.Size(74, 13);
            this.lnkUpdate.TabIndex = 2;
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.Text = "Update Grade";
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // lblExisting
            // 
            this.lblExisting.AutoSize = true;
            this.lblExisting.Location = new System.Drawing.Point(266, 140);
            this.lblExisting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExisting.Name = "lblExisting";
            this.lblExisting.Size = new System.Drawing.Size(176, 13);
            this.lblExisting.TabIndex = 10;
            this.lblExisting.Text = "Existing grades cannot be overriden";
            this.lblExisting.Visible = false;
            // 
            // frmGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 453);
            this.Controls.Add(this.gbxGrade);
            this.Controls.Add(this.gbxStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGrading";
            this.Text = "Student Grading";
            this.Load += new System.EventHandler(this.frmGrading_Load);
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.gbxGrade.ResumeLayout(false);
            this.gbxGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudent;
        private System.Windows.Forms.GroupBox gbxGrade;
        private System.Windows.Forms.LinkLabel lnkReturn;
        private System.Windows.Forms.LinkLabel lnkUpdate;
        private System.Windows.Forms.Label lblExisting;
        private EWSoftware.MaskedLabelControl.MaskedLabel studentNumberMaskedLabel;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label fullNameLabel1;
        private System.Windows.Forms.BindingSource registrationsBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label courseTypeLabel1;
        private System.Windows.Forms.TextBox gradeTextBox;
        private EWSoftware.MaskedLabelControl.MaskedLabel courseNumberMaskedLabel;
    }
}