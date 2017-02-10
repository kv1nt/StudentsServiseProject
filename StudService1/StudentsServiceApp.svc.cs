using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DbEntities;


namespace StudService1
{
    public class StudentsServiceApp : IStudentsServiceApp
    {
        public List<StudentInfo> StudetsInfoList()
        {
            using (StudentsDbContext context = new StudentsDbContext())
            {
                return context.StudentInfos.ToList();
            }
        }

        public void AddNewStudent(string firstName, string lastName, string surname, int age, string sex, int numbRecBook,
            DateTime birthDateStud)
        {
            using (StudentsDbContext context = new StudentsDbContext())
            {
                StudentInfo newStudentInfo = new StudentInfo
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Surname = surname,
                    Age = age.ToString(),
                    Sex = sex,
                    NumberRecordBook = numbRecBook,
                    Birthdate = birthDateStud
                };

                context.StudentInfos.Add(newStudentInfo);
                context.SaveChanges();
            }
        }

      
    }
}

