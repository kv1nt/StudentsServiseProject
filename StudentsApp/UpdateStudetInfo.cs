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

        private void FindStud_btn_Click(object sender, EventArgs e)
        {
            UpdateStudentGridView.Rows.Clear();

            var id = Convert.ToInt32(textBoxID.Text);

            using (var client = new StudentsServiceAppClient())
            {
                foreach (var item in client.StudetsInfoList())
                {
                    if (item.Id == id)
                    {
                        DataGridViewRow Row = new DataGridViewRow();
                        Row.CreateCells(UpdateStudentGridView);
                        
                        string phones = string.Join(", ", item.StudentPhones?.Select(x => x.PhoneNumber).ToList());
                        
                        Row.Cells[0].Value = item.Id.ToString();
                        Row.Cells[1].Value = item.FirstName;
                        Row.Cells[2].Value = item.Surname;
                        Row.Cells[3].Value = item.LastName;
                        Row.Cells[4].Value = item.Sex;
                        Row.Cells[5].Value = item.Age.ToString();
                        Row.Cells[6].Value = item.Birthdate.ToString();
                        Row.Cells[7].Value = phones;
                        Row.Cells[8].Value = item.NumberRecordBook.ToString();
                        Row.Cells[9].Value = item.Adress.Address;
                        Row.Cells[10].Value = item.StudentProgress.Progress;
                        Row.Cells[11].Value = item.Group;
                        UpdateStudentGridView.Rows.Add(Row);
                    }

                }
            }
        }
    }
}
