﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsApp.StudentService2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentService2.IStudentsServiceApp")]
    public interface IStudentsServiceApp {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/StudetsInfoList", ReplyAction="http://tempuri.org/IStudentsServiceApp/StudetsInfoListResponse")]
        DbEntities.StudentInfo[] StudetsInfoList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/StudetsInfoList", ReplyAction="http://tempuri.org/IStudentsServiceApp/StudetsInfoListResponse")]
        System.Threading.Tasks.Task<DbEntities.StudentInfo[]> StudetsInfoListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/ParentsInfosInfoList", ReplyAction="http://tempuri.org/IStudentsServiceApp/ParentsInfosInfoListResponse")]
        DbEntities.ParentsInfo[] ParentsInfosInfoList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/ParentsInfosInfoList", ReplyAction="http://tempuri.org/IStudentsServiceApp/ParentsInfosInfoListResponse")]
        System.Threading.Tasks.Task<DbEntities.ParentsInfo[]> ParentsInfosInfoListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/FindStudentById", ReplyAction="http://tempuri.org/IStudentsServiceApp/FindStudentByIdResponse")]
        DbEntities.StudentInfo FindStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/FindStudentById", ReplyAction="http://tempuri.org/IStudentsServiceApp/FindStudentByIdResponse")]
        System.Threading.Tasks.Task<DbEntities.StudentInfo> FindStudentByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/DeleteStudentById", ReplyAction="http://tempuri.org/IStudentsServiceApp/DeleteStudentByIdResponse")]
        void DeleteStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/DeleteStudentById", ReplyAction="http://tempuri.org/IStudentsServiceApp/DeleteStudentByIdResponse")]
        System.Threading.Tasks.Task DeleteStudentByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/AddNewStudent", ReplyAction="http://tempuri.org/IStudentsServiceApp/AddNewStudentResponse")]
        void AddNewStudent(DbEntities.StudentInfo student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/AddNewStudent", ReplyAction="http://tempuri.org/IStudentsServiceApp/AddNewStudentResponse")]
        System.Threading.Tasks.Task AddNewStudentAsync(DbEntities.StudentInfo student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/UpdateStudent", ReplyAction="http://tempuri.org/IStudentsServiceApp/UpdateStudentResponse")]
        void UpdateStudent(int id, string nameSt, string lastNameSt, string surnameSt, int ageSt, string addressSt, string groupSt, int numbRecBook, System.DateTime dateOfBirthSt, float progressSt, DbEntities.Phone[] phonesSt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/UpdateStudent", ReplyAction="http://tempuri.org/IStudentsServiceApp/UpdateStudentResponse")]
        System.Threading.Tasks.Task UpdateStudentAsync(int id, string nameSt, string lastNameSt, string surnameSt, int ageSt, string addressSt, string groupSt, int numbRecBook, System.DateTime dateOfBirthSt, float progressSt, DbEntities.Phone[] phonesSt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/UpdateParents", ReplyAction="http://tempuri.org/IStudentsServiceApp/UpdateParentsResponse")]
        void UpdateParents(string motherName, string motherLastName, string motherWorkPlace, string fatherName, string fatherLastName, string fatherWorkPlace, int motherId, int fatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/UpdateParents", ReplyAction="http://tempuri.org/IStudentsServiceApp/UpdateParentsResponse")]
        System.Threading.Tasks.Task UpdateParentsAsync(string motherName, string motherLastName, string motherWorkPlace, string fatherName, string fatherLastName, string fatherWorkPlace, int motherId, int fatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/UpdateAdditionalRelations", ReplyAction="http://tempuri.org/IStudentsServiceApp/UpdateAdditionalRelationsResponse")]
        void UpdateAdditionalRelations(string relationInfo, int relationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsServiceApp/UpdateAdditionalRelations", ReplyAction="http://tempuri.org/IStudentsServiceApp/UpdateAdditionalRelationsResponse")]
        System.Threading.Tasks.Task UpdateAdditionalRelationsAsync(string relationInfo, int relationId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentsServiceAppChannel : StudentsApp.StudentService2.IStudentsServiceApp, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentsServiceAppClient : System.ServiceModel.ClientBase<StudentsApp.StudentService2.IStudentsServiceApp>, StudentsApp.StudentService2.IStudentsServiceApp {
        
        public StudentsServiceAppClient() {
        }
        
        public StudentsServiceAppClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentsServiceAppClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentsServiceAppClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentsServiceAppClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DbEntities.StudentInfo[] StudetsInfoList() {
            return base.Channel.StudetsInfoList();
        }
        
        public System.Threading.Tasks.Task<DbEntities.StudentInfo[]> StudetsInfoListAsync() {
            return base.Channel.StudetsInfoListAsync();
        }
        
        public DbEntities.ParentsInfo[] ParentsInfosInfoList() {
            return base.Channel.ParentsInfosInfoList();
        }
        
        public System.Threading.Tasks.Task<DbEntities.ParentsInfo[]> ParentsInfosInfoListAsync() {
            return base.Channel.ParentsInfosInfoListAsync();
        }
        
        public DbEntities.StudentInfo FindStudentById(int id) {
            return base.Channel.FindStudentById(id);
        }
        
        public System.Threading.Tasks.Task<DbEntities.StudentInfo> FindStudentByIdAsync(int id) {
            return base.Channel.FindStudentByIdAsync(id);
        }
        
        public void DeleteStudentById(int id) {
            base.Channel.DeleteStudentById(id);
        }
        
        public System.Threading.Tasks.Task DeleteStudentByIdAsync(int id) {
            return base.Channel.DeleteStudentByIdAsync(id);
        }
        
        public void AddNewStudent(DbEntities.StudentInfo student) {
            base.Channel.AddNewStudent(student);
        }
        
        public System.Threading.Tasks.Task AddNewStudentAsync(DbEntities.StudentInfo student) {
            return base.Channel.AddNewStudentAsync(student);
        }
        
        public void UpdateStudent(int id, string nameSt, string lastNameSt, string surnameSt, int ageSt, string addressSt, string groupSt, int numbRecBook, System.DateTime dateOfBirthSt, float progressSt, DbEntities.Phone[] phonesSt) {
            base.Channel.UpdateStudent(id, nameSt, lastNameSt, surnameSt, ageSt, addressSt, groupSt, numbRecBook, dateOfBirthSt, progressSt, phonesSt);
        }
        
        public System.Threading.Tasks.Task UpdateStudentAsync(int id, string nameSt, string lastNameSt, string surnameSt, int ageSt, string addressSt, string groupSt, int numbRecBook, System.DateTime dateOfBirthSt, float progressSt, DbEntities.Phone[] phonesSt) {
            return base.Channel.UpdateStudentAsync(id, nameSt, lastNameSt, surnameSt, ageSt, addressSt, groupSt, numbRecBook, dateOfBirthSt, progressSt, phonesSt);
        }
        
        public void UpdateParents(string motherName, string motherLastName, string motherWorkPlace, string fatherName, string fatherLastName, string fatherWorkPlace, int motherId, int fatherId) {
            base.Channel.UpdateParents(motherName, motherLastName, motherWorkPlace, fatherName, fatherLastName, fatherWorkPlace, motherId, fatherId);
        }
        
        public System.Threading.Tasks.Task UpdateParentsAsync(string motherName, string motherLastName, string motherWorkPlace, string fatherName, string fatherLastName, string fatherWorkPlace, int motherId, int fatherId) {
            return base.Channel.UpdateParentsAsync(motherName, motherLastName, motherWorkPlace, fatherName, fatherLastName, fatherWorkPlace, motherId, fatherId);
        }
        
        public void UpdateAdditionalRelations(string relationInfo, int relationId) {
            base.Channel.UpdateAdditionalRelations(relationInfo, relationId);
        }
        
        public System.Threading.Tasks.Task UpdateAdditionalRelationsAsync(string relationInfo, int relationId) {
            return base.Channel.UpdateAdditionalRelationsAsync(relationInfo, relationId);
        }
    }
}
