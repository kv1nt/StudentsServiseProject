using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DbEntities;

namespace StudService1
{
   
    [ServiceContract]
    public interface IStudentsServiceApp
    {      

        [OperationContract]
        List<StudentInfo> StudetsInfoList();

        [OperationContract]
        List<ParentsInfo> ParentsInfosInfoList();

        [OperationContract]
        StudentInfo FindStudentById(int id);

        [OperationContract]
        void DeleteStudentById(int id);

        [OperationContract]
        void AddNewStudent(StudentInfo student);

        [OperationContract]
        void UpdateStudent(int id, string nameSt, string lastNameSt, string surnameSt, int ageSt,
                           string addressSt, string groupSt, int numbRecBook, DateTime dateOfBirthSt,
                           float progressSt, List<Phone> phonesSt);

        [OperationContract]
        void UpdateParents(string motherName, string motherLastName, string motherWorkPlace,
                           string fatherName, string fatherLastName, string fatherWorkPlace, int motherId, int fatherId);

        [OperationContract]
        void UpdateAdditionalRelations(string relationInfo, int relationId);


    }
}
