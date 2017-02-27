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
          
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SaveChanges_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
