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
                            item.NumberRecordBook.ToString(),item.Adress.Address,item.StudentProgress.Progress.ToString(),item.Group.Speciality
                        };
                        
                        string name = string.Join(",", item.ParentsInfo?.Select(x => x.FirstName));
                        string lName = string.Join(",", item.ParentsInfo?.Select(x => x.LastName));
                        string spec = string.Join(",", item.ParentsInfo?.Select(x => x.WorkPlace));
                        string additionalRelation = string.Join(",", item.ParentsInfo?.Select(x => x.Relation.Name).ToList());

                        



                        string[] splitString = name.Split(',');
                        string motherFName = splitString[0].Trim();
                        string fatherFName = splitString[1].Trim();

                        string[] splitString1 = lName.Split(',');
                        string motherLName = splitString1[0].Trim();
                        string fatherLName = splitString1[1].Trim();

                        string[] splitString3 = spec.Split(',');
                        string motherSpec = splitString3[0].Trim();
                        string fatherSpec= splitString3[1].Trim();

                        string[] splitString4 = additionalRelation.Split(',');
                        string additionalRels = splitString4[0].Trim();


                        string[] row3 = {motherFName, motherLName, motherSpec};
                        string[] row4 = {fatherFName, fatherLName, fatherSpec};
                      
                        var listView = new ListViewItem(row);
                        listView.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                        listViewStud.Items.Add(listView);
                        var listView1 = new ListViewItem(row2);
                        listView1.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                        secondRow.Items.Add(listView1);
                        var listView3 = new ListViewItem(row3);
                        listView3.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                        motherInfoList.Items.Add(listView3);
                        var listView4 = new ListViewItem(row4);
                        listView4.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                        fatherInfo.Items.Add(listView4);
                        var listView5 = new ListViewItem(additionalRels);
                        listView5.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                        additionalRel.Items.Add(listView5);

                        var Pclient = new StudentsServiceAppClient();
                        foreach (var item1 in Pclient.ParentsInfosInfoList())
                        {
                            string phonesPar = string.Join(",", item1.Phones.Select(x => x.PhoneNumber.ToString()));
                            string[] splitString6 = phonesPar.Split(',');
                            string phoneRel = splitString6[0].Trim();
                            var listView6 = new ListViewItem(phoneRel);
                            listView6.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                            relationsPhones.Items.Add(listView6);
                        }

                    }
                }
            }
        }

        

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
