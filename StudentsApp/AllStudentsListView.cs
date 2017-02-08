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
    public partial class panelAllStud : UserControl
    {
        private static panelAllStud studListView;

        public static panelAllStud showAllStud
        {
            get
            {
                if(studListView == null)
                studListView = new panelAllStud();
                return studListView;
            }
        }

        public panelAllStud()
        {
            InitializeComponent();
        }
    }
}
