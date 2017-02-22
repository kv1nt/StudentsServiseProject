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
    public partial class PanelAllStud : UserControl
    {
        //private static PanelAllStud _studListView;

        //public static PanelAllStud ShowAllStud
        //{
        //    get
        //    {
        //        if (_studListView == null)
        //            _studListView = new PanelAllStud();
        //        return _studListView;
        //    }
        //}

        public PanelAllStud()
        {
            InitializeComponent();
        }

        public void LoadValueFromService()
        {
            listViewAllStud.Items.Clear();
            using (var client = new StudentsServiceAppClient())
            {
                foreach (var item in client.StudetsInfoList())
                {
                    string phones = string.Join(", ", item.StudentPhones?.Select(x => x.PhoneNumber).ToList());
                    string[] row =
                    {
                        item.Id.ToString(), item.FirstName,
                        item.Surname, item.LastName, item.Sex, item.Age.ToString(),
                        item.Birthdate.ToString(), phones
                    };

                    var listViewItem = new ListViewItem(row);
                    listViewAllStud.Items.Add(listViewItem);
                }
            }
        }

        private void listViewAllStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void panelAllStud_Load(object sender, EventArgs e)
        {
           
        }
    }
}

