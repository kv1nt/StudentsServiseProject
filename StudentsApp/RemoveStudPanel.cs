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
    public partial class RemoveStudPanel : UserControl
    {
        private static RemoveStudPanel studListView;

        public static RemoveStudPanel removeStud
        {
            get
            {
                if (studListView == null)
                    studListView = new RemoveStudPanel();
                return studListView;
            }
        }
        public RemoveStudPanel()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
