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
        void AddNewStudent(StudentInfo student); // Add main info

        [OperationContract]
        List<StudentInfo> StudetsInfoList();

        [OperationContract]
        StudentInfo FindStudentById(int _id);

        [OperationContract]
        void DeleteStudentById(int _id);

    }
}
