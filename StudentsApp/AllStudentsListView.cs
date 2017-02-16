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

namespace StudentsApp
{
    public partial class panelAllStud : UserControl
    {
        private static panelAllStud studListView;

        public static panelAllStud showAllStud
        {
            get
            {
                if (studListView == null)
                    studListView = new panelAllStud();
                return studListView;
            }
        }

        public panelAllStud()
        {
            InitializeComponent();
            using (StudentsServiceAppClient client = new StudentsServiceAppClient())
            {

                foreach (var item in client.StudetsInfoList())
                {
                    string[] row = {item.Id.ToString(), item.FirstName,
                                    item.LastName, item.Surname,item.Sex,item.Age.ToString(),
                                    item.Birthdate.ToString(),string.Join(", ", item.StudentPhones.Select(x => x.PhoneNumber).ToArray())};

                    var listViewItem = new ListViewItem(row);
                    listViewAllStud.Items.Add(listViewItem);
                }
                listViewAllStud.Columns[0].Width = 0;
            }

        }

        private void listViewAllStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListView listViewAllStud = new ListView();


        }

        private void panelAllStud_Load(object sender, EventArgs e)
        {
            //using (StudentsServiceAppClient client = new StudentsServiceAppClient())
            //{

            //    foreach (var item in client.StudetsInfoList())
            //    {
            //        string[] row = {item.Id.ToString(), item.FirstName,
            //                        item.LastName, item.Surname,item.Sex,item.Age.ToString(),
            //                        item.Birthdate.ToString(),item.StudentPhones.ToString()};

            //        var listViewItem = new ListViewItem(row);
            //        listViewAllStud.Items.Add(listViewItem);
            //    }
            //         listViewAllStud.Columns[0].Width = 0;
            //}
        }
    }
}

