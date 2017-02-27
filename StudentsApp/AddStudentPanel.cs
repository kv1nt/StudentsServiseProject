using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbEntities;
using StudentsApp.StudentService2;
using StudService1;

namespace StudentsApp
{

    public partial class AddStudentPanel : UserControl
    {
        private static AddStudentPanel studListView;



        public static AddStudentPanel addStudent
        {
            get
            {
                if (studListView == null)
                    studListView = new AddStudentPanel();
                return studListView;
            }
        }

        public AddStudentPanel()
        {
            InitializeComponent();
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMainInfo_btn_Click(object sender, EventArgs e) // Add main info student
        {

            try
            {
                using (StudentsServiceAppClient client = new StudentsServiceAppClient())
                {
                    Phone newPhone = new Phone();
                    newPhone.PhoneNumber = MobTelField.Text; 
                           
                    List<Phone> phone = new List<Phone>();
                    phone.Add(newPhone);

                    StudentProgress newProgress = new StudentProgress();
                    newProgress.Progress = float.Parse(ProgressAddField.Text);

                    Adress newAdress = new Adress();
                    newAdress.Address = AddressAddField.Text;

                    Group newGroup = new Group();
                    newGroup.Speciality = GroupAddField.Text;


                    Phone newParentsPhone = new Phone();
                    newParentsPhone.PhoneNumber = PhonesRelatonsAddFielad.Text;

                    List<Phone> relationsPhones = new List<Phone>();
                    relationsPhones.Add(newParentsPhone);

                    ParentsInfo newMotheInfo = new ParentsInfo();                    
                    ParentsInfo newFatherInfo = new ParentsInfo();

                   
                    Relation newRelationInfo = new Relation();
                    newRelationInfo.Name = RelationField.Text;

                    newMotheInfo.FirstName = MotherNameField.Text;
                    newMotheInfo.LastName = MotherLastNameField.Text;
                    newMotheInfo.WorkPlace = MotherWorkPlace.Text;
                    newMotheInfo.Relation = newRelationInfo;
                    newMotheInfo.Phones = relationsPhones;
                    newFatherInfo.FirstName = FatherNameField.Text;
                    newFatherInfo.LastName = FatherLastNameField.Text;
                    newFatherInfo.WorkPlace = FatherWorkPlaseField.Text;
                    newFatherInfo.Phones = relationsPhones;
                    newFatherInfo.Relation = newRelationInfo;

                   List<ParentsInfo> parents = new List<ParentsInfo>();
                    parents.Add(newMotheInfo);
                    parents.Add(newFatherInfo);
                   // parents.Add(newRelationInfo);
                    
                   

                    StudentInfo newStudentInfo = new StudentInfo
                    {
                        FirstName = NameField.Text,
                        LastName = LastNameField.Text,
                        Surname = surnameAddField.Text,
                        NumberRecordBook = Convert.ToInt32(NumbRecBookAddField.Text),
                        Sex = SexField.Text,
                        Age = Convert.ToInt32(AgeField.Text),
                        Birthdate = DateTime.Parse(DateOfBirthField.Text),
                        StudentPhones = phone,
                        StudentProgress = newProgress,
                        Adress = newAdress,
                        Group = newGroup,
                        ParentsInfo = parents,                        

                    }; 
                    client.AddNewStudent(newStudentInfo);
                    client.Close();
                }

                string message = "Студент був доданий";
                string caption = "Додання студента до БД";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Помилка!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddStudentPanel_Load(object sender, EventArgs e)
        {

        }
    }

}
