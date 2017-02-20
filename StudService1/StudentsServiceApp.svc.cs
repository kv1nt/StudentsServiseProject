using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DbEntities;


namespace StudService1
{
    public class StudentsServiceApp : IStudentsServiceApp
    {
        public void AddNewStudent(StudentInfo student)
        {
            using (StudentsDbContext context = new StudentsDbContext())
            {
                context.StudentInfos.Add(student);
                context.SaveChanges();

            }
        }

        public List<StudentInfo> StudetsInfoList()
        {
            using (StudentsDbContext context = new StudentsDbContext())
            {
                return context.StudentInfos.ToList().Select(x => x.Copy()).ToList();
            }
        }

        public StudentInfo FindStudentById(int id)
        {
            using (StudentsDbContext context = new StudentsDbContext())
            {
                StudentInfo student = context.StudentInfos.Where(c => c.Id == id).ToList().SingleOrDefault();
                if (student == null)
                    throw new ArgumentNullException(nameof(student));

                return student;
            }
        }

        public void DeleteStudentById(int id)
        {
            
                using (StudentsDbContext context = new StudentsDbContext())
                {
                StudentInfo student = context.StudentInfos.Where(c => c.Id == id).ToList().SingleOrDefault();

                context.StudentInfos.Remove(student);
                context.SaveChanges();
            }
                            
        }
    }
    }


