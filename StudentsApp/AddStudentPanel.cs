using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsApp.StudentService2;


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
          /*  try
            {
                using (StudentsServiceAppClient client = new StudentsServiceAppClient()) 
                {
                    Phone phone = new Phone();
                    
                    client.AddNewStudent(NameField.Text, LastNameField.Text, SexField.Text, Convert.ToInt32(NumbRecBookAddField.Text.Trim()), AgeField.Text.Trim(),
                                         Convert.ToInt32(DateOfBirthField.Text.Trim()), MobTelField.Text);
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
        */
    }
}
