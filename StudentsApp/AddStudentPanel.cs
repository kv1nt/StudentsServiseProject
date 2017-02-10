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

        private void AddMainInfo_btn_Click(object sender, EventArgs e)
        {

            
            try
            {
                
                StudentsServiceAppClient client = new StudentsServiceAppClient();
                client.AddNewStudent(NameField.Text, LastNameField.Text, SexField.Text, Convert.ToInt32(AgeField.Text.Trim()),
                                      DateOfBirthField.Text.Trim(), Convert.ToInt32(MobTelField.Text.Trim()), DateTime.Now);
                client.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
