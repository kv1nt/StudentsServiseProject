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

    }
}
