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


        private void label4_Click(object sender, EventArgs e)
        {

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
                    newPhone.PhoneNumber = Convert.ToInt32(MobTelField.Text);        
                    List<Phone> phone = new List<Phone>();
                    phone.Add(newPhone);

                    StudentInfo newStudentInfo = new StudentInfo
                    {
                        FirstName = NameField.Text,
                        LastName = LastNameField.Text,
                        Surname = surnameAddField.Text,
                        NumberRecordBook = Convert.ToInt32(NumbRecBookAddField.Text.Trim()),
                        Sex = SexField.Text,
                        Age = Convert.ToInt32(AgeField.Text),
                        Birthdate = DateTime.Parse(DateOfBirthField.Text),
                        StudentPhones = phone
                    }; 
                    client.AddNewStudent(newStudentInfo);
                    client.Close();
                }

                string message = "Student is added";
                string caption = "Add student";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
