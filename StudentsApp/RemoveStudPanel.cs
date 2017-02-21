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
            RemoveList.Items.Clear();

            var snfield = FindStudField.Text;
    
            using (StudentsServiceAppClient client = new StudentsServiceAppClient())
            {
                foreach (var item in client.StudetsInfoList())
                {
                    if (item.LastName == snfield)
                    {
                        string[] row =
                        {
                            item.Id.ToString(), item.FirstName, item.Surname, item.LastName, item.Sex,
                            item.Age.ToString(),
                            item.Birthdate.ToString(),
                            string.Join(", ", item.StudentPhones?.Select(x => x.PhoneNumber.ToArray()))

                        };
                        var listView = new ListViewItem(row);
                        RemoveList.Items.Add(listView);                       
                        
                    }
                   
                }
                
            }
            
        }

        private void RemoveList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveStud_btn_Click(object sender, EventArgs e)
        {
            int idStud = Convert.ToInt32(RemoveStudByIdField.Text);

            using (StudentsServiceAppClient client = new StudentsServiceAppClient())
            {
                foreach (var item in client.StudetsInfoList())
                {
                    if (item.Id == idStud)
                    {
                        client.DeleteStudentById(idStud);
                    }
                }
            }
        }
     }
  }
