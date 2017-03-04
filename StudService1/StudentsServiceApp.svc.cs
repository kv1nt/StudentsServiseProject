using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
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
                var y = context.StudentInfos.ToList().Select(x => x.Copy()).ToList();
                return y;
            }
        }

        public List<ParentsInfo> ParentsInfosInfoList()
        {
            using (StudentsDbContext context = new StudentsDbContext())
            {
                var y = context.ParentsInfos.ToList().Select(x => x.Copy()).ToList();
                return y;
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
            try
            {
                using (StudentsDbContext context = new StudentsDbContext())
                {
                    StudentInfo student = context.StudentInfos.Where(c => c.Id == id).ToList().FirstOrDefault();

                    List<ParentsInfo> parents = student.ParentsInfo.ToList();

                    foreach (var parentsInfo in parents)
                    {
                        context.ParentsInfos.Remove(parentsInfo);
                    }
                    context.StudentInfos.Remove(student);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void UpdateStudent(int idSt, string nameSt, string lastNameSt, string surnameSt, int ageSt,
                           string addressSt, string groupSt, int numbRecBook, DateTime dateOfBirthSt,
                           float progressSt, List<Phone> phonesSt)
        {
            using (StudentsDbContext db = new StudentsDbContext())
            {
                try
                {
                    StudentInfo ChangeStud = db.StudentInfos.Where(c => c.Id == idSt).FirstOrDefault();
                    ChangeStud.FirstName = nameSt;
                    ChangeStud.LastName = lastNameSt;
                    ChangeStud.Surname = surnameSt;
                    ChangeStud.Age = ageSt;
                    ChangeStud.Adress.Address = addressSt;
                    ChangeStud.Group.Speciality = groupSt;
                    ChangeStud.NumberRecordBook = numbRecBook;
                    ChangeStud.Birthdate = dateOfBirthSt;
                    ChangeStud.StudentProgress.Progress = progressSt;
                    ChangeStud.StudentPhones.Clear();
                    ChangeStud.StudentPhones = phonesSt;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void UpdateStudent(StudentInfo student)
        {
            using (StudentsDbContext db = new StudentsDbContext())
            {
                try
                {
                    db.StudentInfos.AddOrUpdate(student);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /*
        public void UpdateParents(List<ParentsInfo> parents)
        {
        }
        */
        public void UpdateParents(string motherName, string motherLastName, string motherWorkPlace,
                                  string fatherName, string fatherLastName, string fatherWorkPlace, int motherId, int fatherId)
        {
            using (StudentsDbContext db = new StudentsDbContext())
            {
                try
                {
                    ParentsInfo ChangeMotherInfo = db.ParentsInfos.Where(x => x.Id == motherId).FirstOrDefault();
                    ParentsInfo ChangeFatherInfo = db.ParentsInfos.Where(x => x.Id == fatherId).FirstOrDefault();
                    ChangeMotherInfo.FirstName = motherName;
                    ChangeMotherInfo.LastName = motherLastName;
                    ChangeMotherInfo.WorkPlace = motherWorkPlace;
                    ChangeFatherInfo.FirstName = fatherName;
                    ChangeFatherInfo.LastName = fatherLastName;
                    ChangeFatherInfo.WorkPlace = fatherWorkPlace;
                    
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void UpdateAdditionalRelations(string relationInfo, int relationId)
        {
            using (StudentsDbContext db = new StudentsDbContext())
            {
                try
                {
                    ParentsInfo ChangeRelationInfo = db.ParentsInfos?.Where(x => x.Relation.Id == relationId).FirstOrDefault();
                    ChangeRelationInfo.Relation.Name = relationInfo;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }            
         }
     }
  }


