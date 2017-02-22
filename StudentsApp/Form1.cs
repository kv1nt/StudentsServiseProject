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
        private readonly PanelAllStud _allStudPanel;
        public Form1()
        {
            _allStudPanel = new PanelAllStud();
            _allStudPanel.Dock = DockStyle.Fill;
            _allStudPanel.BringToFront();

            InitializeComponent();
           
            if (!panel.Controls.Contains(_allStudPanel))
            {
                panel.Controls.Clear();
                panel.Controls.Add(_allStudPanel);
            }
            _allStudPanel.LoadValueFromService();
        }

       
        private void buttonShowAllStud_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(_allStudPanel))
            {
                panel.Controls.Clear();
                panel.Controls.Add(_allStudPanel);
            }
            _allStudPanel.LoadValueFromService();
        }

        private void findStudent_btn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(FindStudentPanel.showStud))
            {
                panel.Controls.Clear();
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
                panel.Controls.Clear();
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
                panel.Controls.Clear();
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
                panel.Controls.Clear();
                panel.Controls.Add(UpdateStudetInfo.updateStudent);
                UpdateStudetInfo.updateStudent.Dock = DockStyle.Fill;
                UpdateStudetInfo.updateStudent.BringToFront();
            }
            else
            {
                UpdateStudetInfo.updateStudent.BringToFront();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
