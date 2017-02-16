using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsApp.StudentService2;
using DbEntities;

namespace StudentsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!panel.Controls.Contains(panelAllStud.showAllStud))
            {
                panel.Controls.Add(panelAllStud.showAllStud);
                panelAllStud.showAllStud.Dock = DockStyle.Fill;
                panelAllStud.showAllStud.BringToFront();
            }
            else
            {
                panelAllStud.showAllStud.BringToFront();
            }

        }

       
        private void buttonShowAllStud_Click(object sender, EventArgs e)
        {

            if (!panel.Controls.Contains(panelAllStud.showAllStud))
            {
                panel.Controls.Add(panelAllStud.showAllStud);
                panelAllStud.showAllStud.Dock = DockStyle.Fill;
                panelAllStud.showAllStud.BringToFront();
            }
            else
            {
                panelAllStud.showAllStud.BringToFront();
            }
            
        }

        private void findStudent_btn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(FindStudentPanel.showStud))
            {
                panel.Controls.Add(FindStudentPanel.showStud);
                FindStudentPanel.showStud.Dock = DockStyle.Fill;
                FindStudentPanel.showStud.BringToFront();
            }
            else
            {
                FindStudentPanel.showStud.BringToFront();
            }
        }

        private void removeStud_btn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(RemoveStudPanel.removeStud))
            {
                panel.Controls.Add(RemoveStudPanel.removeStud);
                RemoveStudPanel.removeStud.Dock = DockStyle.Fill;
                RemoveStudPanel.removeStud.BringToFront();
            }
            else
            {
                RemoveStudPanel.removeStud.BringToFront();
            }
        }

        private void addStudent_btn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AddStudentPanel.addStudent))
            {
                panel.Controls.Add(AddStudentPanel.addStudent);
                AddStudentPanel.addStudent.Dock = DockStyle.Fill;
                AddStudentPanel.addStudent.BringToFront();
            }
            else
            {
                AddStudentPanel.addStudent.BringToFront();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UpdateStudetInfo.updateStudent))
            {
                panel.Controls.Add(UpdateStudetInfo.updateStudent);
                UpdateStudetInfo.updateStudent.Dock = DockStyle.Fill;
                UpdateStudetInfo.updateStudent.BringToFront();
            }
            else
            {
                UpdateStudetInfo.updateStudent.BringToFront();
            }
        }
    }
}
