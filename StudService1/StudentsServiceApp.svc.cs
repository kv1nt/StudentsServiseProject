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

        public void AddNewStudent(string firstName, string lastName, string surname, int numbRecBook, string sex, int age, DateTime birthDateStud, Phone phone)


        {
            using (StudentsDbContext context = new StudentsDbContext())
            {
                StudentInfo newStudentInfo = new StudentInfo
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Surname = surname,
                    NumberRecordBook = numbRecBook,
                    Sex = sex,
                    Age = age,
                    Birthdate = birthDateStud,
                    StudentPhones = phone
                };

                context.StudentInfos.Add(newStudentInfo);
                context.SaveChanges();
            }
        }

       
    }
}

