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
    }
}
