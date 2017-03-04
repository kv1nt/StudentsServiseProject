using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DbEntities;
using StudentsApp.StudentService2;

namespace StudentsApp
{
    public partial class UpdateStudetInfo : UserControl
    {
        private static UpdateStudetInfo studListView;

        
        public static UpdateStudetInfo updateStudent
        {
            get
            {
                if (studListView == null)
                    studListView = new UpdateStudetInfo();
                return studListView;
            }
        }

        public UpdateStudetInfo()
        {
            InitializeComponent();
        }
       

        private void findStudentById_btn_Click(object sender, EventArgs e)
        {
            LastNameStudField.Text = "";
            NameStudField.Text = "";
            SurnameStudField.Text = "";
            AgeStudField.Text = "";
            BirthDateStudField.Text = "";
            AddressStudField.Text = "";
            ProgressStudField.Text = "";
            GroupStudField.Text = "";
            NumbStudCertificateField.Text = "";
            StPhoneGridView.Rows.Clear();
            EditAdditionalRelGridView.Rows.Clear();
            EditRelInfoGridView.Rows.Clear();
            RelPhonesTable.Items.Clear();

           var id = Convert.ToInt32(InputIDTextBox.Text);

            using (StudentsServiceAppClient client = new StudentsServiceAppClient())
            {
                foreach (var item in client.StudetsInfoList())
                {
                    if (item.Id == id)
                    {
                        ShowIdField.Text = item.Id.ToString();
                        LastNameStudField.Text = item.LastName;
                        NameStudField.Text = item.FirstName;
                        SurnameStudField.Text = item.Surname;
                        AgeStudField.Text = item.Age.ToString();
                        BirthDateStudField.Text = item.Birthdate.ToString();
                        AddressStudField.Text = item.Adress.Address;
                        ProgressStudField.Text = item.StudentProgress.Progress.ToString();
                        GroupStudField.Text = item.Group.Speciality;
                        NumbStudCertificateField.Text = item.NumberRecordBook.ToString();
                        string phonesStud = string.Join(", ", item.StudentPhones?.Select(x => x.PhoneNumber.ToString()));
                        StPhoneGridView.Rows.Add(phonesStud);
                        
                        string name = string.Join(",", item.ParentsInfo?.Select(x => x.FirstName));
                        string lName = string.Join(",", item.ParentsInfo?.Select(x => x.LastName));
                        string lid = string.Join(",", item.ParentsInfo?.Select(x => x.Id));
                        string spec = string.Join(",", item.ParentsInfo?.Select(x => x.WorkPlace));

                        string additionalRelId = string.Join(",", item.ParentsInfo?.Select(x => x.Relation.Id.ToString()));
                        string additionalRelation = string.Join(",", item.ParentsInfo?.Select(x => x.Relation.Name).ToList());

                        string[] splitString1 = lName.Split(',');
                        string motherLName = splitString1[0].Trim();
                        string fatherLName = splitString1[1].Trim();

                        string[] splitStringId = lid.Split(',');
                        string motherId = splitStringId[0].Trim();
                        string fatherId = splitStringId[1].Trim();

                        string[] splitString = name.Split(',');
                        string motherFName = splitString[0].Trim();
                        string fatherFName = splitString[1].Trim();

                        string[] splitString3 = spec.Split(',');
                        string motherSpec = splitString3[0].Trim();
                        string fatherSpec = splitString3[1].Trim();

                        string[] splitString4 = additionalRelId.Split(',');
                        string[] relString = additionalRelation.Split(',');
                        string additionalRels = relString[0].Trim();
                        string additionalRelsId = splitString4[1].Trim();

                        string[] motherInforow = { motherLName, motherFName, motherSpec, motherId };
                        string[] fatherInforow = { fatherLName, fatherFName, fatherSpec, fatherId };
                        string[] additionalRelations = { additionalRels, additionalRelsId};

                        EditRelInfoGridView.Rows.Add(motherInforow);
                        EditRelInfoGridView.Rows.Add(fatherInforow);
                        EditAdditionalRelGridView.Rows.Add(additionalRelations);

                        var RelClient = new StudentsServiceAppClient();
                        foreach (var item2 in RelClient.ParentsInfosInfoList())
                        {
                            string phonesRelations = string.Join(",", item2.Phones.Select(x => x.PhoneNumber.ToString()));
                            string[] phoneRow = phonesRelations.Split(',');
                            string phoneRel = phoneRow[0].Trim();

                            var Row = new ListViewItem(phoneRel);
                            RelPhonesTable.Items.Add(Row);
                        }
                    }
                }
            }
        }

        private void SaveChanges_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ShowIdField.Text);
            string lname = LastNameStudField.Text;
            string name = NameStudField.Text;
            string surname = SurnameStudField.Text;
            int age = Convert.ToInt32(AgeStudField.Text);
            DateTime birthOfDate = Convert.ToDateTime(BirthDateStudField.Text);
            string address = AddressStudField.Text;
            float progress = float.Parse(ProgressStudField.Text);
            string group = GroupStudField.Text;
            int numbRecBook = Convert.ToInt32(NumbStudCertificateField.Text);
            string changedNumbersSt = StPhoneGridView.SelectedCells[0].Value.ToString();
            Phone newPhone = new Phone();
            newPhone.PhoneNumber = changedNumbersSt;

            string motherLastName = EditRelInfoGridView.Rows[0].Cells[0].Value.ToString();
            string  motherName = EditRelInfoGridView.Rows[0].Cells[1].Value.ToString();
            string motherWorkPlace = EditRelInfoGridView.Rows[0].Cells[2].Value.ToString();

            string fatherLastName = EditRelInfoGridView.Rows[1].Cells[0].Value.ToString();
            string fatherName = EditRelInfoGridView.Rows[1].Cells[1].Value.ToString();
            string fatherWorkPlace = EditRelInfoGridView.Rows[1].Cells[2].Value.ToString();
            string additionalRelInfo = EditAdditionalRelGridView.Rows[0].Cells[0].Value.ToString();

            int motherId = Convert.ToInt32(EditRelInfoGridView.Rows[0].Cells[3].Value.ToString());
            int fatherId = Convert.ToInt32(EditRelInfoGridView.Rows[1].Cells[3].Value.ToString());
            int additionalRelId = Convert.ToInt32(EditAdditionalRelGridView.Rows[0].Cells[1].Value.ToString());

            StudentsServiceAppClient ChagedStud = new StudentsServiceAppClient();
            StudentsServiceAppClient ChagedParents = new StudentsServiceAppClient();
            StudentsServiceAppClient ChagedAdditionalRel = new StudentsServiceAppClient();

            List<Phone> phoneS = new List<Phone>();
            phoneS.Clear();
            phoneS.Add(newPhone); 
                      
            ChagedStud.UpdateStudent(id, name, lname, surname, age, address, group, 
                                     numbRecBook, birthOfDate, progress, phoneS.ToArray());

            
            ChagedParents.UpdateParents(motherName, motherLastName, motherWorkPlace,
                                        fatherName, fatherLastName, fatherWorkPlace, motherId, fatherId);

            ChagedAdditionalRel.UpdateAdditionalRelations(additionalRelInfo, additionalRelId);
        }
      
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
