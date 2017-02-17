﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbEntities;
using StudentsApp.StudentService2;

namespace StudentsApp
{
    public partial class panelAllStud : UserControl
    {
        private static panelAllStud studListView;

        public static panelAllStud showAllStud
        {
            get
            {
                if (studListView == null)
                    studListView = new panelAllStud();
                return studListView;
            }
        }

        public panelAllStud()
        {
            InitializeComponent();
            using (var client = new StudentsServiceAppClient())
            {

                foreach (var item in client.StudetsInfoList())
                {
                   string phones = string.Join(", ", item.StudentPhones?.Select(x => x.PhoneNumber.ToList()));
                    string[] row = {item.Id.ToString(), item.FirstName,
                                    item.Surname,item.LastName,item.Sex,item.Age.ToString(),
                                    item.Birthdate.ToString(), phones};
                    
                    var listViewItem = new ListViewItem(row);
                    listViewAllStud.Items.Add(listViewItem);
                }
                listViewAllStud.Columns[0].Width = 0;
            }

        }

        private void listViewAllStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void panelAllStud_Load(object sender, EventArgs e)
        {
           
        }
    }
}

