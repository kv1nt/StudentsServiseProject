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
    }
}
