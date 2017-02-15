using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DbEntities;

namespace StudService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentsServiceApp" in both code and config file together.
    [ServiceContract]
    public interface IStudentsServiceApp
    {
      
        [OperationContract]
        void AddNewStudent(StudentInfo student); // Add main info

        [OperationContract]
        List<StudentInfo> StudetsInfoList();
      
        
    }
}
