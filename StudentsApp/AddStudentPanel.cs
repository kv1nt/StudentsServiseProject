using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
