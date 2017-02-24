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
    public partial class FindStudentPanel : UserControl
    {
        private static FindStudentPanel studListView;

        public static FindStudentPanel showStud
        {
            get
            {
                if (studListView == null)
                    studListView = new FindStudentPanel();
                return studListView;
            }
        }

        public FindStudentPanel()
        {
            InitializeComponent();
        }

        private void FindStudentByLastName_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(IDStudTextBox.Text);

            using (StudentsServiceAppClient client = new StudentsServiceAppClient())
            {
                foreach (var item in client.StudetsInfoList())
                {
                    if (item.Id == id)
                    {
                        string[] row =
                        {
                            item.Id.ToString(), item.FirstName, item.Surname, item.LastName, item.Sex,
                            item.Age.ToString(),
                            item.Birthdate.ToString(),
                            string.Join(", ", item.StudentPhones?.Select(x => x.PhoneNumber.ToString()))

                        };

                        string[] row2 =
                        {
                            item.NumberRecordBook.ToString(),item.Adress.Address,item.StudentProgress.Progress.ToString()
                        };

                        string mothName = string.Join(" ", item.ParentsInfo?.Select(x => x.FirstName.ToString()));
                        
                        string[] row3 =
                        {
                           mothName
                        };

                        var listView = new ListViewItem(row);
                        listViewStud.Items.Add(listView);
                        var listView1 = new ListViewItem(row2);
                        secondRow.Items.Add(listView1);
                        var listView3 = new ListViewItem(row3);
                        motherInfoList.Items.Add(listView3);
                    }
                }

            }
        }
    }
}
