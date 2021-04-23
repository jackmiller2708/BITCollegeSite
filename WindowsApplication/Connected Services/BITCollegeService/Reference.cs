﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsApplication.BITCollegeService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BITCollegeService.ICollegeRegistration")]
    public interface ICollegeRegistration {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollegeRegistration/dropCourse", ReplyAction="http://tempuri.org/ICollegeRegistration/dropCourseResponse")]
        bool dropCourse(int registrationID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollegeRegistration/dropCourse", ReplyAction="http://tempuri.org/ICollegeRegistration/dropCourseResponse")]
        System.Threading.Tasks.Task<bool> dropCourseAsync(int registrationID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollegeRegistration/registerCourse", ReplyAction="http://tempuri.org/ICollegeRegistration/registerCourseResponse")]
        int registerCourse(int studentID, int courseID, string notes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollegeRegistration/registerCourse", ReplyAction="http://tempuri.org/ICollegeRegistration/registerCourseResponse")]
        System.Threading.Tasks.Task<int> registerCourseAsync(int studentID, int courseID, string notes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollegeRegistration/updateGrade", ReplyAction="http://tempuri.org/ICollegeRegistration/updateGradeResponse")]
        void updateGrade(double grade, int registrationId, string notes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollegeRegistration/updateGrade", ReplyAction="http://tempuri.org/ICollegeRegistration/updateGradeResponse")]
        System.Threading.Tasks.Task updateGradeAsync(double grade, int registrationId, string notes);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICollegeRegistrationChannel : WindowsApplication.BITCollegeService.ICollegeRegistration, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CollegeRegistrationClient : System.ServiceModel.ClientBase<WindowsApplication.BITCollegeService.ICollegeRegistration>, WindowsApplication.BITCollegeService.ICollegeRegistration {
        
        public CollegeRegistrationClient() {
        }
        
        public CollegeRegistrationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CollegeRegistrationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CollegeRegistrationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CollegeRegistrationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool dropCourse(int registrationID) {
            return base.Channel.dropCourse(registrationID);
        }
        
        public System.Threading.Tasks.Task<bool> dropCourseAsync(int registrationID) {
            return base.Channel.dropCourseAsync(registrationID);
        }
        
        public int registerCourse(int studentID, int courseID, string notes) {
            return base.Channel.registerCourse(studentID, courseID, notes);
        }
        
        public System.Threading.Tasks.Task<int> registerCourseAsync(int studentID, int courseID, string notes) {
            return base.Channel.registerCourseAsync(studentID, courseID, notes);
        }
        
        public void updateGrade(double grade, int registrationId, string notes) {
            base.Channel.updateGrade(grade, registrationId, notes);
        }
        
        public System.Threading.Tasks.Task updateGradeAsync(double grade, int registrationId, string notes) {
            return base.Channel.updateGradeAsync(grade, registrationId, notes);
        }
    }
}