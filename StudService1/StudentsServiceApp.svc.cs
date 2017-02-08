using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudService1
{
    public class StudentsServiceApp : IStudentsServiceApp
    {
       
      public string showMessage()
      {
         string message = "All is work";
         return message;
      }
   }
}

