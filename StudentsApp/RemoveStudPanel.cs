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
    public partial class RemoveStudPanel : UserControl
    {
        private static RemoveStudPanel studListView;

        public static RemoveStudPanel removeStud
        {
            get
            {
                if (studListView == null)
                    studListView = new RemoveStudPanel();
                return studListView;
            }
        }

        public RemoveStudPanel()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FindStud_btn_Click(object sender, EventArgs e)
        {
            var IdField = Convert.ToInt32(FindStudField.Text);
           
            using (StudentsServiceAppClient client = new StudentsServiceAppClient())
            {
                StudentInfo student = client.FindStudentById(IdField);
                                                    
                    string[] row = {student.Id.ToString(), student.FirstName,student.Surname, student.LastName, student.Sex, student.Age.ToString(),
                                student.Birthdate.ToString(), string.Join(", ", student.StudentPhones?.Select(x => x.PhoneNumber.ToArray()))};

                var listView = new ListViewItem(row);
                RemoveList.Items.Add(listView);

                RemoveList.Columns[0].Width = 0;
            }
    
        }

        private void RemoveList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
